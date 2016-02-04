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
                        int regalo = 0;
                        foreach (DataRow dr in dt.Rows)
                        {
                            string profesional = Convert.ToString(dr["profesional"]);
                            DateTime fecha = Convert.ToDateTime(dr["fecha"])
                        }
                    }
                    else
                    {

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
