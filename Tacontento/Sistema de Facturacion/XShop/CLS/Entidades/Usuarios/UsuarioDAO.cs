using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XShop.CLS.Entidades.Usuarios;
using DataManager.CLS;

namespace XShop.CLS.Entidades.Usuarios
{
     class UsuarioDAO
    {
        /// <summary>
        /// El usuario encargado de devolver usuario o algun dato del usuario
        /// </summary>
        private Usuarios User;
        //Nuestra conexion a la base de datos junto con las operaciones y consultas
        DBOperacion Operacion = new DBOperacion();

       public UsuarioDAO()
        {
           
        }

        public Usuarios CrearUsuario(Usuarios user)
        {
            Usuarios usuario = new Usuarios();
            string Consulta = @"insert into Usuarios(user,password,telefono,foto,rol) 
            values('"+user.usuario+"','"+user.password+"','"+user.telefono+"','"+user.foto+"',"+user.rol+");";

            try
            {   /// Se comprueba qque se inserto o no
                if ((Operacion.Insertar(Consulta))>0)
                {
                    usuario = user;
                }
                else
                {
                    usuario = null;
                }

            }
            catch (Exception ex)
            {   /// Si hubo un error de conexion a la base de datos que me devuelav siempre nulo
                Console.WriteLine(ex);
                usuario = null;
                throw;
            }

            return usuario;
        }

    }
}
