using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaReservaciones
{
    public partial class frmVerReservas : Form
    {
        public frmVerReservas() { InitializeComponent(); }

        private void frmVerReservas_Load(object sender, EventArgs e)
        {
            CargarReservas();
        }

        void CargarReservas()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                string q = @"
                    SELECT r.IdReserva,
                           cl.Nombre + ' ' + cl.Apellido  AS Cliente,
                           ca.Nombre                      AS Cancha,
                           CONVERT(varchar,h.HoraInicio,108) + '-' +
                           CONVERT(varchar,h.HoraFin,108) AS Horario,
                           r.FechaReserva,
                           r.Monto,
                           r.Estado,
                           e.Nombre                       AS Empleado
                    FROM Reserva r
                    INNER JOIN Cliente  cl ON r.IdCliente  = cl.IdCliente
                    INNER JOIN Cancha   ca ON r.IdCancha   = ca.IdCancha
                    INNER JOIN Horario  h  ON r.IdHorario  = h.IdHorario
                    INNER JOIN Empleado e  ON r.IdEmpleado = e.IdEmpleado
                    ORDER BY r.FechaReserva DESC, h.HoraInicio";

                SqlDataAdapter da = new SqlDataAdapter(q, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReservas.DataSource = dt;
            }
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow == null) return;

            int idReserva = Convert.ToInt32(dgvReservas.CurrentRow.Cells["IdReserva"].Value);
            string estado = dgvReservas.CurrentRow.Cells["Estado"].Value.ToString();

            if (estado == "Cancelada")
            {
                MessageBox.Show("Esta reserva ya está cancelada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Cancelar esta reserva?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Reserva SET Estado='Cancelada' WHERE IdReserva=@id", cn);
                    cmd.Parameters.AddWithValue("@id", idReserva);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reserva cancelada.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarReservas();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarReservas();
        }
    }
}
