using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaReservaciones
{
    public partial class frmHorario : Form
    {
        int idSeleccionado = 0;

        public frmHorario() { InitializeComponent(); }

        private void frmHorario_Load(object sender, EventArgs e)
        {
            CargarHorarios();
        }

        void CargarHorarios()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Horario", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvHorarios.DataSource = dt;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!TimeSpan.TryParse(txtHoraInicio.Text, out TimeSpan hi) ||
                !TimeSpan.TryParse(txtHoraFin.Text, out TimeSpan hf))
            {
                MessageBox.Show("Ingrese horas válidas (HH:mm).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Horario (HoraInicio, HoraFin, Descripcion) VALUES (@hi, @hf, @d)", cn);
                cmd.Parameters.AddWithValue("@hi", hi);
                cmd.Parameters.AddWithValue("@hf", hf);
                cmd.Parameters.AddWithValue("@d",  txtDescripcion.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Horario agregado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarHorarios();
                Limpiar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un horario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!TimeSpan.TryParse(txtHoraInicio.Text, out TimeSpan hi) ||
                !TimeSpan.TryParse(txtHoraFin.Text, out TimeSpan hf))
            {
                MessageBox.Show("Ingrese horas válidas (HH:mm).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE Horario SET HoraInicio=@hi, HoraFin=@hf, Descripcion=@d WHERE IdHorario=@id", cn);
                cmd.Parameters.AddWithValue("@hi", hi);
                cmd.Parameters.AddWithValue("@hf", hf);
                cmd.Parameters.AddWithValue("@d",  txtDescripcion.Text.Trim());
                cmd.Parameters.AddWithValue("@id", idSeleccionado);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Horario actualizado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarHorarios();
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un horario.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Eliminar este horario?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();

                    // VALIDAR SI EL HORARIO TIENE RESERVAS
                    SqlCommand validar = new SqlCommand(
                        "SELECT COUNT(*) FROM Reserva WHERE IdHorario=@id", cn);

                    validar.Parameters.AddWithValue("@id", idSeleccionado);

                    int existe = Convert.ToInt32(validar.ExecuteScalar());

                    if (existe > 0)
                    {
                        MessageBox.Show(
                            "No se puede eliminar este horario porque tiene reservas registradas.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    // ELIMINAR SI NO TIENE RELACIÓN
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Horario WHERE IdHorario=@id", cn);

                    cmd.Parameters.AddWithValue("@id", idSeleccionado);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Horario eliminado.",
                        "OK",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarHorarios();
                    Limpiar();
                }
            }
        }

        private void dgvHorarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvHorarios.Rows[e.RowIndex];
            idSeleccionado       = Convert.ToInt32(fila.Cells["IdHorario"].Value);
            txtHoraInicio.Text   = fila.Cells["HoraInicio"].Value.ToString();
            txtHoraFin.Text      = fila.Cells["HoraFin"].Value.ToString();
            txtDescripcion.Text  = fila.Cells["Descripcion"].Value?.ToString() ?? "";
        }

        void Limpiar()
        {
            idSeleccionado = 0;
            txtHoraInicio.Clear();
            txtHoraFin.Clear();
            txtDescripcion.Clear();
        }
    }
}
