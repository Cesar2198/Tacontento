using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
