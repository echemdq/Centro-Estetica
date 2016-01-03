using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Centro_Estetica
{
    public class BdProfesionales : IDAO<Profesionales>
    {
        Acceso_BD oacceso = new Acceso_BD();

        public void Agregar(Profesionales dato)
        {
            oacceso.ActualizarBD("insert into profesionales (profesional, documento, idtipodoc, domicilio, telefono, activo, mail) values ('" + dato.Profesional + "','" + dato.Documento + "','" + dato.Tipod.Idtipodoc + "','" + dato.Domicilio + "','" + dato.Telefono + "','" + dato.Activo + "','"+dato.Mail+"')");
        }

        public List<Profesionales> TraerTodos()
        {
            string cmdtext = "select * from profesionales p inner join tipodoc t on t.idtipodoc = p.idtipodoc where p.activo = '1' order by profesional asc";
            DataTable dt = oacceso.leerDatos(cmdtext);
            Profesionales usuario = null;
            TipoDoc tipod = null;
            List<Profesionales> lista = new List<Profesionales>();
            foreach (DataRow dr in dt.Rows)
            {
                tipod = new TipoDoc(Convert.ToInt32(dr["idtipodoc"]), Convert.ToString(dr["detalle"]));
                int activo = Convert.ToInt32(dr["activo"]);
                usuario = new Profesionales(Convert.ToInt32(dr["idprofesionales"]), Convert.ToString(dr["profesional"]), Convert.ToString(dr["documento"]), tipod, Convert.ToString(dr["domicilio"]), Convert.ToString(dr["telefono"]), Convert.ToString(dr["mail"]), activo);
                lista.Add(usuario);
            }
            return lista;
        }

        public void Borrar(Profesionales dato)
        {
            oacceso.ActualizarBD("delete from profesionales where idprofesionales = '" + dato.Idprofesionales + "'");
        }

        public Profesionales Buscar(string dato)
        {
            DataTable dt = oacceso.leerDatos("select idprofesionales, profesional from profesionales where idprofesionales = '" + dato + "'");
            Profesionales p = null;
            foreach (DataRow dr in dt.Rows)
            {
                p = new Profesionales(Convert.ToInt32(dr["idprofesionales"]), Convert.ToString(dr["profesional"]), "", null, "", "", "", 0);
            }
            return p;
        }

        public List<Profesionales> BuscarEspecial(string dato)
        {
            string cmdtext = "select * from profesionales p inner join tipodoc td on p.idtipodoc = td.idtipodoc where profesional " + dato + " order by profesional";
            DataTable dt = oacceso.leerDatos(cmdtext);
            Profesionales usuario = null;
            TipoDoc tipod = null;
            List<Profesionales> lista = new List<Profesionales>();
            foreach (DataRow dr in dt.Rows)
            {
                tipod = new TipoDoc(Convert.ToInt32(dr["idtipodoc"]), Convert.ToString(dr["detalle"]));
                int activo = Convert.ToInt32(dr["activo"]);
                usuario = new Profesionales(Convert.ToInt32(dr["idprofesionales"]), Convert.ToString(dr["profesional"]), Convert.ToString(dr["documento"]), tipod, Convert.ToString(dr["domicilio"]), Convert.ToString(dr["telefono"]), Convert.ToString(dr["mail"]), activo);
                lista.Add(usuario);
            }
            return lista;
        }

        public void Modificar(Profesionales dato)
        {
            oacceso.ActualizarBD("update profesionales set profesional = '" + dato.Profesional + "', documento = '" + dato.Documento + "', idtipodoc = '" + dato.Tipod.Idtipodoc + "', domicilio = '" + dato.Domicilio + "', telefono = '" + dato.Telefono + "', activo = '" + dato.Activo + "', mail = '"+dato.Mail+"' where idprofesionales = '" + dato.Idprofesionales + "'");
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
