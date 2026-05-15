namespace SistemaReservaciones
{
    partial class frmHorario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHoraInicio  = new System.Windows.Forms.Label();
            this.lblHoraFin     = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtHoraInicio  = new System.Windows.Forms.TextBox();
            this.txtHoraFin     = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregar     = new System.Windows.Forms.Button();
            this.btnActualizar  = new System.Windows.Forms.Button();
            this.btnEliminar    = new System.Windows.Forms.Button();
            this.dgvHorarios    = new System.Windows.Forms.DataGridView();
            this.lblAyuda       = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.SuspendLayout();

            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(15, 20);
            this.lblHoraInicio.Text     = "Hora Inicio (HH:mm):";
            this.txtHoraInicio.Location = new System.Drawing.Point(160, 17);
            this.txtHoraInicio.Size     = new System.Drawing.Size(100, 22);
            this.txtHoraInicio.Text     = "08:00";

            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(15, 58);
            this.lblHoraFin.Text     = "Hora Fin (HH:mm):";
            this.txtHoraFin.Location = new System.Drawing.Point(160, 55);
            this.txtHoraFin.Size     = new System.Drawing.Size(100, 22);
            this.txtHoraFin.Text     = "09:00";

            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 96);
            this.lblDescripcion.Text     = "Descripción:";
            this.txtDescripcion.Location = new System.Drawing.Point(160, 93);
            this.txtDescripcion.Size     = new System.Drawing.Size(200, 22);

            this.lblAyuda.AutoSize  = true;
            this.lblAyuda.ForeColor = System.Drawing.Color.Gray;
            this.lblAyuda.Location  = new System.Drawing.Point(15, 130);
            this.lblAyuda.Text      = "Ejemplo: 08:00  /  09:30  /  14:00";

            this.btnAgregar.Location  = new System.Drawing.Point(15, 165);
            this.btnAgregar.Size      = new System.Drawing.Size(90, 28);
            this.btnAgregar.Text      = "Agregar";
            this.btnAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Click    += new System.EventHandler(this.btnAgregar_Click);

            this.btnActualizar.Location  = new System.Drawing.Point(120, 165);
            this.btnActualizar.Size      = new System.Drawing.Size(90, 28);
            this.btnActualizar.Text      = "Actualizar";
            this.btnActualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Click    += new System.EventHandler(this.btnActualizar_Click);

            this.btnEliminar.Location  = new System.Drawing.Point(225, 165);
            this.btnEliminar.Size      = new System.Drawing.Size(90, 28);
            this.btnEliminar.Text      = "Eliminar";
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Click    += new System.EventHandler(this.btnEliminar_Click);

            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Location          = new System.Drawing.Point(370, 10);
            this.dgvHorarios.Size              = new System.Drawing.Size(580, 400);
            this.dgvHorarios.ReadOnly          = true;
            this.dgvHorarios.AllowUserToAddRows    = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            this.dgvHorarios.SelectionMode     = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorarios.RowTemplate.Height = 24;
            this.dgvHorarios.CellClick        += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHorarios_CellClick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.lblHoraInicio);  this.Controls.Add(this.txtHoraInicio);
            this.Controls.Add(this.lblHoraFin);     this.Controls.Add(this.txtHoraFin);
            this.Controls.Add(this.lblDescripcion); this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvHorarios);
            this.Name          = "frmHorario";
            this.Text          = "Horarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load         += new System.EventHandler(this.frmHorario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label        lblHoraInicio, lblHoraFin, lblDescripcion, lblAyuda;
        private System.Windows.Forms.TextBox      txtHoraInicio, txtHoraFin, txtDescripcion;
        private System.Windows.Forms.Button       btnAgregar, btnActualizar, btnEliminar;
        private System.Windows.Forms.DataGridView dgvHorarios;
    }
}
