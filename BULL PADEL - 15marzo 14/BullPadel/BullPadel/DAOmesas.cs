using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace BullPadel
{
    class DAOmesas
    {
        AccesoBD oacceso = new AccesoBD();
        public int max()
        {
            string cmdtext = "select max(idmesas), estado from mesas";
            DataTable DT = new DataTable();
            DT = oacceso.leerDatos(cmdtext);
            foreach (DataRow dr in DT.Rows)
            {
                Mesas oMesas = new Mesas(Convert.ToInt32(dr["max(idmesas)"]), Convert.ToString(dr["estado"]));
                //(Convert.ToInt32(dr["idusuarios"]), Convert.ToString(dr["usuario"]), Convert.ToString(dr["contraseña"]));
                return oMesas.Nro;
                // Usuario osuario = new Usuario(Convert.ToInt16(dr["id_usuario"]), Convert.ToString(dr["usuario"]), Convert.ToString(dr["contraseña"]));
            }
            return 0;
        }
        public void eliminar(Mesas omesa)
        {
            string cmdtext = "delete from mesas where idmesas = '" + omesa.Nro + "'";
            oacceso.ActualizarBD(cmdtext);
        }
        public List<Mesas> devolver()
        {
            string cmdText = "select idmesas from mesas";
            DataTable DT = oacceso.leerDatos(cmdText);
            List<Mesas> Lista = new List<Mesas>();
            foreach (DataRow dr in DT.Rows)
            {
                Mesas oMesas = new Mesas(Convert.ToInt32(dr["idmesas"]), "libre");
                //(Convert.ToInt32(dr["idusuarios"]), Convert.ToString(dr["usuario"]), Convert.ToString(dr["contraseña"]));
                Lista.Add(oMesas);
                // Usuario osuario = new Usuario(Convert.ToInt16(dr["id_usuario"]), Convert.ToString(dr["usuario"]), Convert.ToString(dr["contraseña"]));
            }

            return Lista;
        }
        /*public void agregar()
        {
            string cmdtext = "insert into mesas(estado) values('libre')";
            oacceso.ActualizarBD(cmdtext);
        }
        public void agregarp()
        {
            string cmdtext = "insert into CanchaPadel(estado) values('libre')";
            oacceso.ActualizarBD(cmdtext);
        }*/
        public void update(string codigo, int cant)
        {
            string cmdtext = "UPDATE configuraciones SET `Cantidad`='" + cant + "' WHERE codigo='" + codigo + "'";
            oacceso.ActualizarBD(cmdtext);
        }
    }
}
