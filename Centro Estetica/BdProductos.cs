using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Centro_Estetica
{
    public class BdProductos : IDAO<Productos>
    {
        Acceso_BD oacceso = new Acceso_BD();

        public void Agregar(Productos dato)
        {
            oacceso.ActualizarBD("insert into productos (detalle, precioventa, sesiones, stock, activo, preciocalculo) values ('" + dato.Detalle + "','" + dato.Precioventa.ToString().Replace(',', '.') + "','" + dato.Sesiones + "','" + dato.Stock + "','" + dato.Activo + "','" + dato.Preciocalculo.ToString().Replace(',', '.') + "')");
        }

        public List<Productos> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Productos dato)
        {
            oacceso.ActualizarBD("delete from productos where idproductos = '" + dato.Idproductos + "'");
        }

        public Productos Buscar(string dato)
        {
            string cmdtext = "select * from productos where idproductos  = '" + dato + "'";
            DataTable dt = oacceso.leerDatos(cmdtext);
            Productos usuario = null;
            foreach (DataRow dr in dt.Rows)
            {
                int activo = Convert.ToInt32(dr["activo"]);
                usuario = new Productos(Convert.ToInt32(dr["idproductos"]), Convert.ToString(dr["detalle"]), Convert.ToDecimal(Convert.ToString(dr["precioventa"]).Replace('.', ',')), Convert.ToInt32(dr["sesiones"]), Convert.ToInt32(dr["stock"]), activo, Convert.ToDecimal(Convert.ToString(dr["preciocalculo"]).Replace('.', ',')));
                
            }
            return usuario;
        }

        public List<Productos> BuscarEspecial(string dato)
        {
            string cmdtext = "select * from productos where detalle " + dato + " order by detalle";
            DataTable dt = oacceso.leerDatos(cmdtext);
            Productos usuario = null;
            List<Productos> lista = new List<Productos>();
            foreach (DataRow dr in dt.Rows)
            {
                int activo = Convert.ToInt32(dr["activo"]);
                usuario = new Productos(Convert.ToInt32(dr["idproductos"]), Convert.ToString(dr["detalle"]), Convert.ToDecimal(Convert.ToString(dr["precioventa"]).Replace('.',',')), Convert.ToInt32(dr["sesiones"]), Convert.ToInt32(dr["stock"]), activo, Convert.ToDecimal(Convert.ToString(dr["preciocalculo"]).Replace('.',',')));
                lista.Add(usuario);
            }
            return lista;
        }

        public void Modificar(Productos dato)
        {
            oacceso.ActualizarBD("update productos set detalle = '" + dato.Detalle + "', precioventa = '" + dato.Precioventa.ToString().Replace(',', '.') + "', sesiones = '" + dato.Sesiones + "', stock = '" + dato.Stock + "', activo = '" + dato.Activo + "', preciocalculo = '" + dato.Preciocalculo.ToString().Replace(',', '.') + "' where idproductos = '" + dato.Idproductos + "'");
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
