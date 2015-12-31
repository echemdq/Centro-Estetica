﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace Centro_Estetica
{
    public partial class frmNuevoTurno : Form
    {
        ControladoraProfesionales controlp = new ControladoraProfesionales();
        ControladoraTurnos controlt = new ControladoraTurnos();
        Profesionales p = null;
        Productos prod = null;
        Pacientes u = null;
        public frmNuevoTurno(string fecha, string hora, string profesional)
        {
            InitializeComponent();
            txtFecha.Text = fecha;
            txtHora.Text = hora;
            txtProfesional.Text = profesional;
            p = controlp.Buscar(profesional);
            lblIdProf.Text = p.Idprofesionales.ToString();
            DateTime dia = Convert.ToDateTime(fecha);
            int diaint = Convert.ToInt32(dia.DayOfWeek);
        }

        private void chkFijo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFijo.Checked)
            {
                rbQuincenal.Enabled = true;
                rbSemanal.Enabled = true;
            }
            else
            {
                rbQuincenal.Enabled = false;
                rbSemanal.Enabled = false;
            }
        }

        private void frmNuevoTurno_Load(object sender, EventArgs e)
        {
            txtFecha_Validated(sender, e);
        }


        private void btnBuscarPac_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaPacientes frm = new frmBuscaPacientes();
                frm.ShowDialog();
                u = frm.u;
                if (u != null)
                {
                    lblIdPac.Text = Convert.ToString(u.Idpacientes);
                    txtPaciente.Text = u.Paciente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFecha_Validated(object sender, EventArgs e)
        {
            try
            {
                if (txtFecha.Text != "  /  /")
                {
                    DateTime a = Convert.ToDateTime(txtFecha.Text);
                    CultureInfo myCI = new CultureInfo("en-US");
                    CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
                    DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;
                    Calendar myCal = myCI.Calendar;
                    if (myCal.GetWeekOfYear(a, myCWR, myFirstDOW) % 2 == 0)
                    {
                        TSemana.Text = "2";
                    }
                    else
                    {
                        TSemana.Text = "1";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string dia = Convert.ToInt32(Convert.ToDateTime(txtFecha.Text).DayOfWeek).ToString();
                string fijo = "";
                string semana = "0";
                if (chkFijo.Checked)
                {
                    if (rbQuincenal.Checked)
                    {
                        fijo = "q";
                        semana = TSemana.Text;
                    }
                    else
                    {
                        fijo = "s";
                    }
                }                
                DateTime fecha = Convert.ToDateTime(txtFecha.Text);
                string detalle = txtDetalle.Text;
                string hora = txtHora.Text;
                string telefono = txtTelefono.Text;
                string idprod = "";
                if (prod != null)
                {
                    idprod = prod.Idproductos.ToString();
                }
                Turnos t = new Turnos(0, p, hora, fecha, lblIdPac.Text, detalle, fijo, semana, dia, telefono, idprod);
                controlt.Agregar(t);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaProductos frm = new frmBuscaProductos();
                frm.ShowDialog();
                prod = frm.u;
                if (prod != null)
                {
                    txtProducto.Text = prod.Detalle;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
