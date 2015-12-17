using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
namespace BullPadel
{
    public partial class ConsultaVentas : Form
    {
        AccesoBD oacceso = new AccesoBD();
        BindingSource bin = new BindingSource();
        public ConsultaVentas()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "  /  /" || maskedTextBox2.Text == "  /  /")
            {
                MessageBox.Show("Ingrese fechas validas");
            }
            else
            {
                if (comboBox1.SelectedItem == null)
                {
                    DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
                    string desde = d.ToString("yyyy-MM-dd HH:mm:ss");
                    DateTime h = Convert.ToDateTime(maskedTextBox2.Text);
                    h = h.AddDays(1);
                    string hasta = h.ToString("yyyy-MM-dd HH:mm:ss");
                    string cmdtext = "select case when sum(total) <> 0 then sum(total) else 0 end as total from ventas where fecha between '" + desde + "' and '" + hasta + "'";
                    DataTable dt = new DataTable();
                    dt = oacceso.leerDatos(cmdtext);
                    decimal ventas = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        ventas = ventas + Convert.ToDecimal(dr["total"]);
                        textBox3.Text = Convert.ToString(dr["total"]);
                    }
                    cmdtext = "select case when sum(importe) <> 0 then sum(importe) else 0 end as adsueldo from sueldo where fecha between '" + desde + "' and '" + hasta + "'";
                    dt = oacceso.leerDatos(cmdtext);
                    decimal sueldo = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        sueldo = Convert.ToDecimal(dr["adsueldo"]);
                        textBox2.Text = Convert.ToString(dr["adsueldo"]);
                    }
                    cmdtext = "select case when sum(importe) <> 0 then sum(importe) else 0 end as gasto from gastos where fecha between '" + desde + "' and '" + hasta + "'";
                    dt = oacceso.leerDatos(cmdtext);
                    decimal gasto = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        gasto = Convert.ToDecimal(dr["gasto"]);
                        textBox1.Text = Convert.ToString(dr["gasto"]);
                    }
                    decimal total = 0;
                    total = ventas - sueldo - gasto;
                    textBox4.Text = total.ToString();
                }
                else
                {
                    if (Convert.ToString(comboBox1.SelectedItem) == "1")
                    {
                        DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
                        string desde = d.ToString("yyyy-MM-dd HH:mm:ss");
                        DateTime h = Convert.ToDateTime(maskedTextBox2.Text);
                        h = h.AddDays(1);
                        string hasta = h.ToString("yyyy-MM-dd HH:mm:ss");
                        string cmdtext = "select case when sum(total) <> 0 then sum(total) else 0 end as total from ventas where fecha between '" + desde + "' and '" + hasta + "' and idcajas = '1'";
                        DataTable dt = new DataTable();
                        dt = oacceso.leerDatos(cmdtext);
                        decimal ventas = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            ventas = ventas + Convert.ToDecimal(dr["total"]);
                            textBox3.Text = Convert.ToString(dr["total"]);
                        }
                        cmdtext = "select case when sum(importe) <> 0 then sum(importe) else 0 end as adsueldo from sueldo where fecha between '" + desde + "' and '" + hasta + "' and caja = '1'";
                        dt = oacceso.leerDatos(cmdtext);
                        decimal sueldo = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            sueldo = Convert.ToDecimal(dr["adsueldo"]);
                            textBox2.Text = Convert.ToString(dr["adsueldo"]);
                        }
                        cmdtext = "select case when sum(importe) <> 0 then sum(importe) else 0 end as gasto from gastos where fecha between '" + desde + "' and '" + hasta + "' and caja = '1'";
                        dt = oacceso.leerDatos(cmdtext);
                        decimal gasto = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            gasto = Convert.ToDecimal(dr["gasto"]);
                            textBox1.Text = Convert.ToString(dr["gasto"]);
                        }
                        decimal total = 0;
                        total = ventas - sueldo - gasto;
                        textBox4.Text = total.ToString();
                    }
                    else
                    {
                        DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
                        string desde = d.ToString("yyyy-MM-dd HH:mm:ss");
                        DateTime h = Convert.ToDateTime(maskedTextBox2.Text);
                        h = h.AddDays(1);
                        string hasta = h.ToString("yyyy-MM-dd HH:mm:ss");
                        string cmdtext = "select case when sum(total) <> 0 then sum(total) else 0 end as total from ventas where fecha between '" + desde + "' and '" + hasta + "' and idcajas = '2'";
                        DataTable dt = new DataTable();
                        dt = oacceso.leerDatos(cmdtext);
                        decimal ventas = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            ventas = ventas + Convert.ToDecimal(dr["total"]);
                            textBox3.Text = Convert.ToString(dr["total"]);
                        }
                        cmdtext = "select case when sum(importe) <> 0 then sum(importe) else 0 end as adsueldo from sueldo where fecha between '" + desde + "' and '" + hasta + "' and caja = '2'";
                        dt = oacceso.leerDatos(cmdtext);
                        decimal sueldo = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            sueldo = Convert.ToDecimal(dr["adsueldo"]);
                            textBox2.Text = Convert.ToString(dr["adsueldo"]);
                        }
                        cmdtext = "select case when sum(importe) <> 0 then sum(importe) else 0 end as gasto from gastos where fecha between '" + desde + "' and '" + hasta + "' and caja = '2'";
                        dt = oacceso.leerDatos(cmdtext);
                        decimal gasto = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            gasto = Convert.ToDecimal(dr["gasto"]);
                            textBox1.Text = Convert.ToString(dr["gasto"]);
                        }
                        decimal total = 0;
                        total = ventas - sueldo - gasto;
                        textBox4.Text = total.ToString();
                    }
                    /*DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
                    string desde = d.ToString("yyyy-MM-dd HH:mm:ss");
                    DateTime h = Convert.ToDateTime(maskedTextBox2.Text);
                    h = h.AddDays(1);
                    string hasta = h.ToString("yyyy-MM-dd HH:mm:ss");
                    string cmdtext = "select case when sum(total) <> 0 then sum(total) else 0 end as total from ventas where fecha between '" + desde + "' and '" + hasta + "'";
                    DataTable dt = new DataTable();
                    dt = oacceso.leerDatos(cmdtext);
                    decimal ventas = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        ventas = ventas + Convert.ToDecimal(dr["total"]);
                        textBox3.Text = Convert.ToString(dr["total"]);
                    }
                    cmdtext = "select case when sum(importe) <> 0 then sum(importe) else 0 end as adsueldo from sueldo where fecha between '" + desde + "' and '" + hasta + "'";
                    dt = oacceso.leerDatos(cmdtext);
                    decimal sueldo = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        sueldo = Convert.ToDecimal(dr["adsueldo"]);
                        textBox2.Text = Convert.ToString(dr["adsueldo"]);
                    }
                    cmdtext = "select case when sum(importe) <> 0 then sum(importe) else 0 end as gasto from gastos where fecha between '" + desde + "' and '" + hasta + "'";
                    dt = oacceso.leerDatos(cmdtext);
                    decimal gasto = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        gasto = Convert.ToDecimal(dr["gasto"]);
                        textBox1.Text = Convert.ToString(dr["gasto"]);
                    }
                    decimal total = 0;
                    total = ventas - sueldo - gasto;
                    textBox4.Text = total.ToString();*/ 
                }
            }
        }


        private void ConsultaVentas_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.Date.ToShortDateString();
            maskedTextBox2.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click_1(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            
            
            DateTime fecha = DateTime.Now;
            string fe = "ventas"+fecha.ToString("ddMMyyyy HHmmss")+".pdf";
            
            PdfWriter.GetInstance(document, new FileStream(fe, FileMode.OpenOrCreate));
            document.Open();
            document.Add(new Paragraph("                   "));
            Chunk chunk = new Chunk("     Bull Padel Cafe", FontFactory.GetFont("VERDANA", 50, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.DARK_GRAY));
            document.Add(new Paragraph(chunk));
            document.Add(new Paragraph("                   "));
            document.Add(new Paragraph("                   "));
            chunk = new Chunk("Ventas                                                Desde: " + maskedTextBox1.Text + "        Hasta: " + maskedTextBox2.Text + "        Caja: " + comboBox1.SelectedItem + "", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.UNDERLINE));            
            document.Add(new Paragraph(chunk));
            document.Add(new Paragraph("                   "));
            document.Add(new Paragraph("                   "));            
            chunk = new Chunk("VENTAS:  " +textBox3.Text, FontFactory.GetFont("VERDANA", 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            document.Add(new Paragraph(chunk));
            chunk = new Chunk("GASTOS:  " + textBox1.Text, FontFactory.GetFont("VERDANA", 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            document.Add(new Paragraph(chunk));
            chunk = new Chunk("ADELANTO SUELDOS:  " + textBox2.Text, FontFactory.GetFont("VERDANA", 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            document.Add(new Paragraph(chunk));
            document.Add(new Paragraph("                   "));
            document.Add(new Paragraph("                   "));
            
            document.Add(new Paragraph("___________________________________________________________________________"));
            document.Add(new Paragraph("                   "));
            document.Add(new Paragraph("                   "));
            chunk = new Chunk("                     TOTAL FINAL:  " + textBox4.Text, FontFactory.GetFont("VERDANA", 20, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.BLACK));
            document.Add(new Paragraph(chunk));
            /*iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(@"C:\Users\Ezequiel\Desktop\Nueva carpeta\BULL PADEL - 1 ENERO\BullPadel\BullPadel\Resources\CAFE BULL PADEL LOGO (1).jpg");
            jpg.Alignment = iTextSharp.text.Image.ALIGN_TOP;
            document.Add(jpg);*/
            document.Close();
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            string pdfPath = Path.Combine(Application.StartupPath, fe);
            proc.StartInfo.FileName = pdfPath;
            proc.Start();
        }
    }
}
