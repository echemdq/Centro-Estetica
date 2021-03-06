﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BullPadel
{
    public partial class ABM_EMPLEADOS : Form
    {
        AccesoBD oacceso = new AccesoBD();
        public bool edit = false;
        public ABM_EMPLEADOS()
        {
            InitializeComponent();
        }
        public void limpiar()
        {
            
            textBox2.Clear();
            textBox3.Clear();
            
        }
        public void lectura()
        {
            
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
           
        }
        public void editar()
        {
            edit = true;
            
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            editar();
            textBox2.Visible = true;
            comboBox1.Visible = false;
            textBox2.Focus();
            edit = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmdtext = "";
            string dni = " ";
            if (textBox3.Text == "")
            {
                dni = "SIN DNI";
            }
            else
            {
                dni = textBox3.Text;
            }
            if (edit == true)
            {
                cmdtext = "update empleados set empleado = '" + textBox2.Text + "', dni = '" + dni + "' where idempleados = '" + label1.Text + "'";
            }
            else
            {
                cmdtext = "insert into empleados(empleado, dni) values('" + textBox2.Text + "','" + textBox3.Text + "')";
            }
            oacceso.ActualizarBD(cmdtext);
            limpiar();
            lectura();
            cmdtext = "select upper(empleado) from empleados";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtext);
            comboBox1.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(Convert.ToString(dr["upper(empleado)"]));
            }
            comboBox1.Visible = true;
            textBox2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            textBox2.Focus();
            editar();
        }

        private void ABM_EMPLEADOS_Load(object sender, EventArgs e)
        {
            limpiar();
            lectura();            
            comboBox1.Focus();
            string cmdtext = "select upper(empleado) from empleados";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtext);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(Convert.ToString(dr["upper(empleado)"]));
            }
            textBox2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                DialogResult dre = new DialogResult();
                dre = MessageBox.Show("Seguro", "Eliminar", MessageBoxButtons.YesNo);

                if (dre == DialogResult.Yes)
                {
                    string cmdtext = "delete from empleados where idempleados = '" + label1.Text + "'";
                    oacceso.ActualizarBD(cmdtext);
                    limpiar();
                    comboBox1.Items.Clear();
                    this.Close();
                }

            }
            else
                MessageBox.Show("No hay ningun articulo disponible para eliminar");
        }

        private void ABM_EMPLEADOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string cmdtext = "select dni, idempleados from empleados where empleado = '" + comboBox1.SelectedItem + "'";
                DataTable dt = new DataTable();
                dt = oacceso.leerDatos(cmdtext);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox3.Text = Convert.ToString(dr["dni"]);
                    label1.Text = Convert.ToString(dr["idempleados"]);
                }
            }
        }
    }
}
