using Entidades.Entidades.Ordenes;
using Entidades.Entidades.Roles;
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
                case 2:
                    {
                        rol = "Mesero";
                        break;
                    }
                case 3:
                    {
                        rol = "Cocinero";
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
        public static string DevolverRol(int id)
        {
            String dato;

            Rol rol = new Rol();

            RolesDAO dao = new RolesDAO();

            rol = dao.ObtenerRolById(id);

            dato = rol.RolName;

            return dato;
        }

        public static Ordenes getOrdenById(int id)
        {
            OrdenDAO dao = new OrdenDAO();
            Ordenes o = dao.ObtenerOrdenById(id);
            return o != null ? o : new Ordenes();
        }

        public static string DesEncriptar(string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
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
