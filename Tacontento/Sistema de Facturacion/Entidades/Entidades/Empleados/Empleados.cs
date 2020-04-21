using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.Empleados
{
    public class Empleados
    {
        public int idEmpleado { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string DUI { get; set; }
        public string NIT { get; set; }
        public string Direccion { get; set; }
        public int Genero { get; set; }
        public string FechaNacimiento { get; set; }

    }
}
