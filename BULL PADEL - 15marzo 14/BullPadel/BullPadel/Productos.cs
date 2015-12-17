using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BullPadel
{
    public class Productos
    {
        string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        string precio;

        public string Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        string preciocalle;
        public string Preciocalle
        {
            get { return preciocalle; }
            set { preciocalle = value; }
        }
        string codigobarra;

        public string Codigobarra
        {
            get { return codigobarra; }
            set { codigobarra = value; }
        }
        int stock;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        Categoria oCategoria;

        internal Categoria OCategoria
        {
            get { return oCategoria; }
            set { oCategoria = value; }
        }
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Productos(int i, string d, string p, string c, int s, Categoria ca, string pc)
        {
            Id = i;
            Descripcion = d;
            Precio = p;
            Codigobarra = c;
            Stock = s;
            OCategoria = ca;
            Preciocalle = pc;
        }
    }
}
