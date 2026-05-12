using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaReservaciones
{
    public partial class frmCliente : Form
    {
        int idSeleccionado = 0;

        public frmCliente()
        {
            InitializeComponent();
        }

        // ==================================
        // CARGAR FORMULARIO
        // ==================================
        private void frmCliente_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        // ==================================
        // MOSTRAR CLIENTES
        // ==================================
        void CargarClientes()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                string query = "SELECT * FROM Cliente";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, cn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvClientes.DataSource = dt;
            }
        }

        // ==================================
        // AGREGAR CLIENTE
        // ==================================
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                string query =
                    @"INSERT INTO Cliente
                    (Nombre, Apellido, Telefono, Email, DPI)
                    VALUES
                    (@Nombre, @Apellido, @Telefono, @Email, @DPI)";

                SqlCommand cmd =
                    new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue(
                    "@Nombre", txtNombre.Text);

                cmd.Parameters.AddWithValue(
                    "@Apellido", txtApellido.Text);

                cmd.Parameters.AddWithValue(
                    "@Telefono", txtTelefono.Text);

                cmd.Parameters.AddWithValue(
                    "@Email", txtEmail.Text);

                cmd.Parameters.AddWithValue(
                    "@DPI", txtDPI.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente agregado.");

                CargarClientes();

                Limpiar();
            }
        }

        // ==================================
        // ACTUALIZAR CLIENTE
        // ==================================
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un cliente.");

                return;
            }

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                string query =
                    @"UPDATE Cliente
                    SET Nombre=@Nombre,
                        Apellido=@Apellido,
                        Telefono=@Telefono,
                        Email=@Email,
                        DPI=@DPI
                    WHERE IdCliente=@IdCliente";

                SqlCommand cmd =
                    new SqlCommand(query, cn);

                cmd.Parameters.AddWithValue(
                    "@Nombre", txtNombre.Text);

                cmd.Parameters.AddWithValue(
                    "@Apellido", txtApellido.Text);

                cmd.Parameters.AddWithValue(
                    "@Telefono", txtTelefono.Text);

                cmd.Parameters.AddWithValue(
                    "@Email", txtEmail.Text);

                cmd.Parameters.AddWithValue(
                    "@DPI", txtDPI.Text);

                cmd.Parameters.AddWithValue(
                    "@IdCliente", idSeleccionado);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Cliente actualizado.");

                CargarClientes();

                Limpiar();
            }
        }

        // ==================================
        // ELIMINAR CLIENTE
        // ==================================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show(
                    "Seleccione un cliente.");

                return;
            }

            DialogResult resultado =
                MessageBox.Show(
                    "¿Desea eliminar este cliente?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                using (SqlConnection cn =
                    Conexion.ObtenerConexion())
                {
                    cn.Open();

                    string query =
                        "DELETE FROM Cliente WHERE IdCliente=@IdCliente";

                    SqlCommand cmd =
                        new SqlCommand(query, cn);

                    cmd.Parameters.AddWithValue(
                        "@IdCliente", idSeleccionado);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Cliente eliminado.");

                    CargarClientes();

                    Limpiar();
                }
            }
        }

        // ==================================
        // CLICK EN DATAGRIDVIEW
        // ==================================
        private void dgvClientes_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila =
                    dgvClientes.Rows[e.RowIndex];

                idSeleccionado =
                    Convert.ToInt32(
                        fila.Cells["IdCliente"].Value);

                txtNombre.Text =
                    fila.Cells["Nombre"].Value.ToString();

                txtApellido.Text =
                    fila.Cells["Apellido"].Value.ToString();

                txtTelefono.Text =
                    fila.Cells["Telefono"].Value.ToString();

                txtEmail.Text =
                    fila.Cells["Email"].Value.ToString();

                txtDPI.Text =
                    fila.Cells["DPI"].Value.ToString();
            }
        }

        // ==================================
        // LIMPIAR CAMPOS
        // ==================================
        void Limpiar()
        {
            idSeleccionado = 0;

            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDPI.Clear();
        }
    }
}