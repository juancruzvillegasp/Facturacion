using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturacion.Entidades
{
	internal class Articulo
	{
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double PrecioUnitario { get; set; }

        public Articulo(int id, string nombre, double precio)
        {
            Id = id;
            Nombre = nombre;
            PrecioUnitario = precio;
        }
    }
}
