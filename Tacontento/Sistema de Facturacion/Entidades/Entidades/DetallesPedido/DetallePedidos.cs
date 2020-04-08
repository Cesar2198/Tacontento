using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.DetallesPedido
{
    public class DetallePedidos
    {
        int id;
        int idPedido;
        int idOrden;
        Decimal precio;
        int cantidad;

        public int Id { get => id; set => id = value; }
        public int IdPedido { get => idPedido; set => idPedido = value; }
        public int IdOrden { get => idOrden; set => idOrden = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
