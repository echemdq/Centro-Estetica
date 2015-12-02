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
            throw new NotImplementedException();
        }

        public Pacientes Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Pacientes> BuscarEspecial(string dato)
        {
            throw new NotImplementedException();
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
