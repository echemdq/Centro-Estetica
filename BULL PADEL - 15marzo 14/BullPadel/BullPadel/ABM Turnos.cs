using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BullPadel
{
    public partial class ABM_Turnos : Form
    {
        AccesoBD oacceso = new AccesoBD();
        string hora;
        string dia;
        DateTime fecha;
        bool suspendido = false;
        bool ok = false;
        public bool Ok()
        {
            return ok;
        }
        public ABM_Turnos(string h, string d, DateTime f, bool s)
        {
            hora = h;
            dia = d;
            fecha = f;
            suspendido = s;
            InitializeComponent();
            if (radioButton1.Checked)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
            }
            else
            {
                groupBox3.Enabled = true;
                groupBox2.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                groupBox3.Enabled = true;
                groupBox2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime time = Convert.ToDateTime(maskedTextBox3.Text);                
                    DataTable dt = new DataTable();
                    if (suspendido == false)
                    {
                        
                        DateTime FE = Convert.ToDateTime(maskedTextBox2.Text);
                        string cm = "select 'turno ya cargado' as ok from turnos  where ingreso > '" + maskedTextBox1.Text + ":00" + "' and ingreso < '" + maskedTextBox3.Text + ":00" + "' and dia = '" + dia + "' and fecha = '" + FE.ToString("yyyy-MM-dd") + "' or (egreso > '" + maskedTextBox1.Text + ":00" + "' and egreso < '" + maskedTextBox3.Text + ":00" + "' and dia = '" + dia + "' and fecha = '" + FE.ToString("yyyy-MM-dd") + "')";
                        dt = oacceso.leerDatos(cm);
                    }
                    bool ok = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        if ((Convert.ToString(dr["ok"])) == "turno ya cargado")
                        {
                            ok = false;
                        }
                        else ok = true;
                    }
                    if (ok == true)
                    {
                        if (radioButton1.Checked)
                        {
                            if (label3.Text != "")
                            {
                                oacceso.ActualizarBD("insert into turnos(ingreso, egreso, dia, idcliente) values('" + maskedTextBox1.Text + ":00','" + maskedTextBox3.Text + ":00','" + dia + "', '" + label3.Text + "')");
                                MessageBox.Show("Turno Fijo guardado correctamente");
                                this.Close();
                            }
                            else MessageBox.Show("Debe completar todos los campos");

                        }
                        else
                        {
                            string nombre = textBox6.Text;
                            string telefono = textBox5.Text;
                            string celular = textBox4.Text;
                            string fecha = maskedTextBox2.Text;
                            DateTime FE = Convert.ToDateTime(fecha);
                            int dia1 = (int)FE.DayOfWeek;
                            if (dia1 == 0)
                            {
                                dia1 = 7;
                            }
                            if (dia1.ToString() == dia)
                            {
                                if (nombre != "" && telefono != "" && fecha != "")
                                {
                                    string cmdtext = "insert into turnos(nombre, telefono, celular, dia, ingreso, egreso, fecha) values('" + nombre + "','" + telefono + "','" + celular + "','" + dia + "','" + maskedTextBox1.Text + ":00','" + maskedTextBox3.Text + ":00','" + FE.ToString("yyyy-MM-dd") + "')";
                                    oacceso.ActualizarBD(cmdtext);
                                    MessageBox.Show("Turno guardado correctamente");
                                    this.Close();
                                }
                                else MessageBox.Show("Debe completar obligatoriamente Egreso, Nombre, Telefono y Fecha");
                            }
                            else
                            {
                                MessageBox.Show("La fecha puesta no corresponde al dia");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("El turno ya se encuentra ocupado");
                    }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Cuidado debe completar hora de egreso");
            }
        }

        private void ABM_Turnos_Load(object sender, EventArgs e)
        {
            if (dia == "1")
            {
                textBox7.Text = "Lunes";
                maskedTextBox1.Text = hora;
            }
            else if (dia == "2")
            {
                textBox7.Text = "Martes";
                maskedTextBox1.Text = hora;
            }
            else if (dia == "3")
            {
                textBox7.Text = "Miercoles";
                maskedTextBox1.Text = hora;
            }
            else if (dia == "4")
            {
                textBox7.Text = "Jueves";
                maskedTextBox1.Text = hora;
            }
            else if (dia == "5")
            {
                textBox7.Text = "Viernes";
                maskedTextBox1.Text = hora;
            }
            else if (dia == "6")
            {
                textBox7.Text = "Sabado";
                maskedTextBox1.Text = hora;
            }
            else if (dia == "7")
            {
                textBox7.Text = "Domingo";
                maskedTextBox1.Text = hora;
            }
            maskedTextBox2.Text = fecha.ToString("dd/MM/yyyy");
            if (suspendido == true)
            {
                radioButton1.Enabled = false;
                radioButton2.Checked = true;
                groupBox2.Enabled = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buscarcliente frm = new buscarcliente();
            frm.ShowDialog();
            string descrip = frm.desc();
            textBox1.Text = descrip;
            label3.Text = frm.Id().ToString();
            
        }




    }
}
