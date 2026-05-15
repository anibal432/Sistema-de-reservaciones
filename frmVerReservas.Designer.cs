namespace SistemaReservaciones
{
    partial class frmVerReservas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvReservas          = new System.Windows.Forms.DataGridView();
            this.btnCancelarReserva   = new System.Windows.Forms.Button();
            this.btnActualizar        = new System.Windows.Forms.Button();
            this.lblInfo              = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.SuspendLayout();

            // dgvReservas
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location          = new System.Drawing.Point(10, 10);
            this.dgvReservas.Size              = new System.Drawing.Size(1100, 480);
            this.dgvReservas.ReadOnly          = true;
            this.dgvReservas.AllowUserToAddRows    = false;
            this.dgvReservas.AllowUserToDeleteRows = false;
            this.dgvReservas.SelectionMode     = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.RowTemplate.Height = 24;
            this.dgvReservas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // lblInfo
            this.lblInfo.AutoSize  = true;
            this.lblInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblInfo.Location  = new System.Drawing.Point(10, 500);
            this.lblInfo.Text      = "Seleccione una fila y presione 'Cancelar Reserva' para cambiar su estado.";

            // btnCancelarReserva
            this.btnCancelarReserva.Location  = new System.Drawing.Point(10, 525);
            this.btnCancelarReserva.Size      = new System.Drawing.Size(160, 32);
            this.btnCancelarReserva.Text      = "Cancelar Reserva";
            this.btnCancelarReserva.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelarReserva.ForeColor = System.Drawing.Color.White;
            this.btnCancelarReserva.Font      = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelarReserva.Click    += new System.EventHandler(this.btnCancelarReserva_Click);

            // btnActualizar
            this.btnActualizar.Location  = new System.Drawing.Point(185, 525);
            this.btnActualizar.Size      = new System.Drawing.Size(120, 32);
            this.btnActualizar.Text      = "⟳ Actualizar";
            this.btnActualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Click    += new System.EventHandler(this.btnActualizar_Click);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(1130, 575);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCancelarReserva);
            this.Controls.Add(this.btnActualizar);
            this.Name          = "frmVerReservas";
            this.Text          = "Ver Reservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load         += new System.EventHandler(this.frmVerReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button       btnCancelarReserva;
        private System.Windows.Forms.Button       btnActualizar;
        private System.Windows.Forms.Label        lblInfo;
    }
}
