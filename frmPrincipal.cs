using System;
using System.Windows.Forms;

namespace SistemaReservaciones
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            lblBienvenida.Text = $"Bienvenido, {Sesion.Nombre}  |  Rol: {Sesion.Rol}";
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
            if (MessageBox.Show("¿Desea cerrar sesión?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
