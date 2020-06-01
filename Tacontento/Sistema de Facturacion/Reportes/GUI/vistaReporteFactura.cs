using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            REP.factura oReporte = new REP.factura();
            oReporte.SetDataSource(CacheManager.CLS.Cache.Facturar(1));
            oReporte.SetParameterValue("pidfactura", this.pedidos.id);
            oReporte.SetParameterValue("pcliente", this.pedidos.nombreCliente);
            oReporte.SetParameterValue("pfecha", this.pedidos.fecha);
            oReporte.SetParameterValue("ptipopago", this.pedidos.tipoPago == 1 ? "EFECTIVO" : "TARJETA");
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
