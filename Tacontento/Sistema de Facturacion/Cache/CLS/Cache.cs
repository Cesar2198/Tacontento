using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CacheManager.CLS
{
    public static class Cache
    {
        public static DataTable TODOS_LOS_USUARIOS()
        {
            DataTable Resultado = new DataTable();
            //El string de consulta
            String Consulta;
            ///Nuestro consultor, previamente agregado a las referencias
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"SELECT idUsuario, usuario, password, telefono, idRol, estado
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


    }
}
