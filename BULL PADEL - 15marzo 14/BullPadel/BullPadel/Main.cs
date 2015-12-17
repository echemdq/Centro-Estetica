using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
namespace BullPadel
{
    public partial class Main : Form
    {
        public string usuario;
        DAOUsuarios oDao = new DAOUsuarios();
        AccesoBD oacceso = new AccesoBD();
        //private int ButtonIndex = 1;    
        public Main()
        {
            InitializeComponent();
        }

        private void iniciarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
            usuario = frm.devolver();
        }

        private void aBMProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {          
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.ShowDialog();
            usuario = frm.devolver();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            /*for (int i = 0; i < 5; i++)
            {
                Button tmpButton = new Button();
                string nombre = "MESA" + ButtonIndex++;
                tmpButton.Name = nombre;
                tmpButton.Text = nombre;
                pnlContainer.Controls.Add(tmpButton);
            }*/
            
        }

        private void aBMMesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                ABM_Mesas frm = new ABM_Mesas();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
            
        }

        private void disponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                string cmdtext = "select case when id_fin = '0' then caja else 'error' end as caja, fecha from cajas";
                DataTable dt = new DataTable();
                dt = oacceso.leerDatos(cmdtext);
                string caja = "";
                DateTime fecha;
                foreach (DataRow dr in dt.Rows)
                {
                    caja = Convert.ToString(dr["caja"]);
                    fecha = Convert.ToDateTime(dr["fecha"]);
                    if (caja == "1" || caja == "2")
                    {
                        MesasA frm = new MesasA(caja,fecha);
                        frm.Show();
                        break;
                    }   

                }
                if (caja == "error" || caja == "")
                {
                    MessageBox.Show("No se encuentra ninguna caja abierta");
                }
                
                
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
            
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (usuario != null)
            {
                ConsultaVentas frm = new ConsultaVentas();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void movArticulosEntreFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (usuario != null)
            {
                ConsultaProd frm = new ConsultaProd();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aBMEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void aBMEmpleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                ABM_EMPLEADOS frm = new ABM_EMPLEADOS();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void adSueldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                string cmdtext = "select case when id_fin = '0' then caja else 'error' end as caja, fecha from cajas";
                DataTable dt = new DataTable();
                dt = oacceso.leerDatos(cmdtext);
                string caja = "";
                DateTime fecha;
                foreach (DataRow dr in dt.Rows)
                {
                    caja = Convert.ToString(dr["caja"]);
                    fecha = Convert.ToDateTime(dr["fecha"]);
                    if (caja == "1" || caja == "2")
                    {
                        Sueldos frm = new Sueldos(caja,fecha);
                        frm.ShowDialog();
                        break;
                    }

                }
                if (caja == "error" || caja == "")
                {
                    MessageBox.Show("No se encuentra ninguna caja abierta");
                }
                
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void consultaAdSueldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                ConsultaAdelanto frm = new ConsultaAdelanto();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                string cmdtext = "select case when id_fin = '0' then caja else 'error' end as caja, fecha from cajas";
                DataTable dt = new DataTable();
                dt = oacceso.leerDatos(cmdtext);
                string caja = "";
                DateTime fecha;
                foreach (DataRow dr in dt.Rows)
                {
                    caja = Convert.ToString(dr["caja"]);
                    fecha = Convert.ToDateTime(dr["fecha"]);
                    if (caja == "1" || caja == "2")
                    {
                        Gastos frm = new Gastos(caja,fecha);
                        frm.ShowDialog();
                        break;
                    }

                }
                if (caja == "error" || caja == "")
                {
                    MessageBox.Show("No se encuentra ninguna caja abierta");
                }
                
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void consulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                ConsultaGasto frm = new ConsultaGasto();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void articuloConsumidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                Articulos_Consumidos frm = new Articulos_Consumidos();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                string cmdtext = "select case when id_fin = '0' then caja else 'error' end as caja from cajas";
                DataTable dt = new DataTable();
                dt = oacceso.leerDatos(cmdtext);
                string caja = "";
                foreach (DataRow dr in dt.Rows)
                {
                    caja = Convert.ToString(dr["caja"]);
                    if (caja == "1" || caja == "2")
                    {
                        MessageBox.Show("Ya se encuentra una caja abierta, cierrela y vuelva a intentar");
                        break;
                    }   
                    else
                    {
                        Cajas frm = new Cajas();
                        frm.ShowDialog();
                        break;
                    }

                }
                if (caja == "")
                {
                    Cajas frm = new Cajas();
                    frm.ShowDialog();
                }
                
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                abmproductos frm = new abmproductos();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                string cmdtext = "select case when id_fin = '0' then caja else 'error' end as caja, fecha from cajas";
                DataTable dt = new DataTable();
                dt = oacceso.leerDatos(cmdtext);
                string caja = "";
                DateTime fecha;
                foreach (DataRow dr in dt.Rows)
                {
                    caja = Convert.ToString(dr["caja"]);
                    fecha = Convert.ToDateTime(dr["fecha"]);
                    if (caja == "1" || caja == "2")
                    {
                        MesasA frm = new MesasA(caja, fecha);
                        frm.ShowDialog();
                        break;
                    }

                }
                if (caja == "error" || caja == "")
                {
                    MessageBox.Show("No se encuentra ninguna caja abierta");
                }


            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void mercaderiaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aBMProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (usuario != null)
            {
                abmproductos frm = new abmproductos();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void ingresoMercaderiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                IngresoMercaderia frm = new IngresoMercaderia();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

 

        private void aBMClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                ABM_Clientes frm = new ABM_Clientes();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        

        private void turneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                Turnero frm = new Turnero();
                frm.Show();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void aBMTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                //ABM_Turnos frm = new ABM_Turnos();
                //frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turnero frm = new Turnero();
            frm.ShowDialog();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                Configuracion_Turnero frm = new Configuracion_Turnero();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
            
        }

        private void canchasEntreFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                Canchas frm = new Canchas();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        

        private void stockActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                StockArticulos frm = new StockArticulos();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void registroTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                Registro frm = new Registro();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void movimientosCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                Movimientos_de_Caja frm = new Movimientos_de_Caja();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }

        private void consultasCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                Consulta_Cajas frm = new Consulta_Cajas();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Usuario con Acceso Denegado");
        }


        

    }
}
