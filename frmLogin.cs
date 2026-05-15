using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaReservaciones
{
    public partial class frmLogin : Form
    {
        public frmLogin() { InitializeComponent(); }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario   = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Complete todos los campos.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                string query = @"SELECT IdEmpleado, Nombre, Rol 
                                 FROM Empleado 
                                 WHERE Usuario=@u AND Contrasena=@c";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@u", usuario);
                cmd.Parameters.AddWithValue("@c", contrasena);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Sesion.IdEmpleado = (int)dr["IdEmpleado"];
                    Sesion.Nombre     = dr["Nombre"].ToString();
                    Sesion.Rol        = dr["Rol"].ToString();

                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
