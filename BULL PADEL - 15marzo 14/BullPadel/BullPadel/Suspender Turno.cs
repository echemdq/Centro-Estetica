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
    public partial class Suspender_Turno : Form
    {
        string i;
        string t;
        int dia;
        AccesoBD oacceso = new AccesoBD();
        public Suspender_Turno(string id, string tur, int d)
        {
            i = id;
            t = tur;
            dia = d;
            InitializeComponent();
        }

        private void Suspender_Turno_Load(object sender, EventArgs e)
        {
            textBox1.Text = t;
        }
        //puto puto
        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                string fecha = maskedTextBox1.Text;
                DateTime FE = Convert.ToDateTime(fecha);
                int dia1 = (int)FE.DayOfWeek;
                if (dia1 == 0)
                {
                    dia1 = 7;
                }
                if (dia1 == dia)
                {
                    oacceso.ActualizarBD("insert into novedades(idturno, fecha, comentarios) values('" + i + "','" + FE.ToString("yyyy-MM-dd") + "','"+textBox2.Text+"')");
                    MessageBox.Show("Turno Suspendido Correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La fecha puesta no corresponde al dia");
                }
            }
            else MessageBox.Show("Debe completar la fecha");
        }
    }
}
