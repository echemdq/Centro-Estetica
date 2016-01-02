using System;
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
    public partial class frmHorariosProfesionales : Form
    {
        ControladoraHorariosProfesionales controlh = new ControladoraHorariosProfesionales();
        public frmHorariosProfesionales(string id)
        {
            InitializeComponent();
            lblId.Text = id;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblId.Text != "")
                {
                    Profesionales prof = new Profesionales(Convert.ToInt32(lblId.Text), "", "", null, "", "", "", 0);
                    string ingreso = txtIng.Text;
                    string egreso = txtEgr.Text;
                    DateTime t;
                    DateTime t1;
                    txtDesde.ValidatingType = typeof(System.DateTime);
                    txtDesde.TypeValidationCompleted += new TypeValidationEventHandler(txtDesde_TypeValidationCompleted);
                    txtHasta.ValidatingType = typeof(System.DateTime);
                    txtHasta.TypeValidationCompleted += new TypeValidationEventHandler(txtHasta_TypeValidationCompleted);
                    string lunes = "0";
                    string martes = "0";
                    string miercoles = "0";
                    string jueves = "0";
                    string viernes = "0";
                    string sabado = "0";
                    string domingo = "0";
                    int i;
                    for (i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
                    {
                        if (checkedListBox1.GetItemChecked(i))
                        {
                            if (checkedListBox1.Items[i].ToString() == "Lunes")
                            {
                                lunes = "1";
                            }
                            else if (checkedListBox1.Items[i].ToString() == "Martes")
                            {
                                martes = "1";
                            }
                            else if (checkedListBox1.Items[i].ToString() == "Miercoles")
                            {
                                miercoles = "1";
                            }
                            else if (checkedListBox1.Items[i].ToString() == "Jueves")
                            {
                                jueves = "1";
                            }
                            else if (checkedListBox1.Items[i].ToString() == "Viernes")
                            {
                                viernes = "1";
                            }
                            else if (checkedListBox1.Items[i].ToString() == "Sabado")
                            {
                                sabado = "1";
                            }
                            else if (checkedListBox1.Items[i].ToString() == "Domingo")
                            {
                                domingo = "1";
                            }
                        }
                    }

                    if (DateTime.TryParse(ingreso, out t) && DateTime.TryParse(egreso, out t1) && txtHasta.Text == "  /  /")
                    {
                        ingreso = t.ToString("HH:mm");
                        egreso = t1.ToString("HH:mm");
                        HorariosProfesionales h = new HorariosProfesionales(0, prof, ingreso, egreso, Convert.ToDateTime(txtDesde.Text), lunes, martes, miercoles, jueves, viernes, sabado, domingo,TSemana.Text);
                        controlh.Agregar(h);
                        frmHorariosProfesionales_Load(sender, e);
                    }
                    else if (DateTime.TryParse(ingreso, out t) && DateTime.TryParse(egreso, out t1) && txtHasta.Text != "  /  /")
                    {
                        ingreso = t.ToString("HH:mm");
                        egreso = t1.ToString("HH:mm");
                        HorariosProfesionales h = new HorariosProfesionales(0, prof, ingreso, egreso, Convert.ToDateTime(txtDesde.Text), Convert.ToDateTime(txtHasta.Text), lunes, martes, miercoles, jueves, viernes, sabado, domingo, TSemana.Text);
                        controlh.Agregar(h);
                        frmHorariosProfesionales_Load(sender, e);
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDesde_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "Fecha Invalida";
                toolTip1.Show("El Formato Correcto es el siguiente: dd/mm/aaaa.", txtDesde, 0, -20, 5000);
            }
        }

        private void txtHasta_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "Fecha Invalida";
                toolTip1.Show("El Formato Correcto es el siguiente: dd/mm/aaaa.", txtHasta, 0, -20, 5000);
            }
        }

        private void frmHorariosProfesionales_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "idhorariosprofesionales";
            dataGridView1.Columns[1].Name = "idprofesionales";
            dataGridView1.Columns[2].Name = "Ingreso";
            dataGridView1.Columns[3].Name = "Egreso";
            dataGridView1.Columns[4].Name = "Desde";
            dataGridView1.Columns[5].Name = "Hasta";
            dataGridView1.Columns[6].Name = "Dias";
            dataGridView1.Columns[7].Name = "Semana";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Rows.Clear();
            List<HorariosProfesionales> aux = controlh.BuscarEspecial(lblId.Text);
            int i = 0;
            foreach (HorariosProfesionales aux1 in aux)
            {
                i++;
            }
            int x = 0;
            if (i > 0)
            {
                dataGridView1.Rows.Add(i);

                foreach (HorariosProfesionales h in aux)
                {
                    dataGridView1.Rows[x].Cells[0].Value = h.IdhorariosProfesionales;
                    dataGridView1.Rows[x].Cells[1].Value = h.Profesionales.Idprofesionales;
                    dataGridView1.Rows[x].Cells[2].Value = h.Ingreso;
                    dataGridView1.Rows[x].Cells[3].Value = h.Egreso;
                    dataGridView1.Rows[x].Cells[4].Value = h.Desde.ToShortDateString();
                    if (h.Semana == "0")
                    {
                        dataGridView1.Rows[x].Cells[7].Value = "Todas";
                    }
                    else if (h.Semana == "1")
                    {
                        dataGridView1.Rows[x].Cells[7].Value = "Impares";
                    }
                    else if (h.Semana == "2")
                    {
                        dataGridView1.Rows[x].Cells[7].Value = "Pares";
                    }
                    if (Convert.ToString(h.Hasta.ToShortDateString()) == "01/01/1900")
                    {
                        dataGridView1.Rows[x].Cells[5].Value = "";
                    }
                    else
                    {
                        dataGridView1.Rows[x].Cells[5].Value = h.Hasta.ToShortDateString();
                    }
                    if (h.Lunes == "1")
                    {
                        dataGridView1.Rows[x].Cells[6].Value = dataGridView1.Rows[x].Cells[6].Value + " - Lunes";
                    }
                    if (h.Martes == "1")
                    {
                        dataGridView1.Rows[x].Cells[6].Value = dataGridView1.Rows[x].Cells[6].Value + " - Martes";
                    }
                    if (h.Miercoles == "1")
                    {
                        dataGridView1.Rows[x].Cells[6].Value = dataGridView1.Rows[x].Cells[6].Value + " - Miercoles";
                    }
                    if (h.Jueves == "1")
                    {
                        dataGridView1.Rows[x].Cells[6].Value = dataGridView1.Rows[x].Cells[6].Value + " - Jueves";
                    }
                    if (h.Viernes == "1")
                    {
                        dataGridView1.Rows[x].Cells[6].Value = dataGridView1.Rows[x].Cells[6].Value + " - Viernes";
                    }
                    if (h.Sabado == "1")
                    {
                        dataGridView1.Rows[x].Cells[6].Value = dataGridView1.Rows[x].Cells[6].Value + " - Sabado";
                    }
                    if (h.Domingo == "1")
                    {
                        dataGridView1.Rows[x].Cells[6].Value = dataGridView1.Rows[x].Cells[6].Value + " - Domingo";
                    }
                    x++;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int filaseleccionada = Convert.ToInt32(this.dataGridView1.CurrentRow.Index);
                int idhorarioprof = Convert.ToInt32(dataGridView1[0, filaseleccionada].Value);
                HorariosProfesionales h = new HorariosProfesionales(idhorarioprof, null, "", "", DateTime.Now, "", "", "", "", "", "", "","");
                DialogResult dialogResult = MessageBox.Show("Esta seguro de eliminar el Horario seleccionado ?", "Eliminar Configuracion Horarios", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    controlh.Borrar(h);
                }
                frmHorariosProfesionales_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox7_Validated(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox7.Text != "  /  /")
                {
                    DateTime a = Convert.ToDateTime(maskedTextBox7.Text);
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

        private void txtDesde_Validated(object sender, EventArgs e)
        {
            try
            {
                if (txtDesde.Text != "  /  /")
                {
                    DateTime a = Convert.ToDateTime(txtDesde.Text);
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
    }
}
