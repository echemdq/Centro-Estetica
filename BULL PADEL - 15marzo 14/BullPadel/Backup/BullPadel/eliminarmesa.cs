using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BullPadel
{
    public partial class eliminarmesa : Form
    {
        public eliminarmesa()
        {
            InitializeComponent();
        }
        BindingSource bin = new BindingSource();
        DAOmesas odao = new DAOmesas();
        private void button1_Click(object sender, EventArgs e)
        {
            Mesas omesa = dataGridView1.CurrentRow.DataBoundItem as Mesas;
            if (omesa != null)
            {
                DialogResult dr = new DialogResult();
                dr = MessageBox.Show("Seguro", "Eliminar", MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    odao.eliminar(omesa);
                    bin.ResetBindings(true);
                    this.Close();
                }
            }
            else
                MessageBox.Show("No hay ninguna mesa seleccionada para eliminar");
        }

        private void eliminarmesa_Load(object sender, EventArgs e)
        {
            List<Mesas> laux = new List<Mesas>();
            laux = odao.devolver();
            bin.DataSource = laux;
            dataGridView1.DataSource = bin;
            dataGridView1.Columns[1].Visible = false;
            bin.ResetBindings(true);
        }
    }
}
