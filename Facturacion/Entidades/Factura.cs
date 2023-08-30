using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Entidades
{
	internal class Factura
	{
        public int NroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public FormaPago FormaPago { get; set; }
        public string Cliente { get; set; }
        public List<DetalleFactura> Detalles { get; set; }

        public Factura()
        {
            Detalles = new List<DetalleFactura>();
        }
        internal void AgregarDetalle(DetalleFactura detalle)
		{
			Detalles.Add(detalle);
		}
		public double CalcularTotal()
		{
			double total = 0;
			

			foreach (DetalleFactura d in Detalles)
			{
				total += d.CalcularSubtotal();
			}
			return total;
		}
	}
}
