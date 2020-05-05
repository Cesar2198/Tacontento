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
                Consulta = @"SELECT idUsuario,Usuario, idEmpleado
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


        public static DataTable TODOS_LOS_EMPLEADOS_ELIMINADOS()
        {
            DataTable Resultado = new DataTable();
            //El string de consulta
            String Consulta;
            ///Nuestro consultor, previamente agregado a las referencias
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"SELECT idEmpleado,CONCAT(Nombres, ' ', Apellidos) As Nombre,DUI
                            FROM empleados 
                            WHERE estado = 1
                            ORDER BY idEmpleado;";
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



        public static DataTable TODOS_LOS_CLASIFICACIONES_ELIMINADOS()
        {
            DataTable Resultado = new DataTable();
            //El string de consulta
            String Consulta;
            ///Nuestro consultor, previamente agregado a las referencias
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"SELECT idClasificacionOrden , clasificacionOrden
                            FROM clasificacionesordenes 
                            where estado = 2
                            order by idClasificacionOrden;";
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



        public static DataTable TODOS_LAS_ORDENES_ELIMINADOS()
        {
            DataTable Resultado = new DataTable();
            //El string de consulta
            String Consulta;
            ///Nuestro consultor, previamente agregado a las referencias
            DataManager.CLS.DBOperacion oConsulta = new DataManager.CLS.DBOperacion();
            try
            {
                Consulta = @"SELECT idOrden, nombre, precio
                            FROM ordenes 
                            where estado = 2
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



    }
}
