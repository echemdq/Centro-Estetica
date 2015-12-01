using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Centro_Estetica
{
    public class BdSubrubros : IDAO<Subrubros>
    {
        Acceso_BD oacceso = new Acceso_BD();

        public void Agregar(Subrubros dato)
        {
            oacceso.ActualizarBD("insert into subrubros (detalle, idrubros) values ('" + dato.Detalle + "','" + dato.Rubro.Idrubros + "')");
        }

        public List<Subrubros> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Subrubros dato)
        {
            oacceso.ActualizarBD("delete from subrubros where idsubrubros = '" + dato.Idsubrubros + "'");
        }

        public Subrubros Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Subrubros> BuscarEspecial(string dato)
        {
            List<Subrubros> aux = new List<Subrubros>();
            string cmdtext = "select * from subrubros where idrubros = '"+dato+"' order by detalle asc";
            DataTable dt = oacceso.leerDatos(cmdtext);
            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["idsubrubros"]);
                string detalle = Convert.ToString(dr["detalle"]);
                Subrubros c = new Subrubros(id, detalle);
                aux.Add(c);
            }
            return aux;
        }

        public void Modificar(Subrubros dato)
        {
            oacceso.ActualizarBD("update subrubros set detalle = '" + dato.Detalle + "' where idsubrubros = '" + dato.Idsubrubros + "'");
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
