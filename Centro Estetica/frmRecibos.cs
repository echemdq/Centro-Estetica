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
    public partial class frmRecibos : Form
    {
        ControladoraCtaCte c = new ControladoraCtaCte();
        public frmRecibos()
        {
            InitializeComponent();
        }

        private void frmRecibos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.BuscarEspecial("1");
            dataGridView1.Columns[1].ReadOnly = true;
        }
    }
}
