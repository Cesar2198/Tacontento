using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace DataManager.CLS
{
    /// <summary>
    /// le compartimos todo a las operaciones con una herencia
    /// </summary>
    public class DBOperacion:DBConexion
    {
        public Int32 Insertar(String pSentencia)
        {
            ///devolveremos el valor de ejecutar sentencia
            return EjecutarSentencia(pSentencia);
        }
        public Int32 Actualizar(String pSentencia)
        {
            ///devolveremos el valor de ejecutar sentencia
            return EjecutarSentencia(pSentencia);
        }
        public Int32 Eliminar(String pSentencia)
        {
            ///devolveremos el valor de ejecutar sentencia
            return EjecutarSentencia(pSentencia);
        }
        //Esta clase se encargara de las operaciones de la base de datos
        private Int32 EjecutarSentencia(String pSentencia)
        {
            Int32 FilasAfectadas = 0;
            ///Comando con el cual diremos que hacer
            MySqlCommand Comando = new MySqlCommand();

            try
            {
                //con  base llegamos a la clase padre
                if (base.Conectar())
                {
                    ///Nos conectamos y le pasamos una sentencia
                    Comando.Connection = base._CONEXION;
                    Comando.CommandText = pSentencia;
                    FilasAfectadas = Comando.ExecuteNonQuery();
                }
            }
            catch
            {
                //Indicamos que da un error
                FilasAfectadas = -1;
            }
            finally
            {
                Desconectar();
            }

            return FilasAfectadas;
        }
        ///Haremos una consulta que devuelta un set de resultados
       public DataTable Consultar(String pConsulta)
        {
            DataTable Resultado = new DataTable();

            ///creamos componentes de mysql que nos servira para traer datos y filtrar
            MySqlCommand Comando = new MySqlCommand();
            MySqlDataAdapter Adaptador = new MySqlDataAdapter();
            try{
                if(base.Conectar()){
                   Comando.Connection = base._CONEXION;
                    Comando.CommandText= pConsulta;
                    Adaptador.SelectCommand = Comando;
                    Adaptador.Fill(Resultado);
                }
            }catch{
                Resultado = new DataTable();
            }
            finally
            {
                Desconectar();
            }
            return Resultado;
        }
        
        public void Desconectar()
        {
            base.Desconectar();
        }
    }
}
