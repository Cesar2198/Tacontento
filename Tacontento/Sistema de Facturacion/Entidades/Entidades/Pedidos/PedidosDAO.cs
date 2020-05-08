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

        public Pedidos getPedidosById(int id)
        {
            Pedidos p = new Pedidos();
            DataTable Elemento = new DataTable();
            String Consulta = "select * from pedidos where idPedido = " + id;
            try
            {
                if (Db.Consultar(Consulta) != null)
                {
                    Elemento = Db.Consultar(Consulta);

                        p.id = (int)Elemento.Rows[0]["idPedido"];
                        p.nombreCliente = Elemento.Rows[0]["nombreCliente"].ToString();
                        p.total = decimal.Parse(Elemento.Rows[0]["total"].ToString());
                        p.fecha = DateTime.Parse(Elemento.Rows[0]["fecha"].ToString());
                        p.tipoPago = (int)Elemento.Rows[0]["tipoPago"];
                        p.estado = (int)Elemento.Rows[0]["estado"];
                        p.idUsuario = (int)Elemento.Rows[0]["idUsuario"];
                        p.listaDetalles = this.GetDetallePedidos(p.id);

                    
                }
            }
            catch (Exception e)
            {

            }
            return p != null ? p : null;
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


        public List<Pedidos> findAll()
        {
            List<Pedidos> list = new List<Pedidos>();
            DataTable Elemento = new DataTable();
            String Consulta = "select * from pedidos where estado = 1";
            try
            {
                if (Db.Consultar(Consulta) != null)
                {
                    Elemento = Db.Consultar(Consulta);

                    for (int i = 0; i < Elemento.Rows.Count; i++)
                    {
                        Pedidos p = new Pedidos();
                        p.id = (int)Elemento.Rows[i]["idPedido"];
                        p.nombreCliente = Elemento.Rows[i]["nombreCliente"].ToString();
                        p.total = decimal.Parse(Elemento.Rows[i]["total"].ToString());
                        p.fecha = DateTime.Parse(Elemento.Rows[i]["fecha"].ToString());
                        p.tipoPago = (int)Elemento.Rows[i]["tipoPago"];
                        p.estado = (int)Elemento.Rows[i]["estado"];
                        p.idUsuario = (int)Elemento.Rows[i]["idUsuario"];
                        p.listaDetalles = this.GetDetallePedidos(p.id);
                        list.Add(p);
                    }
                    
                }
            }
            catch (Exception e)
            {
                
            }


            return list != null ? list : null;
        }

        public int updatePedido(Pedidos p)
        {
            string Consulta = @"update pedidos set nombreCliente = '" + p.nombreCliente + "' , total = "
                                + p.total + ", tipoPago = " + p.tipoPago + " where idPedido = " + p.id;
            int ok = 0;
            try
            {
                if (Db.Actualizar(Consulta) > 0 )
                {
                    ok = 1;
                }
                if (this.updateDetallesPedidos(p) > 0)
                {
                    ok = 1;
                }
            }
            catch (Exception e)
            {

            }


            return ok;
        }
    }

}
