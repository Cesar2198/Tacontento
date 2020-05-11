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

        public Incidente getIncidenteByPedido(int id)
        {
            Incidente incidente = new Incidente();
            string sql = "select * from incidentes where idpedido = " + id;
            DataTable Elemento = new DataTable();
            try
            {
                if (Db.Consultar(sql) != null)
                {
                    Elemento = Db.Consultar(sql);
                    incidente.IdIncidente = (int)Elemento.Rows[0]["idIncidente"];
                    incidente.Descripcion = Elemento.Rows[0]["descripcion"].ToString();
                    incidente.Precio = Decimal.Parse(Elemento.Rows[0]["precio"].ToString());
                    incidente.Pedido = id;
                }
            }
            catch (Exception e)
            {

            }
            return incidente.Equals(null) ? null : incidente;
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
