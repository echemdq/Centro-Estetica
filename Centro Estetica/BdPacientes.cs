using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Centro_Estetica
{
    public class BdPacientes : IDAO<Pacientes>
    {
        Acceso_BD oacceso = new Acceso_BD();

        public void Agregar(Pacientes dato)
        {
            oacceso.ActualizarBD("insert into pacientes (paciente, telefono, domicilio, mail, documento, idtipodoc, celular, activo, comentarios, foto) values ('"+dato.Paciente+"','"+dato.Telefono+"','"+dato.Domicilio+"','"+dato.Mail+"','"+dato.Documento+"','"+dato.Tipod.Idtipodoc+"','"+dato.Celular+"','"+dato.Activo+"','"+dato.Comentarios+"','"+dato.Foto+"')");
        }

        public List<Pacientes> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Pacientes dato)
        {
            oacceso.ActualizarBD("delete from pacientes where idpacientes = '" + dato.Idpacientes + "'");
        }

        public Pacientes Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Pacientes> BuscarEspecial(string dato)
        {
            string cmdtext = "select * from pacientes p inner join tipodoc td on p.idtipodoc = td.idtipodoc where paciente " + dato + " or documento "+dato+" order by paciente";
            DataTable dt = oacceso.leerDatos(cmdtext);
            Pacientes usuario = null;
            TipoDoc tipod = null;
            List<Pacientes> lista = new List<Pacientes>();
            foreach (DataRow dr in dt.Rows)
            {
                tipod = new TipoDoc(Convert.ToInt32(dr["idtipodoc"]), Convert.ToString(dr["detalle"]));
                int activo = Convert.ToInt32(dr["activo"]);
                usuario = new Pacientes(Convert.ToInt32(dr["idpacientes"]), Convert.ToString(dr["paciente"]), Convert.ToString(dr["telefono"]), Convert.ToString(dr["domicilio"]), Convert.ToString(dr["mail"]), Convert.ToString(dr["documento"]), tipod, Convert.ToString(dr["celular"]), activo, Convert.ToString(dr["comentarios"]), Convert.ToString(dr["foto"]));
                lista.Add(usuario);
            }
            return lista;
        }

        public void Modificar(Pacientes dato)
        {
            oacceso.ActualizarBD("update pacientes set paciente = '" + dato.Paciente + "', telefono = '" + dato.Telefono + "', domicilio = '" + dato.Domicilio + "', mail = '" + dato.Mail + "', documento = '" + dato.Documento + "', idtipodoc = '" + dato.Tipod.Idtipodoc + "', celular = '" + dato.Celular + "', activo = '" + dato.Activo + "', comentarios = '" + dato.Comentarios + "', foto = '" + dato.Foto + "' where idpacientes = '" + dato.Idpacientes + "'");
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
