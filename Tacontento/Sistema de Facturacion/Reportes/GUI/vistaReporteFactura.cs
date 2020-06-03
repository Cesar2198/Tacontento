using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes.GUI
{
    public partial class vistaReporteFactura : Form
    {
        private Entidades.Entidades.Pedidos.Pedidos pedidos;
        public  void Generar()
        {

            Decimal desc = 0.10m;
            Decimal incidente = CacheManager.CLS.Cache.getTotalIncidenteByPedido(this.pedidos.id);
            REP.factura oReporte = new REP.factura();
            oReporte.SetDataSource(CacheManager.CLS.Cache.Facturar(this.pedidos.id));

          
            oReporte.SetParameterValue("pidfactura", this.pedidos.id);
            oReporte.SetParameterValue("pcliente", this.pedidos.nombreCliente);
            oReporte.SetParameterValue("pfecha", this.pedidos.fecha);
            oReporte.SetParameterValue("ptipopago", this.pedidos.tipoPago == 1 ? "EFECTIVO" : "TARJETA");
            //oReporte.SetParameterValue("psubtotal", this.pedidos.total);
            oReporte.SetParameterValue("psubtotal", this.pedidos.tipoPago == 1 ? this.pedidos.total : (this.pedidos.total = (this.pedidos.total/1.10m)));
            oReporte.SetParameterValue("pincidencia", incidente);
            oReporte.SetParameterValue("ppropina", this.pedidos.tipoPago == 1 ? 0.00m : (this.pedidos.total*desc));
            oReporte.SetParameterValue("ptotalpagar", this.pedidos.tipoPago == 1 ? (this.pedidos.total + incidente) : ((this.pedidos.total * desc) + this.pedidos.total) + incidente);
            crpFactura.ReportSource = oReporte;

        }
        public vistaReporteFactura(Entidades.Entidades.Pedidos.Pedidos p)
        {
            pedidos = p;
            InitializeComponent();
            Generar();
        }
    }
}
