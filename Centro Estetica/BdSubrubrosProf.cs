using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class BdSubrubrosProf : IDAO<SubrubrosProfesionales>
    {
        Acceso_BD oacceso = new Acceso_BD();
        public void Agregar(SubrubrosProfesionales dato)
        {
            oacceso.ActualizarBD("insert into subrubrosprofesionales (idsubrubros, idprofesionales) values ('" + dato.Subrubro.Idsubrubros + "','" + dato.Profesional.Idprofesionales + "')");
        }

        public List<SubrubrosProfesionales> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(SubrubrosProfesionales dato)
        {
            throw new NotImplementedException();
        }

        public SubrubrosProfesionales Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<SubrubrosProfesionales> BuscarEspecial(string dato)
        {
            List<SubrubrosProfesionales> aux = new List<SubrubrosProfesionales>();
            string cmdtext = "select sp.idsubrubrosprofesionales as idsubrubrosprofesionales, sp.idprofesionales as idprofesionales, sp.idsubrubros as idsubrubros, r.idrubros as idrubros, s.detalle as detalle, r.detalle as rubro from subrubrosprofesionales sp inner join profesionales p on sp.idprofesionales = p.idprofesionales inner join subrubros s on sp.idsubrubros = s.idsubrubros inner join rubros r on r.idrubros = s.idrubros where sp.idprofesionales = '" + dato + "' order by detalle asc";
            DataTable dt = oacceso.leerDatos(cmdtext);
            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["idsubrubros"]);
                string detalle = Convert.ToString(dr["detalle"]);
                int idr = Convert.ToInt32(dr["idrubros"]);
                string rubro = Convert.ToString(dr["rubro"]);
                Rubros r = new Rubros(idr, rubro);
                Subrubros s = new Subrubros(id, detalle, r);
                Profesionales p = new Profesionales(Convert.ToInt32(dr["idprofesionales"]), "", "", null, "", "", "", 0);
                SubrubrosProfesionales c = new SubrubrosProfesionales(Convert.ToInt32(dr["idsubrubrosprofesionales"]), s, p);
                aux.Add(c);
            }
            return aux;
        }

        public void Modificar(SubrubrosProfesionales dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
