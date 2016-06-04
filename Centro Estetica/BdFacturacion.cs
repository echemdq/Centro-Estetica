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
        public string Agregar(Factura dato, List<Facturacion> dato1)
        {
            DataTable dt = oacceso.leerDatos("insert into facturacion (fecha,idpaciente,detalle,domicilio,documento,localidad,total,ptoventa,factura,bonificacion, tipocomp, regalo, comentario) values ('" + dato.Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "','" + dato.Idpaciente + "','" + dato.Detalle + "','" + dato.Domicilio + "','" + dato.Documento + "','" + dato.Localidad + "','" + dato.Total.ToString().Replace(',', '.') + "','" + dato.Ptoventa + "','" + dato.Numerofact + "','" + dato.Bonif.ToString().Replace(',', '.') + "','1','"+dato.Regalo+"','"+dato.Comentario+"'); select max(idfacturacion) as idfactura from facturacion;");
            string idfactura = "";
            foreach (DataRow dr in dt.Rows)
            {
                idfactura = Convert.ToString(dr["idfactura"]);
            }
            foreach (Facturacion aux in dato1)
            {
                if (aux.P.Sesiones > 0)
                {
                    DataTable dt1 = oacceso.leerDatos("insert into lineafactura (idproductos, cantidad, precioventa, idfacturacion, preciocalculo, sesiones) values ('" + aux.P.Idproductos + "','" + aux.Cantidad + "','" + aux.P.Precioventa.ToString().Replace(',', '.') + "','" + idfactura + "','" + aux.P.Preciocalculo.ToString().Replace(',', '.') + "','" + aux.P.Sesiones + "'); select max(idlineafactura) as pruebaid from lineafactura;");
                    string idlineafactura = "";
                    foreach (DataRow dr in dt1.Rows)
                    {
                        idlineafactura = Convert.ToString(dr["pruebaid"]);
                    }
                    oacceso.ActualizarBD("insert into servicios (idproductos, detalle, sesiones, usadas, idpacientes, idlineafactura, fecha) values ('" + aux.P.Idproductos + "','" + aux.P.Detalle + "','" + aux.P.Sesiones * aux.Cantidad + "','0','" + dato.Idpaciente + "','" + idlineafactura + "','" + dato.Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "')");
                }
                else
                {
                    oacceso.ActualizarBD("insert into lineafactura (idproductos, cantidad, precioventa, idfacturacion, preciocalculo, sesiones) values ('" + aux.P.Idproductos + "','" + aux.Cantidad + "','" + aux.P.Precioventa.ToString().Replace(',', '.') + "','" + idfactura + "','" + aux.P.Preciocalculo.ToString().Replace(',', '.') + "','" + aux.P.Sesiones + "'); update productos set stock = stock - '"+aux.Cantidad+"' where idproductos = '"+aux.P.Idproductos+"'");
                }
            }
            return idfactura;
        }

        public string Agregar1(Factura dato, List<Facturacion> dato1)
        {
            DataTable dt = oacceso.leerDatos("insert into facturacion (fecha,idpaciente,detalle,domicilio,documento,localidad,total,ptoventa,factura,bonificacion, tipocomp, regalo, comentario) values ('" + dato.Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "','" + dato.Idpaciente + "','" + dato.Detalle + "','" + dato.Domicilio + "','" + dato.Documento + "','" + dato.Localidad + "','" + dato.Total.ToString().Replace(',', '.') + "','" + dato.Ptoventa + "','" + dato.Numerofact + "','" + dato.Bonif.ToString().Replace(',', '.') + "','1','"+dato.Regalo+"','"+dato.Comentario+"'); select max(idfacturacion) as idfactura from facturacion;");
            string idfactura = "";
            foreach (DataRow dr in dt.Rows)
            {
                idfactura = Convert.ToString(dr["idfactura"]);
            }
            
            foreach (Facturacion aux in dato1)
            {
                if (aux.P.Sesiones > 0)
                {
                    DataTable dt1 = oacceso.leerDatos("insert into lineafactura (idproductos, cantidad, precioventa, idfacturacion, preciocalculo, sesiones) values ('" + aux.P.Idproductos + "','" + aux.Cantidad + "','" + aux.P.Precioventa.ToString().Replace(',', '.') + "','" + idfactura + "','" + aux.P.Preciocalculo.ToString().Replace(',', '.') + "','" + aux.P.Sesiones + "'); select max(idlineafactura) as pruebaid from lineafactura;");
                    string idlineafactura = "";
                    foreach (DataRow dr in dt1.Rows)
                    {
                        idlineafactura = Convert.ToString(dr["pruebaid"]);
                    }
                    oacceso.ActualizarBD("insert into servicios (idproductos, detalle, sesiones, usadas, idpacientes, idlineafactura, fecha) values ('" + aux.P.Idproductos + "','" + aux.P.Detalle + "','" + aux.P.Sesiones * aux.Cantidad + "','0','" + dato.Idpaciente + "','" + idlineafactura + "','" + dato.Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "')");
                }
                else
                {
                    oacceso.ActualizarBD("insert into lineafactura (idproductos, cantidad, precioventa, idfacturacion, preciocalculo, sesiones) values ('" + aux.P.Idproductos + "','" + aux.Cantidad + "','" + aux.P.Precioventa.ToString().Replace(',', '.') + "','" + idfactura + "','" + aux.P.Preciocalculo.ToString().Replace(',', '.') + "','" + aux.P.Sesiones + "'); update productos set stock = stock - '" + aux.Cantidad + "' where idproductos = '" + aux.P.Idproductos + "'");
                }
            }
            return idfactura;
        }

        public void AgregarFP(TipoFormasPago dato2, string idfactura)
        {
            oacceso.ActualizarBD("insert into formasdepago (idtipoformaspago, idfacturacion, idtarjetas, cupon, cuotas, total) values ('" + dato2.Idtipoformaspago + "','" + idfactura + "','" + dato2.Idtarjetas + "','" + dato2.Cupon + "','" + dato2.Cuotas + "','" + dato2.Importe.ToString().Replace(',', '.') + "')");
        }

        public void AgregarFPC(TipoFormasPago dato2, string idfactura, string idpaciente)
        {
            oacceso.ActualizarBD("insert into ctacte (idfacturacion, idpacientes, tipocomp, importe, cancelado) values ('" + idfactura + "','" + idpaciente + "','1','" + dato2.Importe.ToString().Replace(',', '.') + "',0)");
            oacceso.ActualizarBD("insert into formasdepago (idtipoformaspago, idfacturacion, idtarjetas, cupon, cuotas, total) values ('" + dato2.Idtipoformaspago + "','" + idfactura + "','" + dato2.Idtarjetas + "','" + dato2.Cupon + "','" + dato2.Cuotas + "','" + dato2.Importe.ToString().Replace(',', '.') + "')");
        }

        public void Agregar2(Factura dato, List<Ctacte> dato1, TipoFormasPago dato2)
        {
            DataTable dt = oacceso.leerDatos("insert into facturacion (fecha,idpaciente,detalle,domicilio,documento,localidad,total,ptoventa,factura,bonificacion, tipocomp) values ('" + dato.Fecha.ToString("yyyy-MM-dd HH:mm:ss") + "','" + dato.Idpaciente + "','" + dato.Detalle + "','" + dato.Domicilio + "','" + dato.Documento + "','" + dato.Localidad + "','" + dato.Total.ToString().Replace(',', '.') + "','" + dato.Ptoventa + "','" + dato.Numerofact + "','" + dato.Bonif.ToString().Replace(',', '.') + "','2'); select max(idfacturacion) as idfactura from facturacion;");
            string idfactura = "";
            foreach (DataRow dr in dt.Rows)
            {
                idfactura = Convert.ToString(dr["idfactura"]);
            }
            string update = "begin; ";
            foreach (Ctacte aux in dato1)
            {
                if (aux.Acancelar > 0)
                {
                    update = update + "update ctacte set cancelado = cancelado + '" + aux.Acancelar.ToString().Replace(',', '.') + "' where idctacte = '" + aux.Idctacte + "'; ";
                }
            }
            update = update + "insert into ctacte (idfacturacion, idpacientes, tipocomp, importe, cancelado) values ('" + idfactura + "','" + dato.Idpaciente + "','2','" + dato.Total.ToString().Replace(',', '.') + "','" + dato.Total.ToString().Replace(',', '.') + "'); commit;";
            oacceso.ActualizarBD(update);
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
