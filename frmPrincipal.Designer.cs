namespace SistemaReservaciones
{
    partial class frmPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1        = new System.Windows.Forms.MenuStrip();
            this.mnuMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTiposCancha    = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCanchas        = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes       = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHorarios       = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReservas       = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuevaReserva   = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVerReservas    = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir          = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienvenida     = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuMantenimientos, this.mnuReservas, this.mnuSalir });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name     = "menuStrip1";
            this.menuStrip1.Size     = new System.Drawing.Size(900, 28);
            this.menuStrip1.Text     = "menuStrip1";

            // mnuMantenimientos
            this.mnuMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuTiposCancha, this.mnuCanchas, this.mnuClientes, this.mnuHorarios });
            this.mnuMantenimientos.Text = "Mantenimientos";

            // mnuTiposCancha
            this.mnuTiposCancha.Text   = "Tipos de Cancha";
            this.mnuTiposCancha.Click += new System.EventHandler(this.mnuTiposCancha_Click);

            // mnuCanchas
            this.mnuCanchas.Text   = "Canchas";
            this.mnuCanchas.Click += new System.EventHandler(this.mnuCanchas_Click);

            // mnuClientes
            this.mnuClientes.Text   = "Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.mnuClientes_Click);

            // mnuHorarios
            this.mnuHorarios.Text   = "Horarios";
            this.mnuHorarios.Click += new System.EventHandler(this.mnuHorarios_Click);

            // mnuReservas
            this.mnuReservas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuNuevaReserva, this.mnuVerReservas });
            this.mnuReservas.Text = "Reservas";

            // mnuNuevaReserva
            this.mnuNuevaReserva.Text   = "Nueva Reserva";
            this.mnuNuevaReserva.Click += new System.EventHandler(this.mnuNuevaReserva_Click);

            // mnuVerReservas
            this.mnuVerReservas.Text   = "Ver Reservas";
            this.mnuVerReservas.Click += new System.EventHandler(this.mnuVerReservas_Click);

            // mnuSalir
            this.mnuSalir.Text   = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);

            // lblBienvenida
            this.lblBienvenida.AutoSize  = false;
            this.lblBienvenida.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblBienvenida.Font      = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBienvenida.Text      = "Bienvenido al Sistema";

            // frmPrincipal
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip   = this.menuStrip1;
            this.Name            = "frmPrincipal";
            this.Text            = "Sistema de Reservación de Canchas";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip         menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem mnuTiposCancha;
        private System.Windows.Forms.ToolStripMenuItem mnuCanchas;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuHorarios;
        private System.Windows.Forms.ToolStripMenuItem mnuReservas;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevaReserva;
        private System.Windows.Forms.ToolStripMenuItem mnuVerReservas;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.Label             lblBienvenida;
    }
}
