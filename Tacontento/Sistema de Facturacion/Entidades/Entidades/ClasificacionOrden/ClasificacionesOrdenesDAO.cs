using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.ClasificacionOrden
{
    public class ClasificacionesOrdenesDAO
    {
        private DataManager.CLS.DBOperacion Db;
        private ClasificacionesOrdenes claO;

        public ClasificacionesOrdenesDAO()
        {
            Db = new DataManager.CLS.DBOperacion();
            claO = new ClasificacionesOrdenes();
        }

        public ClasificacionesOrdenes InsertarClasificacion(ClasificacionesOrdenes C)
        {
            string Consulta = @"insert into clasificacionesordenes(clasificacionOrden, estado) 
            values('"+C.ClasificacionOrden+"',1);";

            try
            {   /// Se comprueba qque se inserto o no
                if ((Db.Insertar(Consulta)) > 0)
                {
                    this.claO = C;
                }
                else
                {
                    this.claO = null;
                }

            }
            catch (Exception ex)
            {   /// Si hubo un error de conexion a la base de datos que me devuelva siempre nulo
                Console.WriteLine(ex);
                this.claO = null;
                throw;
            }

            return this.claO;
        }

        public ClasificacionesOrdenes ModificarClasificacion(ClasificacionesOrdenes C)
        {
            String Consulta = @"update clasificacionesordenes SET clasificacionOrden= '" + C.ClasificacionOrden + "' where idClasificacionOrden = " + C.IdClasificacionOrden + ";";

            try
            {
                if (Db.Actualizar(Consulta) > 0)
                {
                    this.claO = C;
                }
                else
                {
                    this.claO = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return this.claO;
        }

        public ClasificacionesOrdenes EliminarClasificacion(ClasificacionesOrdenes C)
        {
            String Consulta = @"update clasificacionesordenes SET estado = 2 where idClasificacionOrden = " + C.IdClasificacionOrden + ";";

            try
            {
                if (Db.Eliminar(Consulta) > 0)
                {
                    this.claO = C;
                }
                else
                {
                    this.claO = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return this.claO;
        }



        public ClasificacionesOrdenes RecuperarClasificacion(ClasificacionesOrdenes C)
        {

            String Consulta = @"UPDATE clasificacionesordenes set estado = 1 where idClasificacionOrden = " + C.IdClasificacionOrden + ";";

            try
            {
                if (Db.Actualizar(Consulta) > 0)
                {
                    this.claO = C;
                }
                else
                {
                    this.claO = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return this.claO;
        }



    }
}
