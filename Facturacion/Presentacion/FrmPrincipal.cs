using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion.Presentacion
{
	public partial class frmPrincipal : Form
	{
		public frmPrincipal()
		{
			InitializeComponent();
		}

		private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FrmFacturacion frmFacturacion = new FrmFacturacion();
			frmFacturacion.ShowDialog();
		}

		private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			FrmNuevoArticulo frmNuevo = new FrmNuevoArticulo();
			frmNuevo.ShowDialog();
		}

		private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
		{

		}
	}
}
