using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Centro_Estetica
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void rubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRubros frm = new frmRubros();
            frm.ShowDialog(); 
        }

        private void subrubrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubrubros frm = new frmSubrubros();
            frm.ShowDialog(); 
        }

        private void aBMPacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacientes frm = new frmPacientes();
            frm.ShowDialog(); 
        }
    }
}
