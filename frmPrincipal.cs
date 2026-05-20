using System;
using System.Windows.Forms;

namespace SistemaReservaciones
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent(); // Carga todo lo que se diseña en el Visual Studio se crea aquí.
            lblBienvenida.Text = $"Bienvenido, {Sesion.Nombre}  |  Rol: {Sesion.Rol}"; //se llama interpolarización de cadenas, se muestra el nombre del usuario y su rol en la etiqueta de bienvenida.

            // SOLO ADMIN VE REPORTERÍA
            if (Sesion.Rol != "Administrador")
            {
                mnuReporteria.Visible = false;
            }
        }

        private void mnuTiposCancha_Click(object sender, EventArgs e)
        {
            new frmTipoCancha().ShowDialog();
        }

        private void mnuCanchas_Click(object sender, EventArgs e)
        {
            new frmCanchas().ShowDialog();
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            new frmCliente().ShowDialog();
        }

        private void mnuHorarios_Click(object sender, EventArgs e)
        {
            new frmHorario().ShowDialog();
        }

        private void mnuNuevaReserva_Click(object sender, EventArgs e)
        {
            new frmReserva().ShowDialog();
        }

        private void mnuVerReservas_Click(object sender, EventArgs e)
        {
            new frmVerReservas().ShowDialog();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea cerrar sesión?",
                "Cerrar Sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                new frmLogin().Show();
                this.Close();
            }
        }

        private void reporteReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteReservas frm =
    new frmReporteReservas();

            frm.ShowDialog();
        }
    }
}
