using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centro_Estetica
{
    public partial class frmInformeHonorariosDiarios : Form
    {
        Profesionales profesionales = null;
        List<InfHonorarios> lista = new List<InfHonorarios>();
        DateTime dia = DateTime.Now;
        decimal total = 0;
        public frmInformeHonorariosDiarios()
        {
            InitializeComponent();
        }

        private void frmInformeHonorariosDiarios_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            mskHasta.Text = DateTime.Now.ToString("dd-MM-yyyy");
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Profesional";
            dataGridView1.Columns[1].Name = "Cliente";
            dataGridView1.Columns[2].Name = "Servicio";
            dataGridView1.Columns[3].Name = "Sesiones";
            dataGridView1.Columns[4].Name = "Precio Venta";
            dataGridView1.Columns[5].Name = "% Honorario";
            dataGridView1.Columns[6].Name = "Honorario Profesional";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaProfesionales frm = new frmBuscaProfesionales();
                frm.ShowDialog();
                profesionales = frm.u;
                if (profesionales != null)
                {
                    txtProfesional.Text = profesionales.Profesional;
                }
                dataGridView1.Rows.Clear();
                lista.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Acceso_BD oacceso = new Acceso_BD();
            if (profesionales == null)
            {
                dia = Convert.ToDateTime(txtFecha.Text);
                DateTime hasta = Convert.ToDateTime(mskHasta.Text);
                DataTable dt = oacceso.leerDatos("select p.profesional, pa.paciente, s.detalle, lf.sesiones, lf.precioventa, ifnull((select preciocalculo from honorarios where idprofesionales=st.idprofesionales and idproductos=lf.idproductos), lf.preciocalculo) as prueba, round(lf.precioventa * ifnull((select preciocalculo from honorarios where idprofesionales=st.idprofesionales and idproductos=lf.idproductos), lf.preciocalculo) / 100 / lf.sesiones,2) as pagoprofesional from serviciosturnos st left join servicios s on st.idservicios = s.idservicios left join lineafactura lf on s.idlineafactura = lf.idlineafactura left join profesionales p on st.idprofesionales = p.idprofesionales left join pacientes pa on st.idpacientes = pa.idpacientes where st.fecha between '" + dia.ToString("yyyy-MM-dd") + "' and '" + hasta.ToString("yyyy-MM-dd") + "' and asistencia = 1  union select p.profesional, pa.paciente, concat('CURSO ', s.detalle) as detalle, lf.sesiones, lf.precioventa, ifnull((select preciocalculo from honorarios where idprofesionales=c.idprofesionales and idproductos=lf.idproductos), lf.preciocalculo) as prueba, round(lf.precioventa * ifnull((select preciocalculo from honorarios where idprofesionales=c.idprofesionales and idproductos=lf.idproductos), lf.preciocalculo) / 100 / lf.sesiones,2) as pagoprofesional from cursos c left join servicios s on c.idservicios = s.idservicios left join lineafactura lf on s.idlineafactura = lf.idlineafactura left join profesionales p on c.idprofesionales = p.idprofesionales left join pacientes pa on c.idpacientes = pa.idpacientes where c.fecha between '" + dia.ToString("yyyy-MM-dd") + "' and '" + hasta.ToString("yyyy-MM-dd") + "' and c.asistencia = 1 order by profesional asc");
                int x = 0;
                
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    
                    lista = new List<InfHonorarios>();
                    string profesional = "";
                    decimal total = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataGridView1.Rows.Add(1);
                        
                        if (profesional == "" || profesional.Equals(Convert.ToString(dr["profesional"])))
                        {
                            profesional = Convert.ToString(dr["profesional"]);
                            dataGridView1.Rows[x].Cells[0].Value = Convert.ToString(dr["profesional"]);
                            dataGridView1.Rows[x].Cells[1].Value = Convert.ToString(dr["paciente"]);
                            dataGridView1.Rows[x].Cells[2].Value = Convert.ToString(dr["detalle"]);
                            dataGridView1.Rows[x].Cells[3].Value = Convert.ToString(dr["sesiones"]);
                            dataGridView1.Rows[x].Cells[4].Value = Convert.ToString(dr["precioventa"]);
                            dataGridView1.Rows[x].Cells[5].Value = Convert.ToString(dr["prueba"]);
                            dataGridView1.Rows[x].Cells[6].Value = Convert.ToString(dr["pagoprofesional"]);
                            total = total + Convert.ToDecimal(dr["pagoprofesional"]);
                            InfHonorarios inf = new InfHonorarios(Convert.ToString(dr["profesional"]), Convert.ToString(dr["paciente"]), Convert.ToString(dr["detalle"]), Convert.ToString(dr["sesiones"]), Convert.ToString(dr["precioventa"]), Convert.ToString(dr["prueba"]), Convert.ToDecimal(dr["pagoprofesional"]));
                            lista.Add(inf);
                            x++;
                        }
                        else
                        {
                            dataGridView1.Rows[x].Cells[0].Value = "SUBTOTAL PROF:";                            
                            dataGridView1.Rows[x].Cells[6].Value = total;
                            dataGridView1.Rows.Add(1);
                            x++;
                            total = 0;
                            profesional = Convert.ToString(dr["profesional"]);
                            dataGridView1.Rows[x].Cells[0].Value = Convert.ToString(dr["profesional"]);
                            dataGridView1.Rows[x].Cells[1].Value = Convert.ToString(dr["paciente"]);
                            dataGridView1.Rows[x].Cells[2].Value = Convert.ToString(dr["detalle"]);
                            dataGridView1.Rows[x].Cells[3].Value = Convert.ToString(dr["sesiones"]);
                            dataGridView1.Rows[x].Cells[4].Value = Convert.ToString(dr["precioventa"]);
                            dataGridView1.Rows[x].Cells[5].Value = Convert.ToString(dr["prueba"]);
                            dataGridView1.Rows[x].Cells[6].Value = Convert.ToString(dr["pagoprofesional"]);
                            total = total + Convert.ToDecimal(dr["pagoprofesional"]);
                            InfHonorarios inf = new InfHonorarios(Convert.ToString(dr["profesional"]), Convert.ToString(dr["paciente"]), Convert.ToString(dr["detalle"]), Convert.ToString(dr["sesiones"]), Convert.ToString(dr["precioventa"]), Convert.ToString(dr["prueba"]), Convert.ToDecimal(dr["pagoprofesional"]));
                            lista.Add(inf);
                            x++;
                        }
                        
                    }
                    if (x != 0)
                    {
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[x].Cells[0].Value = "SUBTOTAL PROF:";
                        dataGridView1.Rows[x].Cells[6].Value = total;
                    }
                    
                }
            }
            else
            {
                dia = Convert.ToDateTime(txtFecha.Text);
                DataTable dt = oacceso.leerDatos("select p.profesional, pa.paciente, s.detalle, lf.sesiones, lf.precioventa, ifnull((select preciocalculo from honorarios where idprofesionales=st.idprofesionales and idproductos=lf.idproductos), lf.preciocalculo) as prueba, round(lf.precioventa * ifnull((select preciocalculo from honorarios where idprofesionales=st.idprofesionales and idproductos=lf.idproductos), lf.preciocalculo) / 100 / lf.sesiones,2) as pagoprofesional from serviciosturnos st left join servicios s on st.idservicios = s.idservicios left join lineafactura lf on s.idlineafactura = lf.idlineafactura left join profesionales p on st.idprofesionales = p.idprofesionales left join pacientes pa on st.idpacientes = pa.idpacientes where st.fecha = '" + dia.ToString("yyyy-MM-dd") + "' and asistencia = 1 and st.idprofesionales = '" + profesionales.Idprofesionales + "' union select p.profesional, pa.paciente, concat('CURSO ',s.detalle) as detalle, lf.sesiones, lf.precioventa, ifnull((select preciocalculo from honorarios where idprofesionales=c.idprofesionales and idproductos=lf.idproductos), lf.preciocalculo)  as prueba, round(lf.precioventa * ifnull((select preciocalculo from honorarios where idprofesionales=c.idprofesionales and idproductos=lf.idproductos), lf.preciocalculo) / 100 / lf.sesiones,2)  as pagoprofesional from cursos c left join servicios s on c.idservicios = s.idservicios  left join lineafactura lf on s.idlineafactura = lf.idlineafactura left join profesionales p on  c.idprofesionales = p.idprofesionales left join pacientes pa on c.idpacientes = pa.idpacientes where c.fecha = '2016-03-07' and asistencia = 1 and c.idprofesionales = '" + profesionales.Idprofesionales + "' order by profesional asc");
                int x = 0;
                if (dt.Rows.Count > 0)
                {
                    dataGridView1.Rows.Clear();
                    lista = new List<InfHonorarios>();
                    string profesional = "";
                    total = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        dataGridView1.Rows.Add(1);

                        if (profesional == "" || profesional.Equals(Convert.ToString(dr["profesional"])))
                        {
                            profesional = Convert.ToString(dr["profesional"]);
                            dataGridView1.Rows[x].Cells[0].Value = Convert.ToString(dr["profesional"]);
                            dataGridView1.Rows[x].Cells[1].Value = Convert.ToString(dr["paciente"]);
                            dataGridView1.Rows[x].Cells[2].Value = Convert.ToString(dr["detalle"]);
                            dataGridView1.Rows[x].Cells[3].Value = Convert.ToString(dr["sesiones"]);
                            dataGridView1.Rows[x].Cells[4].Value = Convert.ToString(dr["precioventa"]);
                            dataGridView1.Rows[x].Cells[5].Value = Convert.ToString(dr["prueba"]);
                            dataGridView1.Rows[x].Cells[6].Value = Convert.ToString(dr["pagoprofesional"]);
                            total = total + Convert.ToDecimal(dr["pagoprofesional"]);
                            InfHonorarios inf = new InfHonorarios(Convert.ToString(dr["profesional"]), Convert.ToString(dr["paciente"]), Convert.ToString(dr["detalle"]), Convert.ToString(dr["sesiones"]), Convert.ToString(dr["precioventa"]), Convert.ToString(dr["prueba"]), Convert.ToDecimal(dr["pagoprofesional"]));
                            lista.Add(inf);
                            x++;
                        }
                        else
                        {
                            dataGridView1.Rows[x].Cells[0].Value = "SUBTOTAL PROF:";
                            dataGridView1.Rows[x].Cells[6].Value = total;
                            dataGridView1.Rows.Add(1);
                            x++;
                            total = 0;
                            profesional = Convert.ToString(dr["profesional"]);
                            dataGridView1.Rows[x].Cells[0].Value = Convert.ToString(dr["profesional"]);
                            dataGridView1.Rows[x].Cells[1].Value = Convert.ToString(dr["paciente"]);
                            dataGridView1.Rows[x].Cells[2].Value = Convert.ToString(dr["detalle"]);
                            dataGridView1.Rows[x].Cells[3].Value = Convert.ToString(dr["sesiones"]);
                            dataGridView1.Rows[x].Cells[4].Value = Convert.ToString(dr["precioventa"]);
                            dataGridView1.Rows[x].Cells[5].Value = Convert.ToString(dr["prueba"]);
                            dataGridView1.Rows[x].Cells[6].Value = Convert.ToString(dr["pagoprofesional"]);
                            total = total + Convert.ToDecimal(dr["pagoprofesional"]);
                            InfHonorarios inf = new InfHonorarios(Convert.ToString(dr["profesional"]), Convert.ToString(dr["paciente"]), Convert.ToString(dr["detalle"]), Convert.ToString(dr["sesiones"]), Convert.ToString(dr["precioventa"]), Convert.ToString(dr["prueba"]), Convert.ToDecimal(dr["pagoprofesional"]));
                            lista.Add(inf);
                            x++;
                        }

                    }
                    if (x != 0)
                    {
                        dataGridView1.Rows.Add(1);
                        dataGridView1.Rows[x].Cells[0].Value = "SUBTOTAL PROF:";
                        dataGridView1.Rows[x].Cells[6].Value = total;
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReport frm = new frmReport(lista, dia.ToString("dd-MM-yyyy"));
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lista.Count > 0 && profesionales != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Esta seguro de Liquidar Honorarios Diarios del Profesional: " + profesionales.Profesional, "Liquidacion Honorarios", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Acceso_BD oacceso = new Acceso_BD();
                        decimal total = 0;
                        foreach (InfHonorarios aux in lista)
                        {
                            total = total + aux.Pagoprofesional;
                        }
                        DataTable dt = oacceso.leerDatos("select ifnull(idliquidaciondiaria,0) as liqui from liquidaciondiaria where idprofesionales = '" + profesionales.Idprofesionales + "' and fecha = '" + dia.ToString("yyyy-MM-dd") + "'");
                        int idliquidaciondiaria = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            idliquidaciondiaria = Convert.ToInt32(dr["liqui"]);
                        }
                        if (idliquidaciondiaria == 0)
                        {
                            oacceso.ActualizarBD("insert into liquidaciondiaria (idprofesionales, fecha, importe) values ('" + profesionales.Idprofesionales + "','" + dia.ToString("yyyy-MM-dd") + "','" + total.ToString().Replace(',', '.') + "')");
                            MessageBox.Show("Liquidacion guardado correctamente");
                        }
                        else
                        {
                            oacceso.ActualizarBD("update liquidaciondiaria set importe = '" + total.ToString().Replace(',', '.') + "'");
                            MessageBox.Show("Liquidacion actualizada correctamente");
                        }                        
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un profesional y recuperar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            lista.Clear();
            dataGridView1.Rows.Clear();
        }

        private void mskHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            lista.Clear();
            dataGridView1.Rows.Clear();
        }
    }
}
