namespace SistemaReservaciones
{
    partial class frmReserva
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblCancha = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();

            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.cbCancha = new System.Windows.Forms.ComboBox();
            this.cbHorario = new System.Windows.Forms.ComboBox();

            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtMonto = new System.Windows.Forms.TextBox();

            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblCliente
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(30, 30);
            this.lblCliente.Text = "Cliente:";

            // cbCliente
            this.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(170, 27);
            this.cbCliente.Size = new System.Drawing.Size(250, 24);

            // lblCancha
            this.lblCancha.AutoSize = true;
            this.lblCancha.Location = new System.Drawing.Point(30, 75);
            this.lblCancha.Text = "Cancha:";

            // cbCancha
            this.cbCancha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCancha.FormattingEnabled = true;
            this.cbCancha.Location = new System.Drawing.Point(170, 72);
            this.cbCancha.Size = new System.Drawing.Size(250, 24);
            this.cbCancha.SelectedIndexChanged += new System.EventHandler(this.cbCancha_SelectedIndexChanged);

            // lblHorario
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(30, 120);
            this.lblHorario.Text = "Horario:";

            // cbHorario
            this.cbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Location = new System.Drawing.Point(170, 117);
            this.cbHorario.Size = new System.Drawing.Size(250, 24);

            // lblFecha
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(30, 165);
            this.lblFecha.Text = "Fecha Reserva:";

            // dtpFecha
            this.dtpFecha.Location = new System.Drawing.Point(170, 162);
            this.dtpFecha.Size = new System.Drawing.Size(250, 22);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // lblMonto
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(30, 210);
            this.lblMonto.Text = "Monto (Q):";

            // txtMonto
            this.txtMonto.Location = new System.Drawing.Point(170, 207);
            this.txtMonto.Size = new System.Drawing.Size(100, 22);
            this.txtMonto.ReadOnly = true;
            this.txtMonto.BackColor = System.Drawing.Color.LightYellow;

            // btnGuardar
            this.btnGuardar.Location = new System.Drawing.Point(170, 260);
            this.btnGuardar.Size = new System.Drawing.Size(140, 35);
            this.btnGuardar.Text = "Guardar Reserva";
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnCancelar
            this.btnCancelar.Location = new System.Drawing.Point(320, 260);
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // frmReserva
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 340);

            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cbCliente);

            this.Controls.Add(this.lblCancha);
            this.Controls.Add(this.cbCancha);

            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.cbHorario);

            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);

            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.txtMonto);

            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);

            this.Name = "frmReserva";
            this.Text = "Nueva Reserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmReserva_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblCancha;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMonto;

        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.ComboBox cbCancha;
        private System.Windows.Forms.ComboBox cbHorario;

        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtMonto;

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}