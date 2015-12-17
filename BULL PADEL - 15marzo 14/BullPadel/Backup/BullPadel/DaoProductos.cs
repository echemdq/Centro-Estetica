using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace BullPadel
{
    class DaoProductos
    {
        AccesoBD oAcceso = new AccesoBD();        
        public List<Productos> buscar(string descripcion)
        {
            string d1 = "";
            string d2 = "";
            string d3 = descripcion.Trim();                
            int cant = 1;
           
            bool e = true;
            while (e == true)
            {
                int f = d3.LastIndexOf(" ");
                if (f == -1 && d3.Length != 0)
                {
                    d1 = d3.Trim();
                    d3 = "";
                    if (cant == 1)
                    {
                        d2 += " like '%" + d1 + "%' ";
                    }
                    else
                    {
                        d2 += " and descripcion like '%" + d1 + "%' ";
                    }
                    e = false;
                }
                else
                {
                    int c = d3.LastIndexOf(" ");

                    if (c != -1)
                    {
                        int d = d3.LastIndexOf(" ");
                        d1 = d3.Substring(d, d3.Length - d);
                        d1 = d1.Trim();
                        d=d3.LastIndexOf(" ");
                        d3 = d3.Substring(0, d);
                        if (cant == 1)
                        {
                            d2 += " like '%" + d1 + "%' ";
                        }
                        else
                        {
                            d2 += " and descripcion like '%" + d1 + "%' ";

                        }
                    }
                    else
                    {
                        e = false;
                    }
                }
                cant++;
            }
            string cmdText = "select * from articulos where descripcion " + d2 + "order by descripcion";
            DataTable DT = oAcceso.leerDatos(cmdText);
            List<Productos> Lista = new List<Productos>();
            foreach (DataRow dr in DT.Rows)
            {
                //Productos oProducto = new Productos(Convert.ToInt32(dr["idarticulos"]), Convert.ToString(dr["descripcion"]), Convert.ToString(dr["precio"]), Convert.ToString(dr["codbarra"]), Convert.ToInt32(dr["stock"]), null);
                Productos oProducto = new Productos(Convert.ToInt32(dr["idarticulos"]), Convert.ToString(dr["descripcion"]), Convert.ToString(dr["precio"]), Convert.ToString(dr["codbarra"]), Convert.ToInt32(dr["stock"]), null, Convert.ToString(dr["preciocalle"]));
                //(Convert.ToInt32(dr["idusuarios"]), Convert.ToString(dr["usuario"]), Convert.ToString(dr["contraseña"]));
                Lista.Add(oProducto);
                // Usuario osuario = new Usuario(Convert.ToInt16(dr["id_usuario"]), Convert.ToString(dr["usuario"]), Convert.ToString(dr["contraseña"]));
            }

            return Lista;
        }
        
        public void agregar(Productos oproducto)
        {
            string cmdtext = "Insert into Articulos(descripcion, codbarra, precio, stock, preciocalle) values('" + oproducto.Descripcion + "','" + oproducto.Codigobarra + "','" + oproducto.Precio + "','" + oproducto.Stock + "','" + oproducto.Preciocalle + "')";
            oAcceso.ActualizarBD(cmdtext);
        }
        public void update(int id, Productos oproducto)
        {            
            string cmdtext = "update articulos set descripcion = '" + oproducto.Descripcion + "', codbarra = '" + oproducto.Codigobarra + "', precio = '" + oproducto.Precio + "', stock = '" + oproducto.Stock + "', preciocalle = '" + oproducto.Preciocalle + "' where idarticulos = '" + id + "'";
            oAcceso.ActualizarBD(cmdtext);
        }
        public Productos devolverprod(int id)
        {
            string cmdtext = "select * from articulos where idarticulos = '" + id + "'";
            DataTable DT = oAcceso.leerDatos(cmdtext);
            //List<Productos> Lista = new List<Productos>();
            foreach (DataRow dr in DT.Rows)
            {
                Productos oProducto = new Productos(Convert.ToInt32(dr["idarticulos"]), Convert.ToString(dr["descripcion"]), Convert.ToString(dr["precio"]), Convert.ToString(dr["codbarra"]), Convert.ToInt32(dr["stock"]), null, Convert.ToString(dr["preciocalle"]));
                //(Convert.ToInt32(dr["idusuarios"]), Convert.ToString(dr["usuario"]), Convert.ToString(dr["contraseña"]));
                return oProducto;
                // Usuario osuario = new Usuario(Convert.ToInt16(dr["id_usuario"]), Convert.ToString(dr["usuario"]), Convert.ToString(dr["contraseña"]));
            }
            return null;
        }
        public void eliminar(int id)
        {
            string cmdtext = "delete from articulos where idarticulos = '" + id + "'";
            oAcceso.ActualizarBD(cmdtext);
        }
    }
}
