using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace BullPadel
{
    public partial class Login : Form
    {
        DAOUsuarios odao = new DAOUsuarios();
        string usuario;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = new Usuario(0, comboBox1.Text, textBox2.Text);
            if (odao.buscar(oUsuario) == true)
            {
                Main frm = new Main();
                usuario = oUsuario.User;
                this.Close();
            }
            else
                MessageBox.Show("Usuario o Contraseña erronea");
        }
        public string devolver()
        {
            return usuario;
        }
        private void Login_Load(object sender, EventArgs e)
        {
            List<Usuario> laux = new List<Usuario>();
            laux = odao.LeerUsuario();
            foreach (Usuario aux in laux)
            {
                comboBox1.Items.Add(aux.User);
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                button1_Click(sender, e);
            }
        }
    }
}
