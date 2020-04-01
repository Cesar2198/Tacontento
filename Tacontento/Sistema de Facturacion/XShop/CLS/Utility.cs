using Entidades.Entidades.Ordenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XShop.CLS
{
    public static class Utility
    {
       public static string getRol(int id)
        {
            string rol = "";

            switch (id)
            {
                case 1:
                    {
                        rol = "Administrador";
                        break;
                    }
            }


            return rol;
        }

        public static string DevolverClasificacion(int id)
        {
            String dato;

            ClasificacionOrdenes clasificacion = new ClasificacionOrdenes();

            OrdenDAO dao = new OrdenDAO();

           clasificacion =  dao.GetClasificacion(id);

           dato =  clasificacion.nombre;

            return dato;
        }

       

        public static Boolean textBoxIsEmpty(TextBox t)
        {
            Boolean ok = false;
            if (t.Equals(""))
            {
                ok = true;
            }
            
            return ok;
        }

    }

   
}
