using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades.Incidentes
{
    public class IncidenteDao
    {
        private DataManager.CLS.DBOperacion Db;

        public IncidenteDao()
        {
            Db = new DataManager.CLS.DBOperacion();
        }

        public List<Incidente> getIncidentesByPedido(int id)
        {
            List<Incidente> list = new List<Incidente>();
            string sql = "select * from incidentes where idpedido = " + id;
            DataTable Elemento = new DataTable();
            try
            {
                if (Db.Consultar(sql) != null)
                {
                    Elemento = Db.Consultar(sql);
                    for (int i = 0; i < Elemento.Rows.Count; i++)
                    {
                        Incidente incidente = new Incidente();
                        incidente.IdIncidente = (int)Elemento.Rows[i]["idIncidente"];
                        incidente.Descripcion = Elemento.Rows[i]["descripcion"].ToString();
                        incidente.Precio = Decimal.Parse(Elemento.Rows[i]["precio"].ToString());
                        incidente.Pedido = id;
                        list.Add(incidente);
                    }
                    
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return list.Equals(null) ? null : list;
        }

        public Boolean insertarIncidente(Incidente inc)
        {
            bool ok = false;
            string sql = @"insert into incidentes(descripcion,precio,idPedido) values" +
                "('" + inc.Descripcion + "', " + inc.Precio + ", " + inc.Pedido + ")";
            try
            {
                if (Db.Insertar(sql) > 0)
                {
                    ok = true;
                }
            }
            catch (Exception e)
            {
                
            }
            return ok;
        }
    }
}
