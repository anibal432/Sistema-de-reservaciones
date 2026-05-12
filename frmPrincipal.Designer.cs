namespace SistemaReservaciones
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuMantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTiposCancha = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCanchas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHorarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNuevaReserva = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVerReservas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMantenimientos,
            this.mnuReservas,
            this.mnuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMantenimientos
            // 
            this.mnuMantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTiposCancha,
            this.mnuCanchas,
            this.mnuClientes,
            this.mnuHorarios});
            this.mnuMantenimientos.Name = "mnuMantenimientos";
            this.mnuMantenimientos.Size = new System.Drawing.Size(130, 24);
            this.mnuMantenimientos.Text = "Mantenimientos";
            // 
            // mnuTiposCancha
            // 
            this.mnuTiposCancha.Name = "mnuTiposCancha";
            this.mnuTiposCancha.Size = new System.Drawing.Size(224, 26);
            this.mnuTiposCancha.Text = "Tipos de Cancha";
            // 
            // mnuCanchas
            // 
            this.mnuCanchas.Name = "mnuCanchas";
            this.mnuCanchas.Size = new System.Drawing.Size(224, 26);
            this.mnuCanchas.Text = "Canchas";
            // 
            // mnuClientes
            // 
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Size = new System.Drawing.Size(224, 26);
            this.mnuClientes.Text = "Clientes";
            // 
            // mnuHorarios
            // 
            this.mnuHorarios.Name = "mnuHorarios";
            this.mnuHorarios.Size = new System.Drawing.Size(224, 26);
            this.mnuHorarios.Text = "Horarios";
            // 
            // mnuReservas
            // 
            this.mnuReservas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNuevaReserva,
            this.mnuVerReservas});
            this.mnuReservas.Name = "mnuReservas";
            this.mnuReservas.Size = new System.Drawing.Size(80, 24);
            this.mnuReservas.Text = "Reservas";
            // 
            // mnuNuevaReserva
            // 
            this.mnuNuevaReserva.Name = "mnuNuevaReserva";
            this.mnuNuevaReserva.Size = new System.Drawing.Size(224, 26);
            this.mnuNuevaReserva.Text = "Nueva Reserva";
            // 
            // mnuVerReservas
            // 
            this.mnuVerReservas.Name = "mnuVerReservas";
            this.mnuVerReservas.Size = new System.Drawing.Size(224, 26);
            this.mnuVerReservas.Text = "Ver Reservas";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(52, 24);
            this.mnuSalir.Text = "Salir";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBienvenida.Font = new System.Drawing.Font("Arial Narrow", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(0, 28);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(298, 40);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Bienvenido al Sistema";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMantenimientos;
        private System.Windows.Forms.ToolStripMenuItem mnuTiposCancha;
        private System.Windows.Forms.ToolStripMenuItem mnuCanchas;
        private System.Windows.Forms.ToolStripMenuItem mnuClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuHorarios;
        private System.Windows.Forms.ToolStripMenuItem mnuReservas;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevaReserva;
        private System.Windows.Forms.ToolStripMenuItem mnuVerReservas;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.Label lblBienvenida;
    }
}