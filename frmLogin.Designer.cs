namespace SistemaReservaciones
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo      = new System.Windows.Forms.Label();
            this.lblUsuario     = new System.Windows.Forms.Label();
            this.lblContrasena  = new System.Windows.Forms.Label();
            this.txtUsuario     = new System.Windows.Forms.TextBox();
            this.txtContrasena  = new System.Windows.Forms.TextBox();
            this.btnIngresar    = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize  = true;
            this.lblTitulo.Font      = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location  = new System.Drawing.Point(130, 40);
            this.lblTitulo.Text      = "Sistema de Reservación de Canchas";

            // lblUsuario
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(160, 130);
            this.lblUsuario.Text     = "Usuario:";

            // txtUsuario
            this.txtUsuario.Location = new System.Drawing.Point(250, 127);
            this.txtUsuario.Size     = new System.Drawing.Size(200, 22);

            // lblContrasena
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(160, 175);
            this.lblContrasena.Text     = "Contraseña:";

            // txtContrasena
            this.txtContrasena.Location     = new System.Drawing.Point(250, 172);
            this.txtContrasena.Size         = new System.Drawing.Size(200, 22);
            this.txtContrasena.PasswordChar = '*';

            // btnIngresar
            this.btnIngresar.Location = new System.Drawing.Point(250, 220);
            this.btnIngresar.Size     = new System.Drawing.Size(200, 35);
            this.btnIngresar.Text     = "Ingresar";
            this.btnIngresar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Font     = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.Click   += new System.EventHandler(this.btnIngresar_Click);

            // frmLogin
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(660, 320);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.btnIngresar);
            this.Name            = "frmLogin";
            this.Text            = "Login - Sistema Canchas";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label   lblTitulo;
        private System.Windows.Forms.Label   lblUsuario;
        private System.Windows.Forms.Label   lblContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button  btnIngresar;
    }
}
