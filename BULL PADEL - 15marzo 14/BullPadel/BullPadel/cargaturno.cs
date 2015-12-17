using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BullPadel
{
    class cargaturno
    {        
        string horain;
        string horafin;
        string nombre;
        int dia;
        string tipo;

        public cargaturno(string hi, string hf, string n, int d, string t)
        {
            horafin = hf;
            horain = hi;
            nombre = n;
            dia = d;
            tipo = t;
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public  string Horain
        {
            get { return horain; }
            set { horain = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public string Horafin
        {
            get { return horafin; }
            set { horafin = value; }
        }

    }
}
