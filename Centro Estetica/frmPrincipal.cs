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

        private void aBMProfesionalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfesionales frm = new frmProfesionales();
            frm.ShowDialog();
        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTurnero frm = new frmTurnero();
            frm.Show();
        }

        private void aBMProducotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos frm = new frmProductos();
            frm.Show();
        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactura frm = new frmFactura();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void configHonorariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInformeHonorariosDiarios frm = new frmInformeHonorariosDiarios();
            frm.ShowDialog();
        }

        private void ingresosEgresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovCaja frm = new frmMovCaja();
            frm.ShowDialog();
        }

        private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInfCajas frm = new frmInfCajas();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRecibos frm = new frmRecibos();
            frm.ShowDialog();
        }

        private void consultaCtaCteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCtaCte frm = new frmCtaCte();
            frm.ShowDialog();
        }


    }
}
