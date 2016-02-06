using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class TipoMovCajas
    {
        int idtipo;
        string detalle;

        public TipoMovCajas(int i, string d)
        {
            idtipo = i;
            detalle = d;
        }

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public int Idtipo
        {
            get { return idtipo; }
            set { idtipo = value; }
        }
    }
}
