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
    public partial class ConsultaAdelanto : Form
    {
        AccesoBD oacceso = new AccesoBD();
        BindingSource bin = new BindingSource();
        public ConsultaAdelanto()
        {
            InitializeComponent();
        }

        private void ConsultaAdelanto_Load(object sender, EventArgs e)
        {
            string cmdtext = "select upper(empleado) from empleados";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtext);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(Convert.ToString(dr["upper(empleado)"]));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmdtext = "select fecha as FECHA, importe as IMPORTE, descripcion as 'CORRESPONDIENTE A' from sueldo s inner join empleados e on s.idempleados = e.idempleados where e.empleado = '" + comboBox1.SelectedItem + "' order by fecha desc";
            DataTable dt = new DataTable();
            dt = oacceso.leerDatos(cmdtext);
            bin.DataSource = dt;
            dataGridView1.DataSource = bin;
            //dataGridView1.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells);
            bin.ResetBindings(true);
        }
    }
}
