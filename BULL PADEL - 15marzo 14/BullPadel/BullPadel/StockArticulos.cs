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
    public partial class StockArticulos : Form
    {
        AccesoBD oacceso = new AccesoBD();
        public StockArticulos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Document document = new Document();


            DateTime fecha = DateTime.Now;
            string fe = "ventas" + fecha.ToString("ddMMyyyy HHmmss") + ".pdf";

            PdfWriter.GetInstance(document, new FileStream(fe, FileMode.OpenOrCreate));
            document.Open();
            document.Add(new Paragraph("                   "));
            Chunk chunk = new Chunk("     Bull Padel Cafe", FontFactory.GetFont("VERDANA", 50, iTextSharp.text.Font.BOLD, iTextSharp.text.BaseColor.DARK_GRAY));
            document.Add(new Paragraph(chunk));
            document.Add(new Paragraph("                   "));
            document.Add(new Paragraph("                   "));
            chunk = new Chunk("Stock Articulos                                                Fecha: " + DateTime.Now + "", FontFactory.GetFont("ARIAL", 12, iTextSharp.text.Font.BOLD));
            document.Add(new Paragraph(chunk));
            document.Add(new Paragraph("                   "));
            document.Add(new Paragraph("                   "));
            string cmdtext = "select idarticulos,lower(descripcion) as descripcion,stock from articulos order by descripcion";
            DataTable dt = oacceso.leerDatos(cmdtext);
            PdfPTable table = new PdfPTable(5);
            iTextSharp.text.Font fontH1 = new iTextSharp.text.Font(FontFactory.GetFont("ARIAL", 9, iTextSharp.text.Font.BOLD));
            iTextSharp.text.Font fontH2 = new iTextSharp.text.Font(FontFactory.GetFont("ARIAL", 10, iTextSharp.text.Font.NORMAL));
            PdfPCell cell = new PdfPCell(new Phrase("Stock Articulos"));

            cell.Colspan = 5;
            cell.HorizontalAlignment = 1; //0=Left, 1=Centre, 2=Right 
            table.AddCell(cell);            
            table.AddCell(new PdfPCell(new Phrase("Codigo", fontH1)));
            table.AddCell(new PdfPCell(new Phrase("Descripcion", fontH1)));
            table.AddCell(new PdfPCell(new Phrase("Stock", fontH1)));
            table.AddCell(new PdfPCell(new Phrase("Stock Fisico", fontH1)));
            table.AddCell(new PdfPCell(new Phrase("Diferencia", fontH1)));
            float[] widths = new float[] { 0.5f, 2f, 0.5f, 0.5f, 0.5f };
            table.SetWidths(widths);
            foreach (DataRow dr in dt.Rows)
            {
                table.AddCell(new PdfPCell(new Phrase(Convert.ToString(dr["idarticulos"]), fontH2)));
                table.AddCell(new PdfPCell(new Phrase(Convert.ToString(dr["descripcion"]), fontH2)));
                table.AddCell(new PdfPCell(new Phrase(Convert.ToString(dr["stock"]), fontH2)));
                table.AddCell(new PdfPCell(new Phrase(" ", fontH2)));
                table.AddCell(new PdfPCell(new Phrase(" ", fontH2)));
            }
            document.Add(table);
            document.Close();
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            string pdfPath = Path.Combine(Application.StartupPath, fe);
            proc.StartInfo.FileName = pdfPath;
            proc.Start();
            this.Close();
        }
    }
}