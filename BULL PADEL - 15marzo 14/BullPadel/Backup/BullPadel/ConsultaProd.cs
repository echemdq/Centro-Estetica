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
    public partial class ConsultaProd : Form
    {
        Productos aux;
        BindingSource bin = new BindingSource();
        AccesoBD oacceso = new AccesoBD();
        public ConsultaProd()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarproducto FRM = new buscarproducto();
            FRM.ShowDialog();
            aux = FRM.devolver();
            if (aux != null)
            {
                textBox3.Text = aux.Id.ToString();               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            if (maskedTextBox1.Text == "  /  /" || maskedTextBox2.Text == "  /  /")
            {
                MessageBox.Show("Ingrese fechas validas");
            }
            else
            {
                if (comboBox1.SelectedItem == null)
                {
                    string cod = textBox3.Text;
                    DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
                    string desde = d.ToString("yyyy-MM-dd HH:mm:ss");
                    DateTime h = Convert.ToDateTime(maskedTextBox2.Text);
                    h = h.AddDays(1);
                    string hasta = h.ToString("yyyy-MM-dd HH:mm:ss");
                    if (cod == "")
                    {
                        string cmdtext = "call bullpadelbd.ventasprodtotal('" + 0 + "','" + desde + "','" + hasta + "')";
                        dt = oacceso.leerDatos(cmdtext);
                        bin.DataSource = dt;
                        dataGridView1.DataSource = bin;
                        bin.ResetBindings(true);
                    }
                    else
                    {
                        string cmdtext = "call bullpadelbd.ventasprodtotal('" + cod + "','" + desde + "','" + hasta + "')";
                        dt = oacceso.leerDatos(cmdtext);
                        bin.DataSource = dt;
                        dataGridView1.DataSource = bin;
                        bin.ResetBindings(true);
                    }
                }
                else
                {
                    if (Convert.ToString(comboBox1.SelectedItem) == "1")
                    {
                        string cod = textBox3.Text;
                        DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
                        string desde = d.ToString("yyyy-MM-dd HH:mm:ss");
                        DateTime h = Convert.ToDateTime(maskedTextBox2.Text);
                        h = h.AddDays(1);
                        string hasta = h.ToString("yyyy-MM-dd HH:mm:ss");
                        if (cod == "")
                        {
                            string cmdtext = "call bullpadelbd.ventasprod('" + 0 + "','" + desde + "','" + hasta + "','1')";
                            dt = oacceso.leerDatos(cmdtext);
                            bin.DataSource = dt;
                            dataGridView1.DataSource = bin;
                            bin.ResetBindings(true);
                        }
                        else
                        {
                            string cmdtext = "call bullpadelbd.ventasprod('" + cod + "','" + desde + "','" + hasta + "','1')";
                            dt = oacceso.leerDatos(cmdtext);
                            bin.DataSource = dt;
                            dataGridView1.DataSource = bin;
                            bin.ResetBindings(true);
                        }
                    }
                    else
                    {
                        string cod = textBox3.Text;
                        DateTime d = Convert.ToDateTime(maskedTextBox1.Text);
                        string desde = d.ToString("yyyy-MM-dd HH:mm:ss");
                        DateTime h = Convert.ToDateTime(maskedTextBox2.Text);
                        h = h.AddDays(1);
                        string hasta = h.ToString("yyyy-MM-dd HH:mm:ss");
                        if (cod == "")
                        {
                            string cmdtext = "call bullpadelbd.ventasprod('" + 0 + "','" + desde + "','" + hasta + "','2')";
                            dt = oacceso.leerDatos(cmdtext);
                            bin.DataSource = dt;
                            dataGridView1.DataSource = bin;
                            bin.ResetBindings(true);
                        }
                        else
                        {
                            string cmdtext = "call bullpadelbd.ventasprod('" + cod + "','" + desde + "','" + hasta + "','2')";
                            dt = oacceso.leerDatos(cmdtext);
                            bin.DataSource = dt;
                            dataGridView1.DataSource = bin;
                            bin.ResetBindings(true);
                        }
                    }
                }
            }

        }

        private void ConsultaProd_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.Date.ToShortDateString();
            maskedTextBox2.Text = DateTime.Now.Date.ToShortDateString();
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
