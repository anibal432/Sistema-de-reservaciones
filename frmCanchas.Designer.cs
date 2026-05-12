namespace SistemaReservaciones
{
    partial class frmCanchas
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
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvCanchas = new System.Windows.Forms.DataGridView();
            this.cbTipoCancha = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkActiva = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanchas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(221, 311);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 27;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(114, 311);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(11, 311);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Precio:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(8, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(88, 108);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(221, 22);
            this.txtPrecio.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(221, 22);
            this.txtNombre.TabIndex = 15;
            // 
            // dgvCanchas
            // 
            this.dgvCanchas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCanchas.Location = new System.Drawing.Point(331, 8);
            this.dgvCanchas.Name = "dgvCanchas";
            this.dgvCanchas.RowHeadersWidth = 51;
            this.dgvCanchas.RowTemplate.Height = 24;
            this.dgvCanchas.Size = new System.Drawing.Size(800, 435);
            this.dgvCanchas.TabIndex = 14;
            // 
            // cbTipoCancha
            // 
            this.cbTipoCancha.FormattingEnabled = true;
            this.cbTipoCancha.Location = new System.Drawing.Point(188, 167);
            this.cbTipoCancha.Name = "cbTipoCancha";
            this.cbTipoCancha.Size = new System.Drawing.Size(121, 24);
            this.cbTipoCancha.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tipo Cancha:";
            // 
            // chkActiva
            // 
            this.chkActiva.AutoSize = true;
            this.chkActiva.Location = new System.Drawing.Point(201, 216);
            this.chkActiva.Name = "chkActiva";
            this.chkActiva.Size = new System.Drawing.Size(66, 20);
            this.chkActiva.TabIndex = 30;
            this.chkActiva.Text = "Activo";
            this.chkActiva.UseVisualStyleBackColor = true;
            // 
            // frmCanchas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 450);
            this.Controls.Add(this.chkActiva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipoCancha);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvCanchas);
            this.Name = "frmCanchas";
            this.Text = "frmCanchas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCanchas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvCanchas;
        private System.Windows.Forms.ComboBox cbTipoCancha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkActiva;
    }
}