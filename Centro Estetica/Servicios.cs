using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class Servicios
    {
        int idservicios;
        int idproductos;
        string detalle;
        int sesiones;
        int usadas;
        int idfacturacion;
        int idpacientes;

        public Servicios(int ids, int idp, string d, int s, int u, int idf, int idpa)
        {
            idservicios = ids;
            idproductos = idp;
            detalle = d;
            sesiones = s;
            usadas = u;
            idfacturacion = idf;
            idpacientes = idpa;
        }

        public int Idpacientes
        {
            get { return idpacientes; }
            set { idpacientes = value; }
        }

        public int Idfacturacion
        {
            get { return idfacturacion; }
            set { idfacturacion = value; }
        }

        public int Usadas
        {
            get { return usadas; }
            set { usadas = value; }
        }

        public int Sesiones
        {
            get { return sesiones; }
            set { sesiones = value; }
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

        public int Idservicios
        {
            get { return idservicios; }
            set { idservicios = value; }
        }
    }
}
