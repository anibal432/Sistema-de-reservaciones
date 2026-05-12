using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaReservaciones
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            lblBienvenida.Text = $"Bienvenido, {Sesion.Nombre}";
        }

        // --- MANTENIMIENTOS ---
        private void mnuTiposCancha_Click(object sender, EventArgs e)
        {
            frmTipoCancha f = new frmTipoCancha();
            f.ShowDialog();
        }

        private void mnuCanchas_Click(object sender, EventArgs e)
        {
            frmCanchas f = new frmCanchas();
            f.ShowDialog();
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            frmCliente f = new frmCliente();
            f.ShowDialog();
        }

        private void mnuHorarios_Click(object sender, EventArgs e)
        {
            frmHorario f = new frmHorario();
            f.ShowDialog();
        }

        // --- RESERVAS ---
        private void mnuNuevaReserva_Click(object sender, EventArgs e)
        {
            frmReserva f = new frmReserva();
            f.ShowDialog();
        }

        private void mnuVerReservas_Click(object sender, EventArgs e)
        {
            frmVerReservas f = new frmVerReservas();
            f.ShowDialog();
        }

        // --- SALIR ---
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