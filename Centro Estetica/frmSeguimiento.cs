using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Estetica
{
    public partial class frmSeguimiento : Form
    {
        List<Seguimientos> laux = new List<Seguimientos>();
        public frmSeguimiento(List<Seguimientos> lista, Profesionales p, string hora, string fecha)
        {
            InitializeComponent();
            laux = lista;
            label1.Text = "Seguimiento del dia: " + fecha + " a las: " + hora + "hs del Profesional: " + p.Profesional;
        }

        private void frmSeguimiento_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Fecha";
            dataGridView1.Columns[1].Name = "Detalle";
            int x = 0;
            dataGridView1.Rows.Add(laux.Count-1);
            foreach (Seguimientos aux in laux)
            {
                dataGridView1.Rows[x].Cells[0].Value = aux.Fechareal.ToString("dd-MM-yyyy HH:mm:ss");
                dataGridView1.Rows[x].Cells[1].Value = aux.Detalle;
                x++;                
            }
        }
    }
}
