using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.Permisos
{
     public class OpcionDAO
    {
        private DataManager.CLS.DBOperacion Db;
        private Opcion P;
        private List<Opcion> Listado;

        public OpcionDAO()
        {
            Db = new DataManager.CLS.DBOperacion();
            P = new Opcion();
            Listado = new List<Opcion>();
        }

        public List<Opcion> getOpcion()
        {
            DataTable Elemento = new DataTable();
            String Consulta = @"SELECT idOpcion, opcion, idClasificacion FROM opciones;";
            List<Opcion> list = new List<Opcion>();
            try
            {
                if (Db.Consultar(Consulta) != null)
                {
                    Elemento = Db.Consultar(Consulta);

                    for (int i = 0; i < Elemento.Rows.Count; i++)
                    {
                        Opcion _P = new Opcion();

                        _P.idOpcion = (int)Elemento.Rows[i]["idOpcion"];
                        _P.NombreOpcion = Elemento.Rows[i]["opcion"].ToString();
                        _P.idClasificacion = (int)Elemento.Rows[i]["idClasificacion"];
                        list.Add(_P);
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
        public Opcion ObtenerOpcionByName(string _id)
        {
            DataTable Elemento = new DataTable();

            String Consulta = @"SELECT idOpcion, opcion, idClasificacion FROM opciones where opcion = '" + _id + "';";

            try
            {
                if (Db.Consultar(Consulta) != null)
                {
                    Elemento = Db.Consultar(Consulta);

                    for (int i = 0; i < Elemento.Rows.Count; i++)
                    {


                        P.idOpcion = int.Parse(Elemento.Rows[0]["idOpcion"].ToString());
                        P.NombreOpcion = Elemento.Rows[0]["opcion"].ToString();
                        P.idClasificacion = int.Parse(Elemento.Rows[0]["idClasificacion"].ToString());


                    }
                }
                else
                {
                    P = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return P;
        }


    }
}
