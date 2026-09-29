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
    public partial class FrmMantenimientoPacientes : Form
    {
        public FrmMantenimientoPacientes()
        {
            InitializeComponent();
            navegador1.NavegadorMetConfigurar("tblPaciente", 4, 4);
        }

        private void ConsultasBtnAyuda_Click(object sender, EventArgs e)
        {

        }

        private void ConsultasBtnReportes_Click(object sender, EventArgs e)
        {
            FrmReporte reporte = new FrmReporte();
            reporte.Show();
        }
    }
}
