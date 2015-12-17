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
    public partial class Datos : Form
    {
        string nombre;
        string telefono;
        string celular;
        string comentarios;
        public Datos(string n, string t, string c, string co)
        {
            InitializeComponent();
            nombre= n;
            telefono = t;
            celular = c;
            comentarios = co;
        }

        private void Datos_Load(object sender, EventArgs e)
        {
            textBox2.Text = nombre;
            textBox3.Text = telefono;
            textBox4.Text = celular;
            textBox5.Text = comentarios;
        }
    }
}
