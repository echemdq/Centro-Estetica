using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class TotalesCaja
    {
        string detalle;

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }
        decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public TotalesCaja(string d, decimal t)
        {
            total = t;
            detalle = d;
        }
    }
}
