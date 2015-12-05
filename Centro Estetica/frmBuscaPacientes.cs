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
    public partial class frmBuscaPacientes : Form
    {
        ControladoraPacientes controlp = new ControladoraPacientes();
        public Pacientes u = null;
        public frmBuscaPacientes()
        {
            InitializeComponent();
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            if (txtPaciente.Text != "")
            {
                dataGridView1.Rows.Clear();
                string d1 = "";
                string d2 = "";
                string d3 = txtPaciente.Text.Trim();
                int cant = 1;

                bool a = true;
                while (a == true)
                {
                    int f = d3.LastIndexOf(" ");
                    if (f == -1 && d3.Length != 0)
                    {
                        d1 = d3.Trim();
                        d3 = "";
                        if (cant == 1)
                        {
                            d2 += " like '%" + d1 + "%' ";
                        }
                        else
                        {
                            d2 += " and nombre like '%" + d1 + "%' ";
                        }
                        a = false;
                    }
                    else
                    {
                        int c = d3.LastIndexOf(" ");

                        if (c != -1)
                        {
                            int d = d3.LastIndexOf(" ");
                            d1 = d3.Substring(d, d3.Length - d);
                            d1 = d1.Trim();
                            d = d3.LastIndexOf(" ");
                            d3 = d3.Substring(0, d);
                            if (cant == 1)
                            {
                                d2 += " like '%" + d1 + "%' ";
                            }
                            else
                            {
                                d2 += " and nombre like '%" + d1 + "%' ";

                            }
                        }
                        else
                        {
                            a = false;
                        }
                    }
                    cant++;
                }
                List<Pacientes> lista = controlp.BuscarEspecial(d2);
                int i = 0;
                foreach (Pacientes aux in lista)
                {
                    i++;
                }
                int x = 0;
                if (i > 0)
                {
                    dataGridView1.Rows.Add(i);
                    foreach (Pacientes aux in lista)
                    {
                        dataGridView1.Rows[x].Cells[0].Value = aux.Idpacientes;
                        dataGridView1.Rows[x].Cells[1].Value = aux.Paciente;
                        dataGridView1.Rows[x].Cells[2].Value = aux.Tipod.Detalle;
                        dataGridView1.Rows[x].Cells[3].Value = aux.Documento;
                        dataGridView1.Rows[x].Cells[4].Value = aux.Domicilio;
                        dataGridView1.Rows[x].Cells[5].Value = aux.Telefono;
                        dataGridView1.Rows[x].Cells[6].Value = aux.Celular;
                        dataGridView1.Rows[x].Cells[7].Value = aux.Mail;
                        dataGridView1.Rows[x].Cells[8].Value = aux.Tipod.Idtipodoc;
                        dataGridView1.Rows[x].Cells[9].Value = aux.Foto;
                        dataGridView1.Rows[x].Cells[10].Value = aux.Activo;
                        dataGridView1.Rows[x].Cells[11].Value = aux.Comentarios;
                        x++;
                    }
                }
            }
        }

        private void frmBuscaPacientes_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 12;
            dataGridView1.Columns[0].Name = "idpaciente";
            dataGridView1.Columns[1].Name = "Paciente";
            dataGridView1.Columns[2].Name = "Tipo Doc";
            dataGridView1.Columns[3].Name = "Documento";
            dataGridView1.Columns[4].Name = "Domicilio";
            dataGridView1.Columns[5].Name = "Telefono";
            dataGridView1.Columns[6].Name = "Celular";
            dataGridView1.Columns[7].Name = "Mail";
            dataGridView1.Columns[8].Name = "idtipodoc";
            dataGridView1.Columns[9].Name = "foto";
            dataGridView1.Columns[10].Name = "";
            dataGridView1.Columns[11].Name = "Comentario";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaseleccionada = Convert.ToInt32(this.dataGridView1.CurrentRow.Index);
            int idpaciente = Convert.ToInt32(dataGridView1[0, filaseleccionada].Value);
            string paciente = dataGridView1[1, filaseleccionada].Value.ToString();
            int idtipod = Convert.ToInt32(dataGridView1[8, filaseleccionada].Value);
            string tipod = dataGridView1[2, filaseleccionada].Value.ToString();
            TipoDoc tipodoc = new TipoDoc(idtipod, tipod);
            string documento = dataGridView1[3, filaseleccionada].Value.ToString();
            string domicilio = dataGridView1[4, filaseleccionada].Value.ToString();
            string telefono = dataGridView1[5, filaseleccionada].Value.ToString();
            string celular = dataGridView1[6, filaseleccionada].Value.ToString();
            string mail = dataGridView1[7, filaseleccionada].Value.ToString();
            string foto = dataGridView1[9, filaseleccionada].Value.ToString();
            string comentario = dataGridView1[11, filaseleccionada].Value.ToString();
            int activo = Convert.ToInt32(dataGridView1[10, filaseleccionada].Value);
            u = new Pacientes(idpaciente, paciente, telefono, domicilio, mail, documento, tipodoc, celular, activo, comentario, foto);
            this.Close();
        }

        private void txtPaciente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnTraer_Click(sender, e);
            }
        }
    }
}
