using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XShop.CLS

    ///Le heredamos para que sea un contexto de aplicacion
{
    class AppManager: ApplicationContext
    {
        public AppManager()
        {
            if (Splash())
            {
                if (Login())
                {
                    ///Abriremos el formulario principal
<<<<<<< HEAD
                    GUI.MainForm f = new GUI.MainForm();
=======
                    GUI.Principal f = new GUI.Principal();
>>>>>>> a5e4f0f1235316c2ff7a3ed4065316609a92c52c
                    f.ShowDialog();  
                }
            }
        }

        /// <summary>
        /// Metodo que nos dira si el splash se esta mostrando
        /// </summary>
        /// <returns></returns>
        private Boolean Splash()
        {
            Boolean Resultado = true;
            GUI.Splash f = new GUI.Splash();
            f.ShowDialog();
            return Resultado;
        }
        private Boolean Login()
        {
            Boolean Resultado = false;
            GUI.LoginTaco f = new GUI.LoginTaco();
            f.ShowDialog();
            Resultado = f.AUTORIZAR;
            return Resultado;
        }
    }
}
