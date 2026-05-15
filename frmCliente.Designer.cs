namespace SistemaReservaciones
{
    partial class frmCliente
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDPI = new System.Windows.Forms.Label();

            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDPI = new System.Windows.Forms.TextBox();

            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();

            this.dgvClientes = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();

            // lblNombre
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 20);
            this.lblNombre.Text = "Nombre:";

            // txtNombre
            this.txtNombre.Location = new System.Drawing.Point(130, 17);
            this.txtNombre.Size = new System.Drawing.Size(200, 22);

            // lblApellido
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(15, 58);
            this.lblApellido.Text = "Apellido:";

            // txtApellido
            this.txtApellido.Location = new System.Drawing.Point(130, 55);
            this.txtApellido.Size = new System.Drawing.Size(200, 22);

            // lblTelefono
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(15, 96);
            this.lblTelefono.Text = "Teléfono:";

            // txtTelefono
            this.txtTelefono.Location = new System.Drawing.Point(130, 93);
            this.txtTelefono.Size = new System.Drawing.Size(200, 22);

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 134);
            this.lblEmail.Text = "Email:";

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(130, 131);
            this.txtEmail.Size = new System.Drawing.Size(200, 22);

            // lblDPI
            this.lblDPI.AutoSize = true;
            this.lblDPI.Location = new System.Drawing.Point(15, 172);
            this.lblDPI.Text = "DPI:";

            // txtDPI
            this.txtDPI.Location = new System.Drawing.Point(130, 169);
            this.txtDPI.Size = new System.Drawing.Size(200, 22);

            // btnAgregar
            this.btnAgregar.Location = new System.Drawing.Point(15, 220);
            this.btnAgregar.Size = new System.Drawing.Size(90, 28);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // btnActualizar
            this.btnActualizar.Location = new System.Drawing.Point(120, 220);
            this.btnActualizar.Size = new System.Drawing.Size(90, 28);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // btnEliminar
            this.btnEliminar.Location = new System.Drawing.Point(225, 220);
            this.btnEliminar.Size = new System.Drawing.Size(90, 28);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // dgvClientes
            this.dgvClientes.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            this.dgvClientes.Location = new System.Drawing.Point(370, 10);
            this.dgvClientes.Size = new System.Drawing.Size(700, 400);

            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;

            this.dgvClientes.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvClientes.RowTemplate.Height = 24;

            this.dgvClientes.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);

            // frmCliente
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1100, 450);

            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);

            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);

            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);

            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);

            this.Controls.Add(this.lblDPI);
            this.Controls.Add(this.txtDPI);

            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);

            this.Controls.Add(this.dgvClientes);

            this.Name = "frmCliente";
            this.Text = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            this.Load += new System.EventHandler(this.frmCliente_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDPI;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDPI;

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;

        private System.Windows.Forms.DataGridView dgvClientes;
    }
}