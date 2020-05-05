using DataManager.CLS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.Empleados
{
    public class EmpleadosDAO
    {
        DBOperacion Operacion = new DBOperacion();
        Empleados empleado = new Empleados();

        public Empleados CrearEmpleado(Empleados _empleado)
        {
            string Consulta = @"insert into empleados(Nombres,Apellidos,DUI,NIT,Direccion,Genero,Fecha_Nac,estado) values('"+_empleado.Nombres+ "','" + _empleado.Apellidos + "','"+_empleado.DUI+ "','" + _empleado.NIT + "','" + _empleado.Direccion + "'," + _empleado.Genero + ",'" + _empleado.FechaNacimiento + "',0);";

            try
            {   /// Se comprueba qque se inserto o no
                if ((Operacion.Insertar(Consulta)) > 0)
                {
                    this.empleado = _empleado;
                }
                else
                {
                    this.empleado = null;
                }

            }
            catch (Exception ex)
            {   /// Si hubo un error de conexion a la base de datos que me devuelav siempre nulo
                Console.WriteLine(ex);
                this.empleado = null;
                throw;
            }

            return this.empleado;
        }

        public Empleados ObtenerEmpleadoByID(int id)
        {

            DataTable dato = new DataTable();
            String query = @"select idEmpleado from empleados where idEmpleado = " + id + " and estado = 0;";

            try
            {
                if ((Operacion.Consultar(query)) != null)
                {
                    dato = Operacion.Consultar(query);
                    this.empleado.idEmpleado= (int)dato.Rows[0]["idEmpleado"];
                }
                else
                {
                    this.empleado = null;
                }
            }
            catch (Exception e)
            {
                this.empleado = null;
            }


            return this.empleado;
        }

        public Empleados Modificar(Empleados f)
        {

            String Consulta = @"update empleados SET Nombres = '"+f.Nombres+"', Apellidos = '"+f.Apellidos+"',DUI = '"+f.DUI+"', NIT = '"+f.NIT+"', Direccion = '"+f.Direccion+"', Genero = "+f.Genero+", Fecha_Nac = '"+f.FechaNacimiento+"' where idEmpleado = "+f.idEmpleado+";";

            try
            {
                if (Operacion.Actualizar(Consulta) > 0)
                {
                    this.empleado = f;
                }
                else
                {
                    this.empleado = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return this.empleado;
        }

        public Empleados Eliminar(Empleados f)
        {
            string Consulta = "update empleados set estado = 1 where idEmpleado= " + f.idEmpleado + ";";

            try
            {
                if (Operacion.Eliminar(Consulta) > 0)
                {
                    this.empleado = f;
                }
                else
                {
                    this.empleado= null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return this.empleado;
        }

        public Empleados RecuperarEmpleados(Empleados _empleado)
        {

            String Consulta = @"UPDATE empleados set estado = 0 where idEmpleado = " + _empleado.idEmpleado + ";";

            try
            {
                if (Operacion.Actualizar(Consulta) > 0)
                {
                    this.empleado = _empleado;
                }
                else
                {
                    this.empleado = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return this.empleado;
        }






    }
}
