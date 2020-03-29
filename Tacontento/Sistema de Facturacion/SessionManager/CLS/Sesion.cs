using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Entidades.Usuarios;

namespace SessionManager.CLS
{
    public class Sesion
    {
        private static Sesion instance = null;
        Datos datos;
        private static readonly object padlock = new object();

        public Sesion()
        {
            datos = new Datos();
        }


        public  static Sesion Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if(instance == null){
                            instance = new Sesion();
                        }
                    }
                }
                return instance;
            }
        }

        public  Datos Datos { get => datos; set => datos = value; }
    }
}
