using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Entidades.Usuarios;
using DataManager.CLS;
using System.Data;

namespace Entidades.Entidades.Usuarios
{
     public class UsuarioDAO
    {
        /// <summary>
        /// El usuario encargado de devolver usuario o algun dato del usuario
        /// </summary>
        //Nuestra conexion a la base de datos junto con las operaciones y consultas
        DBOperacion Operacion = new DBOperacion();

       public UsuarioDAO()
        {
           
        }

        public Usuarios CrearUsuario(Usuarios user)
        {
            Usuarios usuario = new Usuarios();
            string Consulta = @"insert into usuarios(usuario,password,telefono,foto,idRol) 
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

        public Usuarios ObtenerUsuarioByUserNameAndPassword(string username, string pass) 
        {
            Usuarios user = new Usuarios();
            DataTable dato = new DataTable();
            String query = @"select * from usuarios where usuario = '" + username + "' and " +
                "password = '" + pass + "'";

            try
            {
                if ((Operacion.Consultar(query)) != null)
                {
                    dato = Operacion.Consultar(query);
                    user.idUsuario = (int)dato.Rows[0]["idUsuario"];
                    user.usuario = dato.Rows[0]["usuario"].ToString();
                    user.password = dato.Rows[0]["password"].ToString();
                    user.telefono = dato.Rows[0]["telefono"].ToString();
                    user.foto = dato.Rows[0]["foto"].ToString();
                    user.rol = (int)dato.Rows[0]["idRol"];

                }
                else
                {
                    user = null;
                }
            }
            catch(Exception e)
            {
                user = null;                
            }


            return user;
        }

    }
}
