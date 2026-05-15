using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaReservaciones
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Empleado
                    (Nombre, Usuario, Contrasena, Rol)
                    VALUES
                    (@n, @u, @c, @r)", cn);

                cmd.Parameters.AddWithValue("@n", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@u", txtUsuario.Text.Trim());
                cmd.Parameters.AddWithValue("@c", txtContrasena.Text.Trim());
                cmd.Parameters.AddWithValue("@r", cbRol.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Empleado registrado.");
            }
        }
    }
}
