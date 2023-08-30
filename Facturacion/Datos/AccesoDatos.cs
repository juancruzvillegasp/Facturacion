using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facturacion.Entidades;

namespace Facturacion.Datos
{
	public class AccesoDatos
	{
		private SqlConnection conexion;

		public AccesoDatos()
		{
			conexion = new SqlConnection(@"Data Source=DESKTOP-M7GK9KO\SQLEXPRESS;Initial Catalog=Facturacion;Integrated Security=True");
		}

		public int ProximaFactura()
		{
			conexion.Open();

			SqlCommand comando = new SqlCommand();
			comando.Connection = conexion;
			comando.CommandType = CommandType.StoredProcedure;
			comando.CommandText = "SP_PROXIMA_FACTURA";

			SqlParameter parametro = new SqlParameter();
			parametro.ParameterName = "@proximo";
			parametro.SqlDbType = SqlDbType.Int;
			parametro.Direction = ParameterDirection.Output;

			comando.Parameters.Add(parametro);
			comando.ExecuteNonQuery();
			conexion.Close();

			return int.Parse(parametro.Value.ToString());
		}

		public DataTable CargarCombo(string sp)
		{
			SqlCommand comando = new SqlCommand();

			conexion.Open();
			comando.Connection = conexion;
			comando.CommandType = CommandType.StoredProcedure;
			comando.CommandText = sp;

			DataTable table = new DataTable();
			table.Load(comando.ExecuteReader());
			conexion.Close();

			return table;

		}

		internal void ConfirmarFactura(Factura nuevaFactura)
		{
			throw new NotImplementedException();
		}
	}
}
