﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.Usuarios
{
    /// <summary>
    /// Entidad usuarios
    /// </summary>
     public class Usuarios
    {
        //Propiedades de la entidad
        public int idUsuario{ get; set; }
        public string usuario { get; set; }
        public string password { get; set; }

        public int rol { get; set; }

        public int estado { get; set; }

        public int idEmpleado { get; set; }

    }
}
