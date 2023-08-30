namespace Facturacion.Presentacion
{
	partial class frmPrincipal
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			menuStrip1 = new MenuStrip();
			archivoToolStripMenuItem = new ToolStripMenuItem();
			salirToolStripMenuItem = new ToolStripMenuItem();
			soporteToolStripMenuItem = new ToolStripMenuItem();
			articulosToolStripMenuItem = new ToolStripMenuItem();
			consultarToolStripMenuItem1 = new ToolStripMenuItem();
			nuevoToolStripMenuItem1 = new ToolStripMenuItem();
			formasDePagoToolStripMenuItem = new ToolStripMenuItem();
			consultarToolStripMenuItem2 = new ToolStripMenuItem();
			nuevoToolStripMenuItem2 = new ToolStripMenuItem();
			facturasToolStripMenuItem = new ToolStripMenuItem();
			consultarToolStripMenuItem = new ToolStripMenuItem();
			nuevoToolStripMenuItem = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, soporteToolStripMenuItem, facturasToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(800, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
			archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			archivoToolStripMenuItem.Size = new Size(60, 20);
			archivoToolStripMenuItem.Text = "Archivo";
			// 
			// salirToolStripMenuItem
			// 
			salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			salirToolStripMenuItem.Size = new Size(96, 22);
			salirToolStripMenuItem.Text = "Salir";
			// 
			// soporteToolStripMenuItem
			// 
			soporteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { articulosToolStripMenuItem, formasDePagoToolStripMenuItem });
			soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
			soporteToolStripMenuItem.Size = new Size(60, 20);
			soporteToolStripMenuItem.Text = "Soporte";
			// 
			// articulosToolStripMenuItem
			// 
			articulosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarToolStripMenuItem1, nuevoToolStripMenuItem1 });
			articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
			articulosToolStripMenuItem.Size = new Size(180, 22);
			articulosToolStripMenuItem.Text = "Articulos";
			// 
			// consultarToolStripMenuItem1
			// 
			consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
			consultarToolStripMenuItem1.Size = new Size(180, 22);
			consultarToolStripMenuItem1.Text = "Consultar";
			// 
			// nuevoToolStripMenuItem1
			// 
			nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
			nuevoToolStripMenuItem1.Size = new Size(180, 22);
			nuevoToolStripMenuItem1.Text = "Nuevo";
			nuevoToolStripMenuItem1.Click += nuevoToolStripMenuItem1_Click;
			// 
			// formasDePagoToolStripMenuItem
			// 
			formasDePagoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarToolStripMenuItem2, nuevoToolStripMenuItem2 });
			formasDePagoToolStripMenuItem.Name = "formasDePagoToolStripMenuItem";
			formasDePagoToolStripMenuItem.Size = new Size(180, 22);
			formasDePagoToolStripMenuItem.Text = "Formas de Pago";
			// 
			// consultarToolStripMenuItem2
			// 
			consultarToolStripMenuItem2.Name = "consultarToolStripMenuItem2";
			consultarToolStripMenuItem2.Size = new Size(180, 22);
			consultarToolStripMenuItem2.Text = "Consultar";
			// 
			// nuevoToolStripMenuItem2
			// 
			nuevoToolStripMenuItem2.Name = "nuevoToolStripMenuItem2";
			nuevoToolStripMenuItem2.Size = new Size(180, 22);
			nuevoToolStripMenuItem2.Text = "Nuevo";
			nuevoToolStripMenuItem2.Click += nuevoToolStripMenuItem2_Click;
			// 
			// facturasToolStripMenuItem
			// 
			facturasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { consultarToolStripMenuItem, nuevoToolStripMenuItem });
			facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
			facturasToolStripMenuItem.Size = new Size(63, 20);
			facturasToolStripMenuItem.Text = "Facturas";
			// 
			// consultarToolStripMenuItem
			// 
			consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
			consultarToolStripMenuItem.Size = new Size(125, 22);
			consultarToolStripMenuItem.Text = "Consultar";
			// 
			// nuevoToolStripMenuItem
			// 
			nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
			nuevoToolStripMenuItem.Size = new Size(125, 22);
			nuevoToolStripMenuItem.Text = "Nuevo";
			nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
			// 
			// frmPrincipal
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "frmPrincipal";
			Text = "Principal";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem archivoToolStripMenuItem;
		private ToolStripMenuItem salirToolStripMenuItem;
		private ToolStripMenuItem soporteToolStripMenuItem;
		private ToolStripMenuItem articulosToolStripMenuItem;
		private ToolStripMenuItem consultarToolStripMenuItem1;
		private ToolStripMenuItem nuevoToolStripMenuItem1;
		private ToolStripMenuItem formasDePagoToolStripMenuItem;
		private ToolStripMenuItem consultarToolStripMenuItem2;
		private ToolStripMenuItem nuevoToolStripMenuItem2;
		private ToolStripMenuItem facturasToolStripMenuItem;
		private ToolStripMenuItem consultarToolStripMenuItem;
		private ToolStripMenuItem nuevoToolStripMenuItem;
	}
}