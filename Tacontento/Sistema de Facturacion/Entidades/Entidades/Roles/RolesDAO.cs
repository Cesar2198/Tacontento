using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.Roles
{
    public class RolesDAO
    {
        private DataManager.CLS.DBOperacion Db;
        private Rol R;
        private List<Rol> Listado;

        public RolesDAO()
        {
            Db = new DataManager.CLS.DBOperacion();
            R = new Rol();
            Listado = new List<Rol>();
        }

        public List<Rol> getRol()
        {
            DataTable Elemento = new DataTable();
            String Consulta = @"select idRol, nombre, descripcion from roles";
            List<Rol> list = new List<Rol>();

            try
            {
                if (Db.Consultar(Consulta) != null)
                {
                    Elemento = Db.Consultar(Consulta);

                    for (int i = 0; i < Elemento.Rows.Count; i++)
                    {
                        Rol _R = new Rol();

                        _R.idRol = (int)Elemento.Rows[i]["idRol"];
                        _R.RolName = Elemento.Rows[i]["nombre"].ToString();
                        _R.Descripcion = Elemento.Rows[i]["descripcion"].ToString();


                        list.Add(_R);
                    }
                }
                else
                {
                    list = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return list;
        }

        public Rol ObtenerRolById(int _id)
        {
            DataTable Elemento = new DataTable();

            String Consulta = @"select idRol, nombre, descripcion from roles where idRol = "+_id+";";

            try
            {
                if (Db.Consultar(Consulta) != null)
                {
                    Elemento = Db.Consultar(Consulta);

                    for (int i = 0; i < Elemento.Rows.Count; i++)
                    {
                        

                        R.idRol = int.Parse(Elemento.Rows[0]["idRol"].ToString());
                        R.RolName = Elemento.Rows[0]["nombre"].ToString();
                        R.Descripcion = Elemento.Rows[0]["nombre"].ToString();


                    }
                }
                else
                {
                    R = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return R;
        }


        public Rol InsertarRol(Rol _rol)
        {
            string Consulta = @"insert into roles(nombre, descripcion, estado) 
            values('" + _rol.RolName + "','" + _rol.Descripcion + "'," + _rol.estado + ");";

            try
            {   /// Se comprueba qque se inserto o no
                if ((Db.Insertar(Consulta)) > 0)
                {
                    R = _rol;
                }
                else
                {
                    R = null;
                }

            }
            catch (Exception ex)
            {   /// Si hubo un error de conexion a la base de datos que me devuelva siempre nulo
                Console.WriteLine(ex);
                R = null;
                throw;
            }

            return R;
        }

        public Rol Modificar(Rol _rol)
        {
            String Consulta = @"update roles SET nombre= '"+_rol.RolName+"', descripcion = '"+_rol.Descripcion+"',estado = "+_rol.estado+" where idRol = "+_rol.idRol+";";

            try
            {
                if (Db.Actualizar(Consulta) > 0)
                {
                    this.R = _rol;
                }
                else
                {
                    this.R = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
            return this.R;
        }


    }
}
