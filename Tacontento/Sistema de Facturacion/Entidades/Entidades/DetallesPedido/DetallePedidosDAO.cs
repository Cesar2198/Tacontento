using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Entidades.Pedidos;

namespace Entidades.Entidades.DetallesPedido
{
    public class DetallePedidosDAO 
    {
        private DataManager.CLS.DBOperacion Db;
        private DetallePedidos Detalles;
        private List<DetallePedidos> lista;
        public DetallePedidosDAO()
        {
            Db = new DataManager.CLS.DBOperacion();
            Detalles = new DetallePedidos();
            lista = new List<DetallePedidos>();
        }

        public List<DetallePedidos> InsertarDetalles(List<DetallePedidos> detalle, Pedidos.Pedidos  p)
        {
            
            for (int i=0; i< detalle.Count;i++)
            {
                string Consulta = @"insert into detallespedidos (idPedido,idOrden,cantidad,precio) 
                                values("+p.id+","+detalle[i].IdOrden+","+detalle[i].Cantidad+","+detalle[i].Precio+");";

                try
                {
                    if (Db.Insertar(Consulta) > 0)
                    {

                      lista = detalle;
                    }
                    else
                    {
                       detalle = null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }
            return lista;
        }

        public List<DetallePedidos> GetDetallePedidos(int id)
        {
            List<DetallePedidos> list = new List<DetallePedidos>();
            DataTable Elemento = new DataTable();
            String sql = "select * from detallespedidos where idPedido = " + id;
            try
            {
                if (Db.Consultar(sql)!=null)
                {
                    Elemento = Db.Consultar(sql);

                    for (int i = 0; i < Elemento.Rows.Count; i++)
                    {
                        DetallePedidos de = new DetallePedidos();
                        de.IdPedido = (int)Elemento.Rows[i]["idPedido"];
                        de.Id = (int)Elemento.Rows[i]["idDetallePedido"];
                        de.IdOrden = (int)Elemento.Rows[i]["idOrden"];
                        de.Precio = decimal.Parse(Elemento.Rows[i]["precio"].ToString());
                        de.Cantidad = (int)(Elemento.Rows[i]["cantidad"]);
                        list.Add(de);

                    }
                }
            }
            catch (Exception e)
            {

            }

            return list != null ? list : null;
        }

        public int updateDetallesPedidos(Pedidos.Pedidos p)
        {

            int ok = 1;
            for (int i = 0; i < p.listaDetalles.Count;i++)
            {
                String Consulta = "update detallespedidos set cantidad = " + p.listaDetalles[i].Cantidad +
                                " where idPedido = " + p.id + " and idOrden = " + p.listaDetalles[i].IdOrden;
                try
                {
                    if (Db.Actualizar(Consulta) < 0)
                    {
                        ok = 0;
                        break;
                    }
                }
                catch (Exception e)
                {

                }
            }
            
            return ok;
        }

        public bool deleteDetalleFromPedido(int idpedido, int idorden)
        {
            bool ok = false;
            string sql = "delete from detallespedidos where idpedido = " + idpedido + " and "
                            + "idorden = " + idorden;
            try
            {
                if (Db.Eliminar(sql) > 0)
                {
                    ok = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrio un Error:  " + e.Message);
            }
            return ok;
        }

    }
}
