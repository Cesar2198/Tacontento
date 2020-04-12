using Entidades.Entidades.DetallesPedido;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.Pedidos
{


    public class PedidosDAO : DetallePedidosDAO
    {
        private DataManager.CLS.DBOperacion Db;
        private Pedidos pedido;
        private List<Pedidos> lista;
        public PedidosDAO()
        {

            Db = new DataManager.CLS.DBOperacion();
            pedido = new Pedidos();
            lista = new List<Pedidos>();

        }

        public Pedidos ObtenerPedidoByName(String name, decimal total)
        {
            DataTable Elemento = new DataTable();

            String Consulta = @"select 
                                a.idPedido,
                                a.nombreCliente,
                                a.total,
                                a.fecha,
                                a.tipoPago,
                                a.estado,
                                a.idUsuario
                                from 
                                pedidos a
                                where a.nombreCliente = '"+name+"' and a.total = "+total+";";

            try
            {
                if (Db.Consultar(Consulta) != null)
                {
                    Elemento = Db.Consultar(Consulta);

                    for (int i = 0; i < Elemento.Rows.Count; i++)
                    {
                        this.pedido.id = (int)Elemento.Rows[0]["idPedido"];
                        this.pedido.nombreCliente = Elemento.Rows[0]["nombreCliente"].ToString();
                        this.pedido.total =decimal.Parse(Elemento.Rows[0]["total"].ToString());
                        this.pedido.fecha = DateTime.Parse(Elemento.Rows[0]["fecha"].ToString());
                        this.pedido.tipoPago = (int)Elemento.Rows[0]["tipoPago"];
                        this.pedido.estado = (int)Elemento.Rows[0]["estado"];
                        this.pedido.idUsuario = (int)Elemento.Rows[0]["idUsuario"];

                    }
                }
                else
                {
                    this.pedido = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return this.pedido;
        }

        public Pedidos InsertarPedido(Pedidos pedido)
        {

            string Consulta = @"insert into pedidos (nombreCliente, total, fecha, tipoPago, estado, idUsuario)
                                values ('" + pedido.nombreCliente + "'," + pedido.total + " , NOW() , " + pedido.tipoPago + ", "+pedido.estado+" , " + pedido.idUsuario + ")";

            try
            {

                if (Db.Insertar(Consulta) > 0)
                {
                    this.pedido = pedido;
                    Pedidos p = new Pedidos(); 
                    p = this.ObtenerPedidoByName(pedido.nombreCliente, pedido.total);
                    if(this.InsertarDetalles(pedido.listaDetalles, p).Count != 0 )
                    {
                       
                    }
                }
                else
                {
                    this.pedido = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return this.pedido;
        }
    }

}
