using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManager.CLS
{
    /// <summary>
    /// Esta clase tendra los listados de los elementos eliminados para recuperar
    /// </summary>
    public static class Papelera
    {
        public static DataTable TODOS_LOS_USUARIOS_ELIMINADOS()
        {
            DataTable Resultado = new DataTable();
            //El string de consulta
            String Consulta;
            ///Nuestro consultor, previamente agregado a las referencias
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"SELECT idUsuario,usuario,idEmpleado
                FROM usuarios 
                where estado = 2
                order by idUsuario;";
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
