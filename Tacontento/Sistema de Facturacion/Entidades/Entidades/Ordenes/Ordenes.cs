using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.Ordenes
{
    public class Ordenes
    {

        public int idOrden { get; set; }
        public string nombre { get; set; }
        public Decimal precio  { get; set; }
        public string descripcion { get; set; }
        public int idClasificacion { get; set; }

    }
}
