using Facturacion.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion.Presentacion
{
	public partial class FrmNuevoArticulo : Form
	{
		public FrmNuevoArticulo()
		{
			InitializeComponent();
		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				string cadenaConexion = @"Data Source=DESKTOP-M7GK9KO\SQLEXPRESS;Initial Catalog=Facturacion;Integrated Security=True";
				SqlConnection conexion = new SqlConnection(cadenaConexion);
				SqlCommand comando = new SqlCommand();
				comando.Connection = conexion;
				conexion.Open();

				comando.CommandText = "SP_AGREGAR_ARTICULO";
				comando.CommandType = CommandType.StoredProcedure;

				comando.Parameters.AddWithValue("@nombre", txtNombreArticulo.Text);
				comando.Parameters.AddWithValue("@precio", txtPrecioArticulo.Text);

				comando.ExecuteNonQuery();
				conexion.Close();
				MessageBox.Show("Se guardo con exito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
