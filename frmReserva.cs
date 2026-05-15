using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaReservaciones
{
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }

        private void frmReserva_Load(object sender, EventArgs e)
        {
            CargarClientes();
            CargarCanchas();
            CargarHorarios();

            dtpFecha.Value = DateTime.Today;
            dtpFecha.MinDate = DateTime.Today;
        }

        void CargarClientes()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT IdCliente, Nombre + ' ' + Apellido AS NombreCompleto FROM Cliente",
                    cn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cbCliente.DataSource = dt;
                cbCliente.DisplayMember = "NombreCompleto";
                cbCliente.ValueMember = "IdCliente";
            }
        }

        void CargarCanchas()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT IdCancha, Nombre, PrecioPorHora FROM Cancha WHERE Activa = 1",
                    cn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cbCancha.DataSource = dt;
                cbCancha.DisplayMember = "Nombre";
                cbCancha.ValueMember = "IdCancha";
            }
        }

        void CargarHorarios()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT IdHorario,
                      CONVERT(varchar, HoraInicio, 108)
                      + ' - ' +
                      CONVERT(varchar, HoraFin, 108) AS Turno
                      FROM Horario",
                    cn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                cbHorario.DataSource = dt;
                cbHorario.DisplayMember = "Turno";
                cbHorario.ValueMember = "IdHorario";
            }
        }

        private void cbCancha_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularMonto();
        }

        void CalcularMonto()
        {
            if (cbCancha.SelectedValue == null)
                return;

            // Evita error DataRowView
            if (cbCancha.SelectedValue is DataRowView)
                return;

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT PrecioPorHora FROM Cancha WHERE IdCancha = @id",
                    cn);

                cmd.Parameters.AddWithValue(
                    "@id",
                    Convert.ToInt32(cbCancha.SelectedValue));

                object val = cmd.ExecuteScalar();

                if (val != null)
                {
                    txtMonto.Text = Convert.ToDecimal(val)
                        .ToString("0.00");
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbCliente.SelectedValue == null ||
                cbCancha.SelectedValue == null ||
                cbHorario.SelectedValue == null)
            {
                MessageBox.Show(
                    "Complete todos los campos.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // Evita errores DataRowView
            if (cbCliente.SelectedValue is DataRowView ||
                cbCancha.SelectedValue is DataRowView ||
                cbHorario.SelectedValue is DataRowView)
            {
                return;
            }

            int idCliente = Convert.ToInt32(cbCliente.SelectedValue);
            int idCancha = Convert.ToInt32(cbCancha.SelectedValue);
            int idHorario = Convert.ToInt32(cbHorario.SelectedValue);

            DateTime fecha = dtpFecha.Value.Date;

            decimal monto = 0;

            if (!decimal.TryParse(txtMonto.Text, out monto))
            {
                MessageBox.Show(
                    "Monto inválido.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                // Verificar reserva duplicada
                SqlCommand chk = new SqlCommand(
                    @"SELECT COUNT(*)
                      FROM Reserva
                      WHERE IdCancha = @c
                      AND FechaReserva = @f
                      AND IdHorario = @h
                      AND Estado = 'Confirmada'",
                    cn);

                chk.Parameters.AddWithValue("@c", idCancha);
                chk.Parameters.AddWithValue("@f", fecha);
                chk.Parameters.AddWithValue("@h", idHorario);

                int existe = Convert.ToInt32(chk.ExecuteScalar());

                if (existe > 0)
                {
                    MessageBox.Show(
                        "Esa cancha ya está reservada en esa fecha y horario.",
                        "Cancha Ocupada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Reserva
                      (
                          IdCliente,
                          IdCancha,
                          IdHorario,
                          FechaReserva,
                          Monto,
                          Estado,
                          IdEmpleado
                      )
                      VALUES
                      (
                          @cl,
                          @ca,
                          @h,
                          @f,
                          @m,
                          'Confirmada',
                          @emp
                      )",
                    cn);

                cmd.Parameters.AddWithValue("@cl", idCliente);
                cmd.Parameters.AddWithValue("@ca", idCancha);
                cmd.Parameters.AddWithValue("@h", idHorario);
                cmd.Parameters.AddWithValue("@f", fecha);
                cmd.Parameters.AddWithValue("@m", monto);
                cmd.Parameters.AddWithValue("@emp", Sesion.IdEmpleado);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "✔ Reserva guardada correctamente.",
                    "OK",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}