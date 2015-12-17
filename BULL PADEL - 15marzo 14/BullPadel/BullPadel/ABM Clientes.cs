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
    public partial class ABM_Clientes : Form
    {
        AccesoBD oacceso = new AccesoBD();
        public ABM_Clientes()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buscarcliente frm = new buscarcliente();
            frm.ShowDialog();
            bool estado = frm.est();
            string descripcion = frm.desc();
            string dni = frm.dn();
            string telefono = frm.tel();
            decimal saldo = frm.sald();
            int id = frm.Id();
            if (descripcion != "" && estado == false)
            {
                textBox1.Text = telefono;
                textBox2.Text = descripcion;
                textBox3.Text = dni;
                textBox4.Text = saldo.ToString();
                label5.Text = id.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Text = "0.00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label5.Text != "")
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox5.ReadOnly = false;
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                textBox3.BackColor = Color.White;
                textBox5.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("No hay ningun cliente para editar");
            }
            //textBox4.ReadOnly = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label5.Text == "")
            {
                string cmdtext = "insert into clientes(descripcion, telefono, dni, saldo, celular) values('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + textBox4.Text.Replace(',','.') + "','"+textBox5.Text+"')";
                oacceso.ActualizarBD(cmdtext);
                this.Close();
                MessageBox.Show("Cliente guardado exitosamente");
            }
            else
            {
                string cmdtext = "update clientes set descripcion = '" + textBox2.Text + "', telefono = '" + textBox1.Text + "', dni = '" + textBox3.Text + "', saldo = '" + textBox4.Text.Replace(',', '.') + "', celular = '" + textBox5.Text + "' where idclientes = '" + label5.Text + "'";
                oacceso.ActualizarBD(cmdtext);
                this.Close();
                MessageBox.Show("Cliente guardado exitosamente");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label5.Text != "")
            {
                string cmdtext = "delete from clientes where idclientes = '" + label5.Text + "'";
                oacceso.ActualizarBD(cmdtext);
                this.Close();
                MessageBox.Show("Cliente borrado exitosamente");
            }
        }


    }
}
