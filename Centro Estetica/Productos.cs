using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class Productos
    {
        int idproductos;
        string codigo;
        string detalle;
        decimal costo;
        int stock;
        Subrubros subrubro;

        public Subrubros Subrubro
        {
            get { return subrubro; }
            set { subrubro = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public decimal Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public int Idproductos
        {
            get { return idproductos; }
            set { idproductos = value; }
        }
    }
}
