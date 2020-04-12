using Entidades.Entidades.DetallesPedido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.Pedidos
{
    public class Pedidos
    {
        public int id { get; set; }
        public string nombreCliente { get; set; }
        public decimal total { get; set; }
        public DateTime fecha { get; set; }
        public int tipoPago { get; set; }
        public int idUsuario { get; set; }
        public int estado { get; set; }
        public List<DetallePedidos> listaDetalles { get; set; }
    }
}
