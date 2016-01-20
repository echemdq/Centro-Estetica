using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Diagnostics;
namespace Centro_Estetica
{
    public partial class frmReport : Form
    {
        Acceso_BD oacceso = new Acceso_BD();
        ControladoraProductos controlp = new ControladoraProductos();
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            try
            {
                List<Productos> list = controlp.BuscarEspecial("= 'masaje' ");
                reportViewer1.LocalReport.DataSources.Clear(); //clear report
                reportViewer1.LocalReport.ReportEmbeddedResource = "Centro_Estetica.Report5.rdlc"; // bind reportviewer with .rdlc
                Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", list); // set the datasource
                reportViewer1.LocalReport.DataSources.Add(dataset);
                dataset.Value = list;
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
