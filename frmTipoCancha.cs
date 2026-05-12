using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaReservaciones
{
    public partial class frmTipoCancha : Form
    {
        int idSeleccionado = 0;

        public frmTipoCancha()
        {
            InitializeComponent();
        }

        private void frmTipoCancha_Load(object sender, EventArgs e)
        {
            CargarTipos();
        }

        void CargarTipos()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                SqlDataAdapter da =
                    new SqlDataAdapter(
                        "SELECT * FROM TipoCancha", cn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvTipoCancha.DataSource = dt;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                string q =
                    @"INSERT INTO TipoCancha
                    (Nombre,Descripcion)
                    VALUES(@n,@d)";

                SqlCommand cmd = new SqlCommand(q, cn);

                cmd.Parameters.AddWithValue(
                    "@n", txtNombre.Text);

                cmd.Parameters.AddWithValue(
                    "@d", txtDescripcion.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Tipo agregado");

                CargarTipos();
                Limpiar();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) return;

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                string q =
                    @"UPDATE TipoCancha
                    SET Nombre=@n,
                        Descripcion=@d
                    WHERE IdTipoCancha=@id";

                SqlCommand cmd = new SqlCommand(q, cn);

                cmd.Parameters.AddWithValue("@n", txtNombre.Text);
                cmd.Parameters.AddWithValue("@d", txtDescripcion.Text);
                cmd.Parameters.AddWithValue("@id", idSeleccionado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Actualizado");

                CargarTipos();
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) return;

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                SqlCommand cmd =
                    new SqlCommand(
                        "DELETE FROM TipoCancha WHERE IdTipoCancha=@id",
                        cn);

                cmd.Parameters.AddWithValue("@id", idSeleccionado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Eliminado");

                CargarTipos();
                Limpiar();
            }
        }

        private void dgvTipoCancha_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow fila =
                dgvTipoCancha.Rows[e.RowIndex];

            idSeleccionado =
                Convert.ToInt32(
                    fila.Cells["IdTipoCancha"].Value);

            txtNombre.Text =
                fila.Cells["Nombre"].Value.ToString();

            txtDescripcion.Text =
                fila.Cells["Descripcion"].Value.ToString();
        }

        void Limpiar()
        {
            idSeleccionado = 0;

            txtNombre.Clear();
            txtDescripcion.Clear();
        }
    }
}