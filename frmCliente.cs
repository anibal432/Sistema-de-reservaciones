using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaReservaciones
{
    public partial class frmCliente : Form
    {
        int idSeleccionado = 0;

        public frmCliente() { InitializeComponent(); }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        void CargarClientes()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Cliente", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvClientes.DataSource = dt;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("Nombre y Apellido son obligatorios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Cliente (Nombre, Apellido, Telefono, Email, DPI)
                      VALUES (@n, @a, @t, @e, @d)", cn);
                cmd.Parameters.AddWithValue("@n", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@a", txtApellido.Text.Trim());
                cmd.Parameters.AddWithValue("@t", txtTelefono.Text.Trim());
                cmd.Parameters.AddWithValue("@e", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@d", txtDPI.Text.Trim());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente agregado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();
                Limpiar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Cliente SET Nombre=@n, Apellido=@a, Telefono=@t,
                      Email=@e, DPI=@d WHERE IdCliente=@id", cn);
                cmd.Parameters.AddWithValue("@n",  txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@a",  txtApellido.Text.Trim());
                cmd.Parameters.AddWithValue("@t",  txtTelefono.Text.Trim());
                cmd.Parameters.AddWithValue("@e",  txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@d",  txtDPI.Text.Trim());
                cmd.Parameters.AddWithValue("@id", idSeleccionado);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cliente actualizado.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarClientes();
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Eliminar este cliente?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();

                    // VALIDAR SI EL CLIENTE TIENE RESERVAS
                    SqlCommand validar = new SqlCommand(
                        "SELECT COUNT(*) FROM Reserva WHERE IdCliente=@id", cn);

                    validar.Parameters.AddWithValue("@id", idSeleccionado);

                    int existe = Convert.ToInt32(validar.ExecuteScalar());

                    if (existe > 0)
                    {
                        MessageBox.Show(
                            "No se puede eliminar este cliente porque tiene reservas registradas.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    // ELIMINAR SI NO TIENE RESERVAS
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Cliente WHERE IdCliente=@id", cn);

                    cmd.Parameters.AddWithValue("@id", idSeleccionado);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Cliente eliminado.",
                        "OK",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarClientes();
                    Limpiar();
                }
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];
            idSeleccionado    = Convert.ToInt32(fila.Cells["IdCliente"].Value);
            txtNombre.Text    = fila.Cells["Nombre"].Value.ToString();
            txtApellido.Text  = fila.Cells["Apellido"].Value.ToString();
            txtTelefono.Text  = fila.Cells["Telefono"].Value?.ToString() ?? "";
            txtEmail.Text     = fila.Cells["Email"].Value?.ToString() ?? "";
            txtDPI.Text       = fila.Cells["DPI"].Value?.ToString() ?? "";
        }

        void Limpiar()
        {
            idSeleccionado = 0;
            txtNombre.Clear(); txtApellido.Clear();
            txtTelefono.Clear(); txtEmail.Clear(); txtDPI.Clear();
        }
    }
}
