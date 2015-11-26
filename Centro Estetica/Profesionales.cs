using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class Profesionales
    {
        int idprofesionales;
        string profesional;
        string documento;
        TipoDoc tipod;
        string domicilio;
        string telefono;
        string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
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

        public string Profesional
        {
            get { return profesional; }
            set { profesional = value; }
        }

        public int Idprofesionales
        {
            get { return idprofesionales; }
            set { idprofesionales = value; }
        }
    }
}
