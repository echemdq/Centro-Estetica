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
    public partial class buscarcliente : Form
    {
        AccesoBD oAcceso = new AccesoBD();
        BindingSource bin = new BindingSource();
        static string descripcion;
        static string telefono;
        static string dni;
        static decimal saldo;
        static int id;
        static bool estado;
        public buscarcliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string d1 = "";
            string d2 = "";
            string d3 = textBox2.Text.Trim();
            int cant = 1;

            bool a = true;
            while (a == true)
            {
                int f = d3.LastIndexOf(" ");
                if (f == -1 && d3.Length != 0)
                {
                    d1 = d3.Trim();
                    d3 = "";
                    if (cant == 1)
                    {
                        d2 += " like '%" + d1 + "%' ";
                    }
                    else
                    {
                        d2 += " and descripcion like '%" + d1 + "%' ";
                    }
                    a = false;
                }
                else
                {
                    int c = d3.LastIndexOf(" ");

                    if (c != -1)
                    {
                        int d = d3.LastIndexOf(" ");
                        d1 = d3.Substring(d, d3.Length - d);
                        d1 = d1.Trim();
                        d = d3.LastIndexOf(" ");
                        d3 = d3.Substring(0, d);
                        if (cant == 1)
                        {
                            d2 += " like '%" + d1 + "%' ";
                        }
                        else
                        {
                            d2 += " and descripcion like '%" + d1 + "%' ";

                        }
                    }
                    else
                    {
                        a = false;
                    }
                }
                cant++;
            }
            string cmdText = "select * from clientes where descripcion " + d2 + "order by descripcion";
            DataTable DT = new DataTable();
            DT = oAcceso.leerDatos(cmdText);
            bin.DataSource = DT;
            dataGridView1.DataSource = bin;
            dataGridView1.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells);
            bin.ResetBindings(true);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            int filaseleccionada = Convert.ToInt32(this.dataGridView1.CurrentRow.Index);
            id = Convert.ToInt32(dataGridView1[0, filaseleccionada].Value.ToString());
            descripcion = Convert.ToString(dataGridView1[1, filaseleccionada].Value.ToString());
            dni = Convert.ToString(dataGridView1[2, filaseleccionada].Value.ToString());
            telefono = Convert.ToString(dataGridView1[3, filaseleccionada].Value.ToString());
            saldo = Convert.ToDecimal(dataGridView1[4, filaseleccionada].Value.ToString());
            estado = false;
            this.Close();
        }
        public string desc()
        {
            return descripcion;
        }
        public string dn()
        {
            return dni;
        }
        public string tel()
        {
            return telefono;
        }
        public decimal sald()
        {
            return saldo;
        }
        public int Id()
        {
            return id;
        }
        public bool est()
        {
            return estado;
        }
        private void buscarcliente_Load(object sender, EventArgs e)
        {
            estado = true;
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
