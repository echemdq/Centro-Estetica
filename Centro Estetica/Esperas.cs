using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class Esperas
    {
        int idesperas;
        string nombre;
        string telefono;
        string detalle;
        DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public Esperas(int i, string n, string t, string d)
        {
            idesperas = i;
            nombre = n;
            telefono = t;
            detalle = d;
        }

        public Esperas(int i, string n, string t, string d, DateTime f)
        {
            idesperas = i;
            nombre = n;
            telefono = t;
            detalle = d;
            fecha = f;
        }

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Idesperas
        {
            get { return idesperas; }
            set { idesperas = value; }
        }
    }
}
