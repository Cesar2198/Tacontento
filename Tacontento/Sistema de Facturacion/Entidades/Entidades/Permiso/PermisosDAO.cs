using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.Permiso
{
    public class PermisosDAO
    {
        private DataManager.CLS.DBOperacion Db;
        private Permisos P;
        private List<Permisos> Listado;

        public PermisosDAO()
        {
            Db = new DataManager.CLS.DBOperacion();
            P = new Permisos();
            Listado = new List<Permisos>();
        }

        public Permisos InsertarPermiso(Permisos _Permiso)
        {
            string Consulta = @"insert into permisos(idRol, idOpcion)
                                values("+_Permiso.idRol+","+_Permiso.idOpcion+");";

            try
            {   /// Se comprueba qque se inserto o no
                if ((Db.Insertar(Consulta)) > 0)
                {
                    P = _Permiso;
                }
                else
                {
                    P = null;
                }

            }
            catch (Exception ex)
            {   /// Si hubo un error de conexion a la base de datos que me devuelva siempre nulo
                Console.WriteLine(ex);
                P = null;
                throw;
            }

            return P;
        }

        public Permisos Modificar(Permisos p)
        {

            String Consulta = @"update permisos SET idRol = "+p.idRol+ ", idOpcion = "+p.idOpcion+"" +
                " where idPermiso = "+p.idPermiso+";";

            try
            {
                if (Db.Actualizar(Consulta) > 0)
                {
                    this.P = p;
                }
                else
                {
                    this.P = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return this.P;
        }

        public Permisos Eliminar(Permisos f)
        {
            string Consulta = "DELETE from permisos where idPermiso= " + f.idPermiso + ";";

            try
            {
                if (Db.Eliminar(Consulta) > 0)
                {
                    this.P = f;
                }
                else
                {
                    this.P = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return this.P;
        }
    }
}
