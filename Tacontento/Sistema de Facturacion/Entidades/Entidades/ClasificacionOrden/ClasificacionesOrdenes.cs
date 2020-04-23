using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.ClasificacionOrden
{
   public class ClasificacionesOrdenes
    {
        int _idClasificacionOrden;
        string _ClasificacionOrden;

        public int IdClasificacionOrden { get => _idClasificacionOrden; set => _idClasificacionOrden = value; }
        public string ClasificacionOrden { get => _ClasificacionOrden; set => _ClasificacionOrden = value; }
    }
}
