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
    public partial class buscarproducto : Form
    {
        Productos p;
        BindingSource bin = new BindingSource();
        DaoProductos odao = new DaoProductos();
        AccesoBD oacceso = new AccesoBD();
        public buscarproducto()
        {
            InitializeComponent();
        }
        public Productos devolver()
        {
            return p;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            p = dataGridView1.CurrentRow.DataBoundItem as Productos;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            List<Productos> laux = new List<Productos>();
            laux = odao.buscar(textBox2.Text);             
            bin.DataSource = laux;
            dataGridView1.DataSource = bin;
            dataGridView1.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells);
            bin.ResetBindings(true);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }

        private void buscarproducto_Load(object sender, EventArgs e)
        {

        }



    }
}
