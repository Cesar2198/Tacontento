﻿using System;
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

            String Consulta = @"insert into ordenes(nombre,precio,descripcion,idClasificacionOrden,Estado)
                                values('" + orden.nombre + "'," + orden.precio + ",'" + orden.descripcion + "'," + orden.idClasificacion + ",1);";

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
            a.idOrden,
            a.nombre,
            a.precio,
            a.descripcion,
            a.idClasificacionOrden
             from ordenes a,
             clasificacionesordenes b
             where a.idClasificacionOrden = b.idClasificacionOrden 
             and a.idOrden = " + id + " and a.Estado = 1;";

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
            String Consulta = @"select * from clasificacionesordenes where estado = 1";
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
            String Consulta = @"select * from ordenes where Estado = 1";

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
            string Consulta = "update Ordenes set Estado = 2 where idOrden= "+orden.idOrden+";";

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

        public List<Ordenes> getOrdenByName(string name)
        {
            List<Ordenes> list = new List<Ordenes>();
            string query = @"select * from ordenes where upper(nombre) like '%"+name.ToUpper()+"%' and Estado = 1;";
            try
            {
                if (Db.Consultar(query)!=null)
                {
                    DataTable Elemento = Db.Consultar(query);
                    for (int i = 0; i < (Db.Consultar(query)).Rows.Count; i++)
                    {
                        Ordenes _Orden = new Ordenes();

                        _Orden.idOrden = (int)Elemento.Rows[i]["idOrden"];
                        _Orden.nombre = Elemento.Rows[i]["nombre"].ToString();
                        _Orden.precio = Decimal.Parse(Elemento.Rows[i]["precio"].ToString());
                        _Orden.descripcion = Elemento.Rows[i]["descripcion"].ToString();
                        _Orden.idClasificacion = (int)Elemento.Rows[i]["idClasificacionOrden"];
                        list.Add(_Orden);
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine("Error: ", e.Message);
            }
            return list != null ? list : new List<Ordenes>();
        }



        public Ordenes RecuperarOrdenes(Ordenes _orden)
        {
            String Consulta = @"UPDATE ordenes set estado = 1 where idOrden = "+ _orden.idOrden +";";

            try
            {
                if (Db.Actualizar(Consulta) > 0)
                {
                    this.Orden = _orden;
                }
                else
                {
                    this.Orden = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return this.Orden;
        }



    }
}
