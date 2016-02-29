using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class MovProductos
    {
        int idmovproductos;
        string detalle;
        string responsable;
        int idproductos;
        string producto;
        int cantidad;
        string tipomov;
        string consignacion;

        public string Consignacion
        {
            get { return consignacion; }
            set { consignacion = value; }
        }

        public MovProductos(int i, string d, string r, int idp, string p, int c, string t, string co)
        {
            consignacion = co;
            idmovproductos = i;
            detalle = d;
            responsable = r;
            idproductos = idp;
            producto = p;
            cantidad = c;
            tipomov = t;
        }

        public string Tipomov
        {
            get { return tipomov; }
            set { tipomov = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public string Producto
        {
            get { return producto; }
            set { producto = value; }
        }

        public int Idproductos
        {
            get { return idproductos; }
            set { idproductos = value; }
        }

        public string Responsable
        {
            get { return responsable; }
            set { responsable = value; }
        }

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public int Idmovproductos
        {
            get { return idmovproductos; }
            set { idmovproductos = value; }
        }
    }
}
