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
        string detalle;
        decimal precioventa;
        int sesiones;
        int stock;
        Subrubros subrubro;
        int activo;
        decimal preciocalculo;

        public decimal Preciocalculo
        {
            get { return preciocalculo; }
            set { preciocalculo = value; }
        }

        public int Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        public int Sesiones
        {
            get { return sesiones; }
            set { sesiones = value; }
        }
        int llevastock;

        public int Llevastock
        {
            get { return llevastock; }
            set { llevastock = value; }
        }
        

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

        public decimal Precioventa
        {
            get { return precioventa; }
            set { precioventa = value; }
        }

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public int Idproductos
        {
            get { return idproductos; }
            set { idproductos = value; }
        }
    }
}
