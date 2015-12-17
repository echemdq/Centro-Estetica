using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace BullPadel
{
    class DAOUsuarios
    {
        AccesoBD oAcceso = new AccesoBD();
        public void agregar(Usuario oUsuario)
        {
            if (buscar(oUsuario) == false)
            {
                string cmdtext = "Insert into Usuario(usuario, contraseña) values('" + oUsuario.User + "','" + oUsuario.Contraseña + "')";
                oAcceso.ActualizarBD(cmdtext);
            }
            else
                throw new Exception("El usuario ya existe");

        }
        public List<Usuario> LeerUsuario()
        {
            string cmdText = "select idusuarios, upper(usuario), contrasena from Usuarios";
            DataTable DT = oAcceso.leerDatos(cmdText);
            List<Usuario> ListaUser = new List<Usuario>();
            foreach (DataRow dr in DT.Rows)
            {
                //Usuario oUsuario = new Usuario(Convert.ToInt32(dr["idusuarios"]), Convert.ToString(dr["usuario"]), Convert.ToString(dr["contraseña"]));
                Usuario oUsuario = new Usuario(Convert.ToInt32(dr["idusuarios"]), Convert.ToString(dr["upper(usuario)"]), Convert.ToString(dr["contrasena"]));
                ListaUser.Add(oUsuario);
               // Usuario osuario = new Usuario(Convert.ToInt16(dr["id_usuario"]), Convert.ToString(dr["usuario"]), Convert.ToString(dr["contraseña"]));
            }

            return ListaUser;
        }
        public bool buscar(Usuario oUsuario)
        {
            List<Usuario> laux = new List<Usuario>();
            laux = LeerUsuario();
            foreach(Usuario aux in laux)
            {
                if(oUsuario.User == aux.User && oUsuario.Contraseña == aux.Contraseña)
                {
                    return true;
                }
                else if (oUsuario.User == aux.User && oUsuario.Contraseña != aux.Contraseña)
                {
                    return false;
                }                
            }
            return false;
        }
        
    }
}
