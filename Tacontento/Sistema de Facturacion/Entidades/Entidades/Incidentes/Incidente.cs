using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.Incidentes
{
    public class Incidente
    {
        private int idIncidente;
        private string descripcion;
        private decimal precio;
        private int pedido;

        public int IdIncidente { get => idIncidente; set => idIncidente = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Pedido { get => pedido; set => pedido = value; }
    }
}
