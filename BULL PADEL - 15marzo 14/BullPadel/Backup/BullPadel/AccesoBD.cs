using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace BullPadel
{
    class AccesoBD
    {
        
        static string server = "localhost";
        static string database = "bullpadelbd";
        static string uid = "root";
        static string password = "romeo1";
        static string connectionString = "Server=" + server + ";" + "DATABASE=" + database + ";" + "User ID=" + uid + ";" + "PASSWORD=" + password + ";";  
        MySqlConnection cn = new MySqlConnection(connectionString);
        
        
       // SqlConnection cn = new SqlConnection("Data Source=EZEQUIEL-PC\\SQLEXPRESS;Initial Catalog=TP_carrito;Integrated Security=True");
        public void Conectar()
        {
            cn.Open();
        }
        public void desconectar()
        {
            cn.Close();
        }
       /* public DataTable leerDatos(string cmdtext)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(cmdtext, cn);
            Conectar();
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            desconectar();
            return dt;

        }*/ 

        public void ActualizarBD(string query)
        {
            /*SqlCommand cmd = new SqlCommand(cmdtext, cn);
            Conectar();
            cmd.ExecuteNonQuery();
            desconectar();*/
            Conectar();      
            //create mysql command
            MySqlCommand cmd = new MySqlCommand();
            //Assign the query using CommandText
            cmd.CommandText = query;
            //Assign the connection using Connection
            cmd.Connection = cn;
            //Execute query
            cmd.ExecuteNonQuery();
            desconectar();
        }
        public DataTable leerDatos(string cmdtext)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd = new MySqlCommand(cmdtext, cn);
            Conectar();
            MySqlDataReader reader = cmd.ExecuteReader();            
            dt.Load(reader);
            desconectar();
            return dt;
        }
    }
}
