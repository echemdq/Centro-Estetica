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
    public partial class frmHistorialCliente : Form
    {
        Pacientes pac = null;
        public frmHistorialCliente()
        {
            InitializeComponent();
        }

        private void frmHistorialCliente_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Fecha";
            dataGridView1.Columns[1].Name = "Profesional";
            dataGridView1.Columns[2].Name = "Servicio";
            dataGridView1.Columns[3].Name = "Regalo de";
            frmBuscaPacientes frm = new frmBuscaPacientes();
            frm.ShowDialog();
            pac = frm.u;
            if (pac != null)
            {
                txtPaciente.Text = pac.Paciente;
            }
            else
            {
                this.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscaPacientes frm = new frmBuscaPacientes();
            frm.ShowDialog();
            pac = frm.u;
            if (pac != null)
            {
                txtPaciente.Text = pac.Paciente;
            }
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            try
            {
                if (pac != null)
                {
                    if (rbAsistidos.Checked)
                    {
                        Acceso_BD oacceso = new Acceso_BD();
                        DataTable dt = oacceso.leerDatos("select p.profesional,st.fecha,st.hora,concat(s.detalle,' ',st.sesion) as servicio, case when st.idpacientes<>s.idpacientes then Concat('Regalo ', pc.paciente) else '' end as regalo from serviciosturnos st left join servicios s on st.idservicios = s.idservicios left join profesionales p on p.idprofesionales=st.idprofesionales left join pacientes pc on pc.idpacientes=s.idpacientes where st.idpacientes= '"+pac.Idpacientes+"' and st.asistencia = 1 order by st.fecha desc , st.hora");                        
                        dataGridView1.ColumnCount = 4;
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns[0].Name = "Profesional";
                        dataGridView1.Columns[1].Name = "Fecha";
                        dataGridView1.Columns[2].Name = "Servicio";
                        dataGridView1.Columns[3].Name = "Regalo de";
                        int x = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            string profesional = Convert.ToString(dr["profesional"]);
                            DateTime fecha = Convert.ToDateTime(dr["fecha"]);
                            string hora = Convert.ToString(dr["hora"]);
                            string servicio = Convert.ToString(dr["servicio"]);
                            string regalo = Convert.ToString(dr["regalo"]);
                            dataGridView1.Rows.Add(1);
                            dataGridView1.Rows[x].Cells[0].Value = profesional;
                            dataGridView1.Rows[x].Cells[1].Value = fecha.ToString("dd/MM/yyyy") + " " + hora;
                            dataGridView1.Rows[x].Cells[2].Value = servicio;
                            dataGridView1.Rows[x].Cells[3].Value = regalo;
                            x++;
                        }
                    }
                    else
                    {
                        Acceso_BD oacceso = new Acceso_BD();
                        DataTable dt = oacceso.leerDatos("select p.profesional,t.fecha,t.hora,IFNULL(concat(s.detalle,' ',st.sesion),'') as servicio,ifnull(pc.paciente,t.detalle) as cliente, case when st.idpacientes<>s.idpacientes then Concat('Regalo ', pcc.paciente) else '' end as regalo, case when st.asistencia is null then '' else case when st.asistencia=0 then 'AUSENTE' else 'PRESENTE' END end as asistencia, case when st.estado is null then '' else case when st.estado=1 then 'SESION REASIGNADA' else '' END end as PENALIZACION from turnos t left join serviciosturnos st on st.fecha=t.fecha and st.hora=t.hora and st.idprofesionales=t.idprofesionales left join servicios s on st.idservicios = s.idservicios left join pacientes pc on pc.idpacientes=t.idpacientes left join pacientes pcc on pcc.idpacientes=s.idpacientes left join profesionales p on p.idprofesionales=t.idprofesionales where t.idpacientes= '"+pac.Idpacientes+"' union select p.profesional,st.fecha,st.hora,ifnull(concat(s.detalle,' ',st.sesion),'') as servicio,ifnull(pc.paciente,'') as cliente, case when st.idpacientes<>s.idpacientes then Concat('Regalo ', pc.paciente) else '' end as regalo, case when st.asistencia is null then '' else case when st.asistencia=0 then 'AUSENTE' else 'PRESENTE' END end as asistencia, case when st.estado is null then '' else case when st.estado=1 then 'SESION REASIGNADA' else '' END end as PENALIZACION from serviciosturnos st left join servicios s on st.idservicios = s.idservicios left join profesionales p on p.idprofesionales=st.idprofesionales left join pacientes pc on pc.idpacientes=s.idpacientes where st.idpacientes= '"+pac.Idpacientes+"' order by fecha desc , hora desc");
                        dataGridView1.ColumnCount = 6;
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns[0].Name = "Profesional";
                        dataGridView1.Columns[1].Name = "Fecha";
                        dataGridView1.Columns[2].Name = "Servicio";
                        dataGridView1.Columns[3].Name = "Regalo de";
                        dataGridView1.Columns[4].Name = "Asistencia";
                        dataGridView1.Columns[5].Name = "Penalizacion";
                        int x = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            string profesional = Convert.ToString(dr["profesional"]);
                            DateTime fecha = Convert.ToDateTime(dr["fecha"]);
                            string hora = Convert.ToString(dr["hora"]);
                            string servicio = Convert.ToString(dr["servicio"]);
                            string regalo = Convert.ToString(dr["regalo"]);
                            string asistencia = Convert.ToString(dr["asistencia"]);
                            string penalizacion = Convert.ToString(dr["penalizacion"]);
                            dataGridView1.Rows.Add(1);
                            dataGridView1.Rows[x].Cells[0].Value = profesional;
                            dataGridView1.Rows[x].Cells[1].Value = fecha.ToString("dd/MM/yyyy") + " " + hora;
                            dataGridView1.Rows[x].Cells[2].Value = servicio;
                            dataGridView1.Rows[x].Cells[3].Value = regalo;
                            dataGridView1.Rows[x].Cells[4].Value = asistencia;
                            dataGridView1.Rows[x].Cells[5].Value = penalizacion;
                            x++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
