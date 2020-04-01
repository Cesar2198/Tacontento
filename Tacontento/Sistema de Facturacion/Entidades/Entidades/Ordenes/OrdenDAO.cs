using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.Ordenes
{
   public class OrdenDAO
    {
        private DataManager.CLS.DBOperacion Db;
        private Ordenes Orden;
        private List<Ordenes> Listado;

        public OrdenDAO()
        {
            Db = new DataManager.CLS.DBOperacion();
            Orden = new Ordenes();
            Listado = new List<Ordenes>();
        }

        public Ordenes InsertarOrden(Ordenes orden)
        {

            String Consulta = @"insert into ordenes(nombre,precio,descripcion,idClasificacionOrden)
                                values('" + orden.nombre + "'," + orden.precio + ",'" + orden.descripcion + "'," + orden.idClasificacion + ");";

            try
            {
                if (Db.Insertar(Consulta) > 0)
                {
                    
                    Orden = orden;
                }
                else
                {
                    Orden = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return Orden;
        }

        public Ordenes ObtenerOrdenById(int id)
        {
            DataTable Elemento = new DataTable();

            String Consulta = @"select 
            a.nombre,
            a.precio,
            a.descripcion,
            a.idClasificacionOrden
             from ordenes a,
             clasificacionesordenes b
             where a.idClasificacionOrden = b.idClasificacionOrden 
             and a.idOrden = " + id + ";";

            try
            {
                if (Db.Consultar(Consulta) != null)
                {
                    Elemento = Db.Consultar(Consulta);

                    for (int i = 0; i < Elemento.Rows.Count; i++)
                    {
                        Orden.idOrden = (int)Elemento.Rows[0]["idOrden"];
                        Orden.nombre = Elemento.Rows[0]["nombre"].ToString();
                        Orden.precio = Decimal.Parse(Elemento.Rows[0]["precio"].ToString());
                        Orden.descripcion = Elemento.Rows[0]["descripcion"].ToString();
                        Orden.idClasificacion = (int)Elemento.Rows[0]["idClasificacionOrden"];
                    }
                }
                else
                {
                    Orden = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return Orden;
        }

        public List<ClasificacionOrdenes> getClasificacionesOrdenes()
        {
            DataTable Elemento = new DataTable();
            String Consulta = @"select * from clasificacionesordenes";
            List<ClasificacionOrdenes> list = new List<ClasificacionOrdenes>();

            try
            {
                if (Db.Consultar(Consulta) != null)
                {
                    Elemento = Db.Consultar(Consulta);

                    for (int i = 0; i < Elemento.Rows.Count; i++)
                    {
                        ClasificacionOrdenes _Orden = new ClasificacionOrdenes();

                        _Orden.idClasificacion = (int)Elemento.Rows[i]["idClasificacionOrden"];
                        _Orden.nombre = Elemento.Rows[i]["clasificacionOrden"].ToString();
                        

                        list.Add(_Orden);
                    }
                }
                else
                {
                    list = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return list;
        }

        public List<Ordenes> TodasLasOrdenes()
        {
            DataTable Elemento = new DataTable();
            String Consulta = @"select * from ordenes";

            try
            {
                if (Db.Consultar(Consulta) != null)
                {
                    Elemento = Db.Consultar(Consulta);

                    for (int i = 0; i < Elemento.Rows.Count; i++)
                    {
                        Ordenes _Orden = new Ordenes();

                        _Orden.idOrden = (int)Elemento.Rows[i]["idOrden"];
                        _Orden.nombre = Elemento.Rows[i]["nombre"].ToString();
                        _Orden.precio = Decimal.Parse(Elemento.Rows[i]["precio"].ToString());
                        _Orden.descripcion = Elemento.Rows[i]["descripcion"].ToString();
                        _Orden.idClasificacion = (int)Elemento.Rows[i]["idClasificacionOrden"];

                        Listado.Add(_Orden);
                    }
                }
                else
                {
                    Listado = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return Listado;
        }

        public Ordenes Modificar(Ordenes orden)
        {

            String Consulta = @"update ordenes SET nombre= '" + orden.nombre + "' , precio = " + orden.precio + ", descripcion = '" + orden.descripcion + "'," +
                            " idClasificacionOrden = " + orden.idClasificacion + " " +
                            "where idOrden = " + orden.idOrden + ";";

            try
            {
                if (Db.Actualizar(Consulta) > 0)
                {
                    Orden = orden;
                }
                else
                {
                    Orden = null;
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return orden;
        }


        public Ordenes Eliminar(Ordenes orden)
        {
            string Consulta = "delete from ordenes Where idOrden = "+orden.idOrden+";";

            try
            {
                if (Db.Eliminar(Consulta)>0)
                {
                    Orden = orden;
                }
                else
                {
                    Orden = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return Orden;
        }

        public ClasificacionOrdenes GetClasificacion(int id)
        {

            ClasificacionOrdenes clasificacion = new ClasificacionOrdenes();
            DataTable Elemento = new DataTable();
            string Consulta = @"select *  from clasificacionesordenes
                                where idClasificacionOrden =  "+id+"";

            try
            {
                if (Db.Consultar(Consulta)!=null)
                {
                    Elemento = Db.Consultar(Consulta);
                    clasificacion.idClasificacion = (int)Elemento.Rows[0]["idClasificacionOrden"];
                    clasificacion.nombre = Elemento.Rows[0]["clasificacionOrden"].ToString();
                }
                else
                {
                    clasificacion = null;
                }
            }
            catch (Exception)
            {
                clasificacion = null;
                throw;
            }
            return clasificacion;
        }

        



    }
}
