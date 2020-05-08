using Entidades.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CacheManager.CLS
{
    public static class Cache
    {
       static DataTable _PERMISOS = new DataTable();
        public static DataTable TODOS_LOS_USUARIOS()
        {
            DataTable Resultado = new DataTable();
            //El string de consulta
            String Consulta;
            ///Nuestro consultor, previamente agregado a las referencias
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"SELECT idUsuario, usuario, password,idRol, estado,idEmpleado
                FROM usuarios 
                where estado = 1
                order by idRol ;";
                //Llenamos nuestra datatable con el metodo consultar
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch (Exception)
            {
                //Si algo falla reestableceriamos todo
                Resultado = new DataTable();
                throw;
            }

            return Resultado;
        }

        public static DataTable TODOS_LAS_ORDENES()
        {
            DataTable Resultado = new DataTable();
            //El string de consulta
            String Consulta;
            ///Nuestro consultor, previamente agregado a las referencias
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"select 
                            idOrden, nombre, precio, descripcion, idClasificacionOrden, Estado 
                            from ordenes where Estado = 1
                            order by idOrden;";
                //Llenamos nuestra datatable con el metodo consultar
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch (Exception)
            {
                //Si algo falla reestableceriamos todo
                Resultado = new DataTable();
                throw;
            }

            return Resultado;
        }


        public static DataTable TODOS_LOS_ROLES()
        {
            DataTable Resultado = new DataTable();
            //El string de consulta
            String Consulta;
            ///Nuestro consultor, previamente agregado a las referencias
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"SELECT idRol, nombre, descripcion, estado
                FROM roles 
                where estado = 1
                order by idRol ;";
                //Llenamos nuestra datatable con el metodo consultar
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch (Exception)
            {
                //Si algo falla reestableceriamos todo
                Resultado = new DataTable();
                throw;
            }

            return Resultado;
        }

        public static DataTable TODOS_LOS_EMPLEADOS()
        {
            DataTable Resultado = new DataTable();
            //El string de consulta
            String Consulta;
            ///Nuestro consultor, previamente agregado a las referencias
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"SELECT idEmpleado, Nombres, Apellidos, DUI, NIT, Direccion, Genero, Fecha_Nac
                FROM empleados 
                where estado = 0
                order by idEmpleado;";
                //Llenamos nuestra datatable con el metodo consultar
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch (Exception)
            {
                //Si algo falla reestableceriamos todo
                Resultado = new DataTable();
                throw;
            }

            return Resultado;
        }
        public static DataTable TODAS_LAS_CLASIFCACIONES()
        {
            DataTable Resultado = new DataTable();
            //El string de consulta
            String Consulta;
            ///Nuestro consultor, previamente agregado a las referencias
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"SELECT idClasificacionOrden, clasificacionOrden
                FROM clasificacionesordenes
                where estado = 1
                order by idClasificacionOrden ;";
                //Llenamos nuestra datatable con el metodo consultar
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch (Exception)
            {
                //Si algo falla reestableceriamos todo
                Resultado = new DataTable();
                throw;
            }

            return Resultado;
        }

        ///Metodo para ver los permisos de un rol
        public static DataTable PERMISOS_DE_UN_ROL(string pdIdRol)
        {
            DataTable Resultado = new DataTable();
            //El string de consulta
            String Consulta;
            ///Nuestro consultor, previamente agregado a las referencias
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"select
                            a.IDPermiso,
                            a.IDOpcion,
                            b.Opcion,
                            a.IDRol
                            from 
                            permisos a,
                            opciones b
                            where IDRol = " + pdIdRol + " and a.IDOpcion = b.IDOpcion;";
                //Llenamos nuestra datatable con el metodo consultar
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch (Exception)
            {
                //Si algo falla reestableceriamos todo
                Resultado = new DataTable();
                throw;
            }

            return Resultado;
        }

        public static void ObtenerPermisos()
        {
            try
            {
                ///Vemos si los permisos son los adecuados para el rol del usuario
                Usuarios user = new Usuarios();
               user =  SessionManager.CLS.Sesion.Instance.Datos.getUsuario();
                _PERMISOS = PERMISOS_DE_UN_ROL(user.rol.ToString());
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static Boolean VerificarPermiso(int pidOpcion)
        {
            Boolean Bandera = false;
            string idOpcionLocal;
            try
            {
                foreach (DataRow Fila in _PERMISOS.Rows)
                {
                    idOpcionLocal = Fila["IDOpcion"].ToString();
                    if (idOpcionLocal.Equals(pidOpcion.ToString()))
                    {
                        Bandera = true;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                Bandera = false;
            }

            if (Bandera == false)
            {
                MessageBox.Show("No cuenta con los Permisos Necesarios.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Bandera;
        }

        public static DataTable TODAS_LAS_OPCIONES()
        {
            DataTable Resultado = new DataTable();
            //El string de consulta
            String Consulta;
            ///Nuestro consultor, previamente agregado a las referencias
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"SELECT 
                            a.idPermiso,
                            b.nombre as rol,
                            c.opcion
                            FROM 
                            permisos a,
                            roles b,
                            opciones c
                            where a.idRol = b.idRol and a.idOpcion = c.idOpcion;";
                //Llenamos nuestra datatable con el metodo consultar
                Resultado = oConsulta.Consultar(Consulta);
            }
            catch (Exception)
            {
                //Si algo falla reestableceriamos todo
                Resultado = new DataTable();
                throw;
            }

            return Resultado;
        }


    }
}
