using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class Subrubros
    {
        int idsubrubros;
        string detalle;
        Rubros rubro;

        public Rubros Rubro
        {
            get { return rubro; }
            set { rubro = value; }
        }

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public int Idsubrubros
        {
            get { return idsubrubros; }
            set { idsubrubros = value; }
        }

        public Subrubros(int i, string d)
        {
            idsubrubros = i;
            detalle = d;
        }
        public Subrubros(int i, string d,Rubros r)
        {
            idsubrubros = i;
            detalle = d;
            rubro = r;
        }
    }
}
