using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class Facturacion
    {
        int idfacturacion;

        public int Idfacturacion
        {
            get { return idfacturacion; }
            set { idfacturacion = value; }
        }
        Productos p;

        public Productos P
        {
            get { return p; }
            set { p = value; }
        }
        int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Facturacion(int i, Productos prod, int cant)
        {
            cantidad = cant;
            idfacturacion = i;
            p = prod;
        }

    }
}
