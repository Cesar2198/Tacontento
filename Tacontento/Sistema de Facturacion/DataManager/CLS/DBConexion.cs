using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataManager.CLS
{
    public class DBConexion
    {
        //Conectar y Desconectar
      
        /// <summary>
        /// haremos uso de la clase, llamando una libreria externa
        /// </summary>
        /// <returns></returns>
        /// 
       protected MySqlConnection _CONEXION;
        //Nuestro famoso string de conexion para tener comunicacion con la base de datos
       String _Cadena = "Server=localhost;Port=3306;Database=tacontento;Uid=root;Pwd=admin;SslMode = None";

        protected Boolean Conectar()
        {
            Boolean _Conectado = false;
            ///Haremos un wrapper
            //haremos tambien un try cath para ver los errores
            _CONEXION = new MySqlConnection(_Cadena);
            try
            {
                _CONEXION.Open();
                _Conectado = true;
            }
            catch
            {
                _Conectado = false;
            }
            finally
            {

            }
            //pondremos la cadena de conexion
         

            return _Conectado;
        }
        protected void Desconectar()
        {
            try
            {
                //Preguntamos el estado de la conexion, y si estamos conectados la cerramos
                if (_CONEXION.State == System.Data.ConnectionState.Open)
                {
                    _CONEXION.Close();
                }
            }
            catch
            {

            }
        }
    }
}
