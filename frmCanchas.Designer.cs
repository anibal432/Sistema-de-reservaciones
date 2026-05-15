namespace SistemaReservaciones
{
    partial class frmCanchas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNombre     = new System.Windows.Forms.Label();
            this.lblPrecio     = new System.Windows.Forms.Label();
            this.lblTipo       = new System.Windows.Forms.Label();
            this.txtNombre     = new System.Windows.Forms.TextBox();
            this.txtPrecio     = new System.Windows.Forms.TextBox();
            this.cbTipoCancha  = new System.Windows.Forms.ComboBox();
            this.chkActiva     = new System.Windows.Forms.CheckBox();
            this.btnAgregar    = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar   = new System.Windows.Forms.Button();
            this.dgvCanchas    = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanchas)).BeginInit();
            this.SuspendLayout();

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 20);
            this.lblNombre.Text     = "Nombre:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(130, 17);
            this.txtNombre.Size     = new System.Drawing.Size(200, 22);

            // lblPrecio
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(15, 58);
            this.lblPrecio.Text     = "Precio por hora:";

            // txtPrecio
            this.txtPrecio.Location = new System.Drawing.Point(130, 55);
            this.txtPrecio.Size     = new System.Drawing.Size(200, 22);

            // lblTipo
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(15, 96);
            this.lblTipo.Text     = "Tipo de Cancha:";

            // cbTipoCancha
            this.cbTipoCancha.DropDownStyle     = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCancha.FormattingEnabled = true;
            this.cbTipoCancha.Location          = new System.Drawing.Point(130, 93);
            this.cbTipoCancha.Size              = new System.Drawing.Size(200, 24);

            // chkActiva
            this.chkActiva.AutoSize = true;
            this.chkActiva.Checked  = true;
            this.chkActiva.Location = new System.Drawing.Point(130, 135);
            this.chkActiva.Text     = "Activa";

            // btnAgregar
            this.btnAgregar.Location  = new System.Drawing.Point(15, 175);
            this.btnAgregar.Size      = new System.Drawing.Size(90, 28);
            this.btnAgregar.Text      = "Agregar";
            this.btnAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Click    += new System.EventHandler(this.btnAgregar_Click);

            // btnActualizar
            this.btnActualizar.Location  = new System.Drawing.Point(120, 175);
            this.btnActualizar.Size      = new System.Drawing.Size(90, 28);
            this.btnActualizar.Text      = "Actualizar";
            this.btnActualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Click    += new System.EventHandler(this.btnActualizar_Click);

            // btnEliminar
            this.btnEliminar.Location  = new System.Drawing.Point(225, 175);
            this.btnEliminar.Size      = new System.Drawing.Size(90, 28);
            this.btnEliminar.Text      = "Eliminar";
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Click    += new System.EventHandler(this.btnEliminar_Click);

            // dgvCanchas
            this.dgvCanchas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanchas.Location          = new System.Drawing.Point(370, 10);
            this.dgvCanchas.Size              = new System.Drawing.Size(680, 400);
            this.dgvCanchas.ReadOnly          = true;
            this.dgvCanchas.AllowUserToAddRows    = false;
            this.dgvCanchas.AllowUserToDeleteRows = false;
            this.dgvCanchas.SelectionMode     = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCanchas.RowTemplate.Height = 24;
            this.dgvCanchas.CellClick        += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCanchas_CellClick);

            // frmCanchas
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(1080, 450);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cbTipoCancha);
            this.Controls.Add(this.chkActiva);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvCanchas);
            this.Name          = "frmCanchas";
            this.Text          = "Canchas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load         += new System.EventHandler(this.frmCanchas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanchas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label        lblNombre;
        private System.Windows.Forms.Label        lblPrecio;
        private System.Windows.Forms.Label        lblTipo;
        private System.Windows.Forms.TextBox      txtNombre;
        private System.Windows.Forms.TextBox      txtPrecio;
        private System.Windows.Forms.ComboBox     cbTipoCancha;
        private System.Windows.Forms.CheckBox     chkActiva;
        private System.Windows.Forms.Button       btnAgregar;
        private System.Windows.Forms.Button       btnActualizar;
        private System.Windows.Forms.Button       btnEliminar;
        private System.Windows.Forms.DataGridView dgvCanchas;
    }
}
