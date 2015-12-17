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
    public partial class ABM_Mesas : Form
    {
       // int max = 0;
        DAOmesas odao = new DAOmesas();
        public ABM_Mesas()
        {
            InitializeComponent();
        }

        private void ABM_Mesas_Load(object sender, EventArgs e)
        {
                    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            eliminarmesa frm = new eliminarmesa();
            frm.ShowDialog();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Agregar " + textBox1.Text + " Mesas ?", "ABM MESAS", MessageBoxButtons.YesNo);
            
            if (dr == DialogResult.Yes)
            {
                int cant = 0;
                if (textBox1.Text != "")
                {
                    
                    cant = Convert.ToInt32(textBox1.Text);
                    odao.update("mesa", cant);


                    MessageBox.Show("Actualmente posee: " + cant + " Mesas");
                }
                else
                    MessageBox.Show("Ingrese una cantidad Valida");

               
                    
                  
                textBox1.Clear();
                
            }
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Agregar " + textBox2.Text + " Canchas de Padel?", "ABM MESAS", MessageBoxButtons.YesNo);
            
            if (dr == DialogResult.Yes)
            {
                int cant = 0;
                if (textBox2.Text != "")
                {
                    
                    cant = Convert.ToInt32(textBox2.Text);
                    odao.update("padel", cant);
                    MessageBox.Show("Actualmente posee: " + cant + " Canchas de Padel");
                }
                else
                    MessageBox.Show("Ingrese una cantidad Valida");
                
                
               
                textBox2.Clear();
                
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button3_Click(sender, e);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }
    }
}
