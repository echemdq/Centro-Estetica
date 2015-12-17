using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BullPadel
{
    class Adicion
    {
        Productos oProducto;

        internal Productos OProducto
        {
            get { return oProducto; }
            set { oProducto = value; }
        }
        Mesas oMesa;

        internal Mesas OMesa
        {
            get { return oMesa; }
            set { oMesa = value; }
        }
        int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }
        public Adicion(Productos p, Mesas m, int c, decimal t)
        {
            OProducto = p;
            OMesa = m;
            Cantidad = c;
            Total = t;
        }
    }
}
