using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Entidades
{
	internal class DetalleFactura
	{
		public Articulo Articulo { get; set; }
		public int Cantidad { get; set; }

		public DetalleFactura(Articulo a, int cantidad)
		{
			Articulo = a;
			Cantidad = cantidad;
		}

		public double CalcularSubtotal()
		{
			return Cantidad * Articulo.PrecioUnitario;
		}


	}
}
