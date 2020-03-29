using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Entidades.Usuarios;

namespace SessionManager.CLS
{
    public class Datos
    {
        private Usuarios usuario;

        public Datos()
        {
            
        }

        public void setUsuario(Usuarios user)
        {
            this.usuario = user;
        }

        public Usuarios getUsuario()
        {
            return this.usuario;
        }
    }
}
