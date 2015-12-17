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
    public partial class Registro : Form
    {
        BindingSource bin = new BindingSource();
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            string cmd = "select cliente, comentario, fecha from turnoseliminados order by fecha desc";
            AccesoBD oacc = new AccesoBD();
            DataTable DT = oacc.leerDatos(cmd);            
            bin.DataSource = DT;
            dataGridView1.DataSource = bin;
            dataGridView1.AutoResizeColumn(0, DataGridViewAutoSizeColumnMode.AllCells);
            bin.ResetBindings(true);
        }
    }
}
