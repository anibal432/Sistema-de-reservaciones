using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaReservaciones
{
    public partial class frmCanchas : Form
    {
        /*es para guardar el id de la cancha que el usuario clickea en el datagridview, para luego usarlo en actualizar o eliminar
        empieza en 0 porque no hay ninguna cancha seleccionada al abrir el formulario*/
        int idSeleccionado = 0;

        public frmCanchas() { InitializeComponent(); }

        //abre el formulario
        private void frmCanchas_Load(object sender, EventArgs e)
        {
            CargarTiposCancha();
            CargarCanchas();
        }
        //carga los tipos de cancha en el combobox
        void CargarTiposCancha()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT IdTipoCancha, Nombre FROM TipoCancha", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbTipoCancha.DataSource    = dt;
                cbTipoCancha.DisplayMember = "Nombre";
                cbTipoCancha.ValueMember   = "IdTipoCancha";
            }
        }
        //carga las canchas en el datagridview
        void CargarCanchas()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                string q = @"SELECT c.IdCancha, c.Nombre, t.Nombre AS TipoCancha,
                                    c.PrecioPorHora, c.Activa
                             FROM Cancha c
                             INNER JOIN TipoCancha t ON c.IdTipoCancha = t.IdTipoCancha";
                SqlDataAdapter da = new SqlDataAdapter(q, cn); // Ejecuta la consulta y llena el DataTable
                DataTable dt = new DataTable(); // Crea un DataTable para almacenar los resultados
                da.Fill(dt); // Llena el DataTable con los resultados de la consulta
                dgvCanchas.DataSource = dt; // Muestra los datos en el DataGridView
            }
        }

        //agrega una nueva cancha a la base de datos
        private void btnAgregar_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text)) //valida que los campos no estén vacíos
            {
                MessageBox.Show("Complete todos los campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio)) //valida que el precio sea un número decimal
            {
                MessageBox.Show("El precio debe ser numérico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection cn = Conexion.ObtenerConexion()) //abre la conexión a la base de datos y ejecuta el comando para insertar una nueva cancha
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Cancha (Nombre, IdTipoCancha, PrecioPorHora, Activa)
                      VALUES (@n, @t, @p, @a)", cn);
                cmd.Parameters.AddWithValue("@n", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@t", (int)cbTipoCancha.SelectedValue); 
                cmd.Parameters.AddWithValue("@p", precio);
                cmd.Parameters.AddWithValue("@a", chkActiva.Checked ? 1 : 0);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cancha agregada.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCanchas();
                Limpiar();
            }
        }

        /* private void btnActualizar_Click(object sender, EventArgs e)
         {
             if (idSeleccionado == 0)
             {
                 MessageBox.Show("Seleccione una cancha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }
             if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
             {
                 MessageBox.Show("El precio debe ser numérico.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             }
             using (SqlConnection cn = Conexion.ObtenerConexion())
             {
                 cn.Open();
                 SqlCommand cmd = new SqlCommand(
                     @"UPDATE Cancha SET Nombre=@n, IdTipoCancha=@t,
                       PrecioPorHora=@p, Activa=@a WHERE IdCancha=@id", cn);
                 cmd.Parameters.AddWithValue("@n",  txtNombre.Text.Trim());
                 cmd.Parameters.AddWithValue("@t",  (int)cbTipoCancha.SelectedValue);
                 cmd.Parameters.AddWithValue("@p",  precio);
                 cmd.Parameters.AddWithValue("@a",  chkActiva.Checked ? 1 : 0);
                 cmd.Parameters.AddWithValue("@id", idSeleccionado);
                 cmd.ExecuteNonQuery();
                 MessageBox.Show("Cancha actualizada.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 CargarCanchas();
                 Limpiar();
             }
         }
        */
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0) 
            {
                MessageBox.Show(
                    "Seleccione una cancha.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio)) //valida que el precio sea un número decimal
            {
                MessageBox.Show(
                    "El precio debe ser numérico.",
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();

                // VALIDAR SOLO SI QUIERE DESACTIVAR
                if (chkActiva.Checked == false)
                {
                    SqlCommand validar = new SqlCommand(
                        @"SELECT COUNT(*)
                  FROM Reserva
                  WHERE IdCancha=@id
                  AND FechaReserva >= CAST(GETDATE() AS DATE)
                  AND Estado='Confirmada'",
                          cn);

                    validar.Parameters.AddWithValue("@id", idSeleccionado);

                    int existe = Convert.ToInt32(validar.ExecuteScalar()); // Si existe alguna reserva futura confirmada para esta cancha

                    if (existe > 0) // Si hay reservas futuras, no se puede desactivar la cancha
                    {
                        MessageBox.Show(
                            "No se puede desactivar esta cancha porque tiene reservas futuras.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }
                }

                // ACTUALIZAR
                SqlCommand cmd = new SqlCommand(
                    @"UPDATE Cancha
              SET Nombre=@n,
                  IdTipoCancha=@t,
                  PrecioPorHora=@p,
                  Activa=@a
              WHERE IdCancha=@id", cn);

                cmd.Parameters.AddWithValue("@n", txtNombre.Text.Trim());

                cmd.Parameters.AddWithValue("@t",
                    (int)cbTipoCancha.SelectedValue);

                cmd.Parameters.AddWithValue("@p", precio);

                cmd.Parameters.AddWithValue("@a",
                    chkActiva.Checked ? 1 : 0);

                cmd.Parameters.AddWithValue("@id",
                    idSeleccionado);

                cmd.ExecuteNonQuery();

                MessageBox.Show(
                    "Cancha actualizada.",
                    "OK",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                CargarCanchas();
                Limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una cancha.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Eliminar esta cancha?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (SqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();

                    // VALIDAR SI LA CANCHA TIENE RESERVAS
                    SqlCommand validar = new SqlCommand(
                        "SELECT COUNT(*) FROM Reserva WHERE IdCancha=@id", cn);

                    validar.Parameters.AddWithValue("@id", idSeleccionado);

                    int existe = Convert.ToInt32(validar.ExecuteScalar());

                    if (existe > 0)
                    {
                        MessageBox.Show(
                            "No se puede eliminar esta cancha porque tiene reservas registradas.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    // ELIMINAR SI NO TIENE RELACIONES
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Cancha WHERE IdCancha=@id", cn);

                    cmd.Parameters.AddWithValue("@id", idSeleccionado);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Cancha eliminada.",
                        "OK",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarCanchas();
                    Limpiar();
                }
            }
        }

        private void dgvCanchas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow fila = dgvCanchas.Rows[e.RowIndex];
            idSeleccionado    = Convert.ToInt32(fila.Cells["IdCancha"].Value);
            txtNombre.Text    = fila.Cells["Nombre"].Value.ToString();
            txtPrecio.Text    = fila.Cells["PrecioPorHora"].Value.ToString();
            chkActiva.Checked = Convert.ToBoolean(fila.Cells["Activa"].Value);
        }

        void Limpiar()
        {
            idSeleccionado = 0;
            txtNombre.Clear();
            txtPrecio.Clear();
            chkActiva.Checked = true;
        }
    }
}
