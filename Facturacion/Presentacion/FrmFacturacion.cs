using Facturacion.Entidades;
using Facturacion.Datos;
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
	public partial class FrmFacturacion : Form
	{
		Factura nuevaFactura;
		AccesoDatos datos;
		public FrmFacturacion()
		{
			datos = new AccesoDatos();
			InitializeComponent();
			nuevaFactura = new Factura();

		}

		private void FrmFacturacion_Load(object sender, EventArgs e)
		{
			txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
			txtFecha.Enabled = false;
			txtCliente.Text = "CONSUMIDOR FINAL";
			txtCantidad.Text = "1";
			CargarCombo(cmbArticulo);
			CargarCombo(cmbFormaPago);
			lblNroFactura.Text = datos.ProximaFactura().ToString();
		}


		private void CargarCombo(ComboBox c)
		{
			DataTable table;
			string sp;

			if (c.Name == "cmbArticulo")
				sp = "SP_CONSULTAR_ARTICULOS";
			else
				sp = "SP_FORMAS_PAGOS";


			table = datos.CargarCombo(sp);
			c.DataSource = table;
			c.ValueMember = table.Columns[0].ColumnName;
			c.DisplayMember = table.Columns[1].ColumnName;


		}

		private void btnAgregar_Click(object sender, EventArgs e)
		{
			if (cmbArticulo.SelectedIndex == -1)
			{
				MessageBox.Show("Debe seleccionar un articulo", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			if (string.IsNullOrEmpty(txtCantidad.Text) || int.Parse(txtCantidad.Text) < 1)
			{
				MessageBox.Show("Debe ingresar una cantidad valida", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			DataGridViewRow filaExistente = null;
			foreach (DataGridViewRow fila in dgvDetalles.Rows)
			{
				if (fila.Cells["colArticulo"].Value.ToString().Equals(cmbArticulo.Text))
				{
					filaExistente = fila;
					break;
				}
			}

			if (filaExistente != null)
			{
				int cantidadActual = int.Parse(filaExistente.Cells["colCantidad"].Value.ToString());
				int nuevaCantidad = int.Parse(txtCantidad.Text);
				filaExistente.Cells["colCantidad"].Value = (cantidadActual + nuevaCantidad).ToString();

				DataRowView item = (DataRowView)cmbArticulo.SelectedItem;
				string articulo = item.Row.ItemArray[1].ToString();

				foreach (DetalleFactura d in nuevaFactura.Detalles)
				{
					if (d.Articulo.Nombre == articulo)
					{
						d.Cantidad = cantidadActual + nuevaCantidad;
						CalcularTotales();
						break;
					}
				}

			}
			else
			{
				try
				{
					DataRowView item = (DataRowView)cmbArticulo.SelectedItem;
					int id = Convert.ToInt32(item.Row.ItemArray[0]);
					string articulo = item.Row.ItemArray[1].ToString();
					double precio = Convert.ToDouble(item.Row.ItemArray[2]);
					Articulo a = new Articulo(id, articulo, precio);

					int cant = Convert.ToInt32(txtCantidad.Text);
					DetalleFactura df = new DetalleFactura(a, cant);

					nuevaFactura.AgregarDetalle(df);
					dgvDetalles.Rows.Add(df.Articulo.Id,
										 df.Articulo.Nombre,
										 df.Articulo.PrecioUnitario,
										 df.Cantidad);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error " + ex.ToString());
				}
			}
			CalcularTotales();
		}

		private void CalcularTotales()
		{
			txtSubtotal.Text = nuevaFactura.CalcularTotal().ToString();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			//Validar
			if (string.IsNullOrEmpty(txtCliente.Text))
			{
				MessageBox.Show("Ingresar un cliente");
				return;
			}
			if (dgvDetalles.Rows.Count == 0)
			{
				MessageBox.Show("Ingresar un articulo");
			}

			//Grabar la factura
			nuevaFactura.Fecha = Convert.ToDateTime(txtFecha.Text);
			nuevaFactura.Cliente = txtCliente.Text;
			FormaPago formaPago = new FormaPago();
			formaPago.IdFormaPago = int.Parse(cmbFormaPago.ValueMember.ToString());
			nuevaFactura.FormaPago = formaPago;

			datos.ConfirmarFactura(nuevaFactura);
			//FormaPago formaPago = new FormaPago();
			//formaPago.Nombre = cmbFormaPago.SelectedValue.ToString();
			//nuevaFactura.FormaPago = (FormaPago)cmbFormaPago.SelectedIndex;
			//COMO CARGO UNA FORMA DE PAGO A FACTURA SI EN BD ES INT
			//HACER UN SP QUE DEVUELVA EL ID DE ESE NOMBRE DE FORMA DE PAGO??
		}
	}
}

