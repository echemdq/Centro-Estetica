using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class Pacientes
    {
        int idpacientes;
        string paciente;
        string telefono;
        string domicilio;
        string mail;
        string documento;
        TipoDoc tipod;
        string celular;
        int activo;
        string comentarios;

        public string Comentarios
        {
            get { return comentarios; }
            set { comentarios = value; }
        }
        string foto;

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public int Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }

        public TipoDoc Tipod
        {
            get { return tipod; }
            set { tipod = value; }
        }

        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        } 

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Paciente
        {
            get { return paciente; }
            set { paciente = value; }
        }

        public int Idpacientes
        {
            get { return idpacientes; }
            set { idpacientes = value; }
        }
    }
}
