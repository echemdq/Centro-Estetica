using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Centro_Estetica
{
    public class BdFacturacion
    {
        Acceso_BD oacceso = new Acceso_BD();
        public void Agregar(Factura dato, List<Facturacion> dato1, TipoFormasPago dato2)
        {
            DataTable dt = oacceso.leerDatos("insert into facturacion (fecha,idpaciente,detalle,domicilio,documento,localidad,total,ptoventa,factura) values ('" + dato.Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "','" + dato.Idpaciente + "','" + dato.Detalle + "','" + dato.Domicilio + "','" + dato.Documento + "','" + dato.Localidad + "','" + dato.Total.ToString().Replace(',', '.') + "','"+dato.Ptoventa+"','"+dato.Numerofact+"'); select max(idfacturacion) as idfactura from facturacion");
            string idfactura = "";
            foreach (DataRow dr in dt.Rows)
            {
                idfactura = Convert.ToString(dr["idfactura"]);
            }
            foreach (Facturacion aux in dato1)
            {
                if (aux.P.Sesiones > 0)
                {
                    oacceso.ActualizarBD("insert into lineafactura (idproductos, cantidad, precioventa, idfacturacion, preciocalculo, sesiones) values ('" + aux.P.Idproductos + "','" + aux.Cantidad + "','" + aux.P.Precioventa.ToString().Replace(',', '.') + "','" + idfactura + "','" + aux.P.Preciocalculo.ToString().Replace(',', '.') + "','" + aux.P.Sesiones + "'); insert into servicios (idproductos, detalle, sesiones, usadas, idpacientes, idfacturacion) values ('" + aux.P.Idproductos + "','" + aux.P.Detalle + "','" + aux.P.Sesiones + "','0','"+dato.Idpaciente+"','"+idfactura+"')");
                }
                else
                {
                    oacceso.ActualizarBD("insert into lineafactura (idproductos, cantidad, precioventa, idfacturacion, preciocalculo, sesiones) values ('" + aux.P.Idproductos + "','" + aux.Cantidad + "','" + aux.P.Precioventa.ToString().Replace(',', '.') + "','" + idfactura + "','" + aux.P.Preciocalculo.ToString().Replace(',', '.') + "','" + aux.P.Sesiones + "'); update productos set stock = stock - '"+aux.Cantidad+"' where idproductos = '"+aux.P.Idproductos+"'");
                }
            }
            oacceso.ActualizarBD("insert into formasdepago (idtipoformaspago, idfacturacion, idtarjetas, cupon, cuotas, total) values ('" + dato2.Idtipoformaspago + "','" + idfactura + "','" + dato2.Idtarjetas + "','" + dato2.Cupon + "','" + dato2.Cuotas + "','" + dato.Total.ToString().Replace(',', '.') + "')");
        }

        public List<Factura> TraerTodos()
        {
            throw new NotImplementedException();
        }

        public void Borrar(Factura dato)
        {
            throw new NotImplementedException();
        }

        public Factura Buscar(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Factura> BuscarEspecial(string dato)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Factura dato)
        {
            throw new NotImplementedException();
        }

        public int traerSigID()
        {
            throw new NotImplementedException();
        }
    }
}
