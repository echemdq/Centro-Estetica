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
        int activo;
        int sinturnero;
        int idespecialidades;

        public int Idespecialidades
        {
            get { return idespecialidades; }
            set { idespecialidades = value; }
        }

        public int Sinturnero
        {
            get { return sinturnero; }
            set { sinturnero = value; }
        }

        public Profesionales(int i, string p, string d, TipoDoc t, string dom, string tel, string m, int a, int s, int esp)
        {
            idespecialidades = esp;
            idprofesionales = i;
            profesional = p;
            documento = d;
            tipod = t;
            domicilio = dom;
            telefono = tel;
            mail = m;
            sinturnero = s;
            activo = a;
        }

        public int Activo
        {
            get { return activo; }
            set { activo = value; }
        } 

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
