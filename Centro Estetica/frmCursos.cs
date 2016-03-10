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
    public partial class frmCursos : Form
    {
        Profesionales prof = null;
        Especialidades esp = null;
        public frmCursos()
        {
            InitializeComponent();
        }

        private void frmCursos_Load(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToShortDateString();
            List<Especialidades> laux = new List<Especialidades>();
            Acceso_BD oacceso = new Acceso_BD();
            DataTable dt = oacceso.leerDatos("select * from especialidades");
            foreach (DataRow dr in dt.Rows)
            {
                Especialidades t = new Especialidades(Convert.ToInt32(dr["idespecialidades"]), Convert.ToString(dr["detalle"]));
                laux.Add(t);
            }
            if (laux.Count != 0)
            {
                cmbEspecialidades.DataSource = laux;
                cmbEspecialidades.DisplayMember = "detalle";
                cmbEspecialidades.ValueMember = "idtipo";
                cmbEspecialidades.SelectedValue = 0;
            }
        }

        private void cmbEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Profesionales> laux = new List<Profesionales>();
            Acceso_BD oacceso = new Acceso_BD();
            DataTable dt = oacceso.leerDatos("select * from profesionales where idespecialidades = '"+cmbEspecialidades.SelectedValue+"'");
            foreach (DataRow dr in dt.Rows)
            {
                Profesionales p = new Profesionales(Convert.ToInt32(dr["idprofesionales"]), Convert.ToString(dr["profesional"]), "", null, "", "", "", 0, 0, 0);
                laux.Add(p);
            }
            if (laux.Count != 0)
            {
                cmbProfesionales.DataSource = laux;
                cmbProfesionales.DisplayMember = "profesional";
                cmbProfesionales.ValueMember = "idprofesionales";
                cmbProfesionales.SelectedIndex = 0;
            }
            else
            {
                cmbProfesionales.DataSource = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(txtFecha.Text).Date == DateTime.Now.Date && cmbEspecialidades.SelectedValue != null && cmbProfesionales.SelectedValue != null)
                {
                    prof = new Profesionales(Convert.ToInt32(cmbProfesionales.SelectedValue), "", "", null, "", "", "", 0, 0, 0);
                    esp = new Especialidades(Convert.ToInt32(cmbEspecialidades.SelectedValue), "");
                    btnCliente.Enabled = true;
                    Acceso_BD oac = new Acceso_BD();
                    DateTime fecha = Convert.ToDateTime(txtFecha.Text);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = oac.leerDatos("select p.paciente as Cliente, s.detalle as Servicio, sesion as Sesion from cursos c left join pacientes p on c.idpacientes = p.idpacientes left join servicios s on c.idservicios = s.idservicios where c.fecha = '" + fecha.ToString("yyyy-MM-dd") + "' and c.idprofesionales = '" + prof.Idprofesionales + "'");
                }
                else if (cmbEspecialidades.SelectedValue != null && cmbProfesionales.SelectedValue != null)
                {
                    dataGridView1.DataSource = null;
                    Acceso_BD oac = new Acceso_BD();
                    DateTime fecha = Convert.ToDateTime(txtFecha.Text);
                    dataGridView1.DataSource = oac.leerDatos("select p.paciente as Cliente, s.detalle as Servicio, sesion as Sesion from cursos c left join pacientes p on c.idpacientes = p.idpacientes left join servicios s on c.idservicios = s.idservicios where c.fecha = '" + fecha.ToString("yyyy-MM-dd") + "' and c.idprofesionales = '" + prof.Idprofesionales + "'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDateTime(txtFecha.Text).Date == DateTime.Now.Date && prof != null && esp != null)
                {
                    frmBuscaPacientes frm = new frmBuscaPacientes();
                    frm.ShowDialog();
                    Pacientes p = frm.u;
                    if (p != null)
                    {
                        frmBuscaServicio frm1 = new frmBuscaServicio(p.Idpacientes.ToString(), "0");
                        frm1.ShowDialog();
                        Servicios s = frm1.u;
                        if (s != null)
                        {
                            DialogResult dialogResult = MessageBox.Show("Esta seguro de confirmar la asistencia al curso del Cliente: "+p.Paciente, "Eliminar Producto", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                Acceso_BD oacceso = new Acceso_BD();
                                oacceso.ActualizarBD("begin; update servicios set usadas = usadas + 1 where idservicios = '" + s.Idservicios + "'; insert into cursos (idprofesionales, idservicios, idpacientes, sesion, fecha) values ('" + prof.Idprofesionales + "','" + s.Idservicios + "','" + p.Idpacientes + "','" + (s.Usadas + 1) + "/" + s.Sesiones + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "'); commit;");
                                MessageBox.Show("Cliente y servicio cargado exitosamente");
                                prof = null;
                                esp = null;
                                btnCliente.Enabled = false;
                                cmbEspecialidades.SelectedValue = 0;
                                dataGridView1.DataSource = null;
                            }
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
