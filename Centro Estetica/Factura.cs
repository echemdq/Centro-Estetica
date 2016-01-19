using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centro_Estetica
{
    public class Factura
    {
        int idfactura;
        DateTime fecha;
        int idpaciente;
        string detalle;
        string domicilio;
        string documento;
        int ptoventa;

        public int Ptoventa
        {
            get { return ptoventa; }
            set { ptoventa = value; }
        }
        int numerofact;

        public int Numerofact
        {
            get { return numerofact; }
            set { numerofact = value; }
        }
        
        public string Documento
        {
            get { return documento; }
            set { documento = value; }
        }
        string localidad;
        decimal total;
        decimal bonif;

        public decimal Bonif
        {
            get { return bonif; }
            set { bonif = value; }
        }

        public Factura(int i, DateTime f, int idp, string de, string dom, string docu, string lo, decimal t, int punto, int num, decimal b)
        {
            ptoventa = punto;
            numerofact = num;
            idfactura = i;
            fecha = f;
            idpaciente = idp;
            detalle = de;
            domicilio = dom;
            localidad = lo;
            total = t;
            documento = docu;
            bonif = b;
        }
    
        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public string Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public string Detalle
        {
            get { return detalle; }
            set { detalle = value; }
        }

        public int Idpaciente
        {
            get { return idpaciente; }
            set { idpaciente = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int Idfactura
        {
            get { return idfactura; }
            set { idfactura = value; }
        }

    }
}
