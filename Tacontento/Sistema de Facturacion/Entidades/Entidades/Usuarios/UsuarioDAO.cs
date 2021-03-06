﻿using System;
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
        Usuarios user = new Usuarios();

       public UsuarioDAO()
        {
           
        }

        public Usuarios CrearUsuario(Usuarios user)
        {
            Usuarios usuario = new Usuarios();
            string Consulta = @"insert into usuarios(usuario,password,idRol,estado,idEmpleado) 
            values('"+user.usuario+"',md5(sha1('"+user.password+"')),"+user.rol+","+user.estado+","+user.idEmpleado+");";

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
                "password = md5(sha1('" + pass + "')) and estado = 1";

            try
            {
                if ((Operacion.Consultar(query)) != null)
                {
                    dato = Operacion.Consultar(query);
                    user.idUsuario = (int)dato.Rows[0]["idUsuario"];
                    user.usuario = dato.Rows[0]["usuario"].ToString();
                    user.password = dato.Rows[0]["password"].ToString();      
                    user.rol = (int)dato.Rows[0]["idRol"];
                    user.estado = (int)dato.Rows[0]["estado"];
                    user.idEmpleado = (int)dato.Rows[0]["idEmpleado"];

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

        public Usuarios Modificar(Usuarios user)
        {

            String Consulta = @"update usuarios SET usuario= '" + user.usuario + "' , password = md5(sha1('" + user.password + "')), estado = "+user.estado+", idEmpleado = "+user.idEmpleado+"," +
                            " idRol = " + user.rol + " " +
                            "where idUsuario = " + user.idUsuario + ";";

            try
            {
                if (Operacion.Actualizar(Consulta) > 0)
                {
                    this.user = user;
                }
                else
                {
                    this.user = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return this.user;
        }

        public Usuarios Eliminar(Usuarios f)
        {
            string Consulta = "update usuarios set estado = 2 where idUsuario= " + f.idUsuario + ";";

            try
            {
                if (Operacion.Eliminar(Consulta) > 0)
                {
                    this.user = f;
                }
                else
                {
                    this.user = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return this.user;
        }

        public Usuarios RecuperarUsuario(Usuarios user)
        {

            String Consulta = @"UPDATE usuarios set estado = 1 where idUsuario = "+user.idUsuario+";";

            try
            {
                if (Operacion.Actualizar(Consulta) > 0)
                {
                    this.user = user;
                }
                else
                {
                    this.user = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return this.user;
        }

        public string Encriptar(string pass)
        {
            string devolver;
            String Consulta = @"select md5(sha1('"+pass+"')) as password;";
            DataTable dato = new DataTable();
            try
            {
                if (Operacion.Consultar(Consulta)!=null)
                {
                    
                    dato = Operacion.Consultar(Consulta);
                    devolver= dato.Rows[0]["password"].ToString();
                }
                else
                {
                    devolver = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return devolver;
        }


    }
}

