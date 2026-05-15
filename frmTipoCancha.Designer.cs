namespace SistemaReservaciones
{
    partial class frmTipoCancha
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblNombre      = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtNombre      = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAgregar     = new System.Windows.Forms.Button();
            this.btnActualizar  = new System.Windows.Forms.Button();
            this.btnEliminar    = new System.Windows.Forms.Button();
            this.dgvTipoCancha  = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCancha)).BeginInit();
            this.SuspendLayout();

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 20);
            this.lblNombre.Text     = "Nombre:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(120, 17);
            this.txtNombre.Size     = new System.Drawing.Size(220, 22);

            // lblDescripcion
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 60);
            this.lblDescripcion.Text     = "Descripción:";

            // txtDescripcion
            this.txtDescripcion.Location = new System.Drawing.Point(120, 57);
            this.txtDescripcion.Size     = new System.Drawing.Size(220, 22);

            // btnAgregar
            this.btnAgregar.Location  = new System.Drawing.Point(15, 110);
            this.btnAgregar.Size      = new System.Drawing.Size(90, 28);
            this.btnAgregar.Text      = "Agregar";
            this.btnAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Click    += new System.EventHandler(this.btnAgregar_Click);

            // btnActualizar
            this.btnActualizar.Location  = new System.Drawing.Point(120, 110);
            this.btnActualizar.Size      = new System.Drawing.Size(90, 28);
            this.btnActualizar.Text      = "Actualizar";
            this.btnActualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Click    += new System.EventHandler(this.btnActualizar_Click);

            // btnEliminar
            this.btnEliminar.Location  = new System.Drawing.Point(225, 110);
            this.btnEliminar.Size      = new System.Drawing.Size(90, 28);
            this.btnEliminar.Text      = "Eliminar";
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Click    += new System.EventHandler(this.btnEliminar_Click);

            // dgvTipoCancha
            this.dgvTipoCancha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoCancha.Location       = new System.Drawing.Point(370, 10);
            this.dgvTipoCancha.Name           = "dgvTipoCancha";
            this.dgvTipoCancha.RowHeadersWidth = 51;
            this.dgvTipoCancha.RowTemplate.Height = 24;
            this.dgvTipoCancha.Size           = new System.Drawing.Size(580, 400);
            this.dgvTipoCancha.ReadOnly       = true;
            this.dgvTipoCancha.AllowUserToAddRows    = false;
            this.dgvTipoCancha.AllowUserToDeleteRows = false;
            this.dgvTipoCancha.SelectionMode  = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipoCancha.CellClick     += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTipoCancha_CellClick);

            // frmTipoCancha
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(980, 450);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvTipoCancha);
            this.Name          = "frmTipoCancha";
            this.Text          = "Tipos de Cancha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load         += new System.EventHandler(this.frmTipoCancha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCancha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label        lblNombre;
        private System.Windows.Forms.Label        lblDescripcion;
        private System.Windows.Forms.TextBox      txtNombre;
        private System.Windows.Forms.TextBox      txtDescripcion;
        private System.Windows.Forms.Button       btnAgregar;
        private System.Windows.Forms.Button       btnActualizar;
        private System.Windows.Forms.Button       btnEliminar;
        private System.Windows.Forms.DataGridView dgvTipoCancha;
    }
}
