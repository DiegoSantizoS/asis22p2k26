using CapaVista_Seguridad.frmReportes;
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

namespace CapaVista_Seguridad
{
    public partial class FrmNavegador : Form
    {
        public FrmNavegador()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tblempleado", 4, 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmReporteAsignacionAplicacionUsuario reporte = new FrmReporteAsignacionAplicacionUsuario();
            reporte.Show();
        }

        private void FrmNavegador_Load(object sender, EventArgs e)
        {
            
            //ReportDataSource reporte = new ReportDataSource("DataSet1", GetAll());

        }
    }
}
