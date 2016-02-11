using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Centro_Estetica
{
    public class BdCtaCte
    {
        Acceso_BD oacceso = new Acceso_BD();
        public void Agregar(Ctacte dato)
        {
            throw new NotImplementedException();
        }

        public List<Ctacte> TraerTodos(string dato)
        {
            DataTable dt = oacceso.leerDatos("select c.idctacte , c.idfacturacion, c.idpacientes, c.tipocomp, c.importe, c.cancelado, f.fecha, f.ptoventa, f.factura from ctacte c left join facturacion f on c.idfacturacion = f.idfacturacion where c.idpacientes = '" + dato + "' order by idctacte");
            List<Ctacte> lista = new List<Ctacte>();
            foreach (DataRow dr in dt.Rows)
            {
                Factura f = new Factura(0, Convert.ToDateTime(dr["fecha"]), 0, "", "", "", "", 0, Convert.ToInt32(dr["ptoventa"]), Convert.ToInt32(dr["factura"]), 0);
                Ctacte c = new Ctacte(Convert.ToInt32(dr["idctacte"]), Convert.ToInt32(dr["idpacientes"]), f, Convert.ToDecimal(dr["importe"]), Convert.ToDecimal(dr["cancelado"]), Convert.ToInt32(dr["tipocomp"]));
                lista.Add(c);
            }
            return lista;
        }

        public void Borrar(Ctacte dato)
        {
            throw new NotImplementedException();
        }

        public Ctacte Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Ctacte> BuscarEspecial(string dato)
        {
            DataTable dt = oacceso.leerDatos("select c.idctacte , c.idfacturacion, c.idpacientes, c.tipocomp, c.importe, c.cancelado, f.fecha, f.ptoventa, f.factura from ctacte c left join facturacion f on c.idfacturacion = f.idfacturacion where c.idpacientes = '"+dato+"' and c.importe - c.cancelado > 0 and c.tipocomp = 1");
            List<Ctacte> lista = new List<Ctacte>();
            foreach (DataRow dr in dt.Rows)
            {
                Factura f = new Factura(0, Convert.ToDateTime(dr["fecha"]), 0, "", "", "", "",0, Convert.ToInt32(dr["ptoventa"]), Convert.ToInt32(dr["factura"]),0);
                Ctacte c = new Ctacte(Convert.ToInt32(dr["idctacte"]), Convert.ToInt32(dr["idpacientes"]), f, Convert.ToDecimal(dr["importe"]), Convert.ToDecimal(dr["cancelado"]), Convert.ToInt32(dr["tipocomp"]));
                lista.Add(c);
            }
            return lista;
        }

        public void Modificar(Ctacte dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
