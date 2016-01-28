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
        List<InfHonorarios> list = new List<InfHonorarios>();
        ControladoraProductos controlp = new ControladoraProductos();
        string dia = "";
        public frmReport(List<InfHonorarios> list1, string dia1)
        {
            InitializeComponent();
            list = list1;
            dia = dia1;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            try
            {

                ReportParameter[] parameters = new ReportParameter[1];
                parameters[0] = new ReportParameter("ReportParameter1", dia);
                this.reportViewer1.LocalReport.SetParameters(parameters);
                this.reportViewer1.RefreshReport();
                
                reportViewer1.LocalReport.DataSources.Clear(); //clear report
                reportViewer1.LocalReport.ReportEmbeddedResource = "Centro_Estetica.Report1.rdlc"; // bind reportviewer with .rdlc
                Microsoft.Reporting.WinForms.ReportDataSource dataset = new Microsoft.Reporting.WinForms.ReportDataSource("DSInfHono", list); // set the datasource                
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
