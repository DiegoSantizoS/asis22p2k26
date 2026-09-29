using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista_Mantenimiento2k26
{
    public partial class FrmReporte : Form
    {
        CapaControlador_Seguridad.ClsModeloUsuario usuario = new CapaControlador_Seguridad.ClsModeloUsuario();
        public FrmReporte()
        {
            InitializeComponent();
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", usuario);
            reportViewer1.LocalReport.ReportEmbeddedResource = "FrmReporte.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
