using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaReservaciones
{
    public partial class frmReporteReservas : Form
    {
        private ReportViewer reportViewer1;

        public frmReporteReservas()
        {
            InitializeComponent();
        }

        private void frmReporteReservas_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void CargarReporte()
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM vw_ReporteReservas ORDER BY FechaReserva ASC";

                SqlDataAdapter da = new SqlDataAdapter(query, cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                ReportDataSource rds = new ReportDataSource("DataSet1", dt);

                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.LocalReport.ReportEmbeddedResource =
                    "SistemaReservaciones.ReportReservas.rdlc";
                reportViewer1.RefreshReport();
            }
        }

        private void InitializeComponent()
        {
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource =
                "SistemaReservaciones.ReportReservas.rdlc"; 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(744, 435);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmReporteReservas
            // 
            this.ClientSize = new System.Drawing.Size(744, 435);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReporteReservas";
            this.Load += new System.EventHandler(this.frmReporteReservas_Load);
            this.ResumeLayout(false);
        }
    }
}