using System;
using System.Collections.Generic;
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
    }
}
