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

        public static Ordenes getOrdenById(int id)
        {
            OrdenDAO dao = new OrdenDAO();
            Ordenes o = dao.ObtenerOrdenById(id);
            return o != null ? o : new Ordenes();
        }

       



        public static Boolean textBoxIsEmpty(List<TextBox> t)
        {
            Boolean Valido = false;
            for(int i =0; i< t.Count; i++)
            {
                if (t[i].Text != string.Empty && t[i].Text != " ")
                {
                    Valido = true;
                }
                else
                {
                    Valido = false;
                }    
            }
            return Valido;
        }

        public static void ClearTextbox(List<TextBox> t)
        {
            
            for (int i = 0; i < t.Count; i++)
            {
                t[i].Text = "";
            }
          
        }
       

    }

   
}
