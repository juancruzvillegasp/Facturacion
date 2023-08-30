namespace Facturacion.Presentacion
{
	partial class FrmFacturacion
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
			label1 = new Label();
			label2 = new Label();
			txtFecha = new TextBox();
			label3 = new Label();
			cmbFormaPago = new ComboBox();
			label4 = new Label();
			txtCliente = new TextBox();
			label5 = new Label();
			cmbArticulo = new ComboBox();
			label6 = new Label();
			txtCantidad = new TextBox();
			btnAgregar = new Button();
			dgvDetalles = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			colArticulo = new DataGridViewTextBoxColumn();
			colPrecio = new DataGridViewTextBoxColumn();
			colCantidad = new DataGridViewTextBoxColumn();
			txtSubtotal = new TextBox();
			label7 = new Label();
			btnAceptar = new Button();
			btnCancelar = new Button();
			lblNroFactura = new Label();
			((System.ComponentModel.ISupportInitialize)dgvDetalles).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(13, 13);
			label1.Name = "label1";
			label1.Size = new Size(63, 15);
			label1.TabIndex = 0;
			label1.Text = "Factura N°";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(62, 44);
			label2.Name = "label2";
			label2.Size = new Size(38, 15);
			label2.TabIndex = 1;
			label2.Text = "Fecha";
			// 
			// txtFecha
			// 
			txtFecha.Location = new Point(106, 36);
			txtFecha.Name = "txtFecha";
			txtFecha.Size = new Size(170, 23);
			txtFecha.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(13, 68);
			label3.Name = "label3";
			label3.Size = new Size(87, 15);
			label3.TabIndex = 3;
			label3.Text = "Forma de Pago";
			// 
			// cmbFormaPago
			// 
			cmbFormaPago.FormattingEnabled = true;
			cmbFormaPago.Location = new Point(106, 65);
			cmbFormaPago.Name = "cmbFormaPago";
			cmbFormaPago.Size = new Size(170, 23);
			cmbFormaPago.TabIndex = 4;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(56, 96);
			label4.Name = "label4";
			label4.Size = new Size(44, 15);
			label4.TabIndex = 5;
			label4.Text = "Cliente";
			// 
			// txtCliente
			// 
			txtCliente.Location = new Point(106, 93);
			txtCliente.Name = "txtCliente";
			txtCliente.Size = new Size(170, 23);
			txtCliente.TabIndex = 6;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(13, 123);
			label5.Name = "label5";
			label5.Size = new Size(49, 15);
			label5.TabIndex = 7;
			label5.Text = "Articulo";
			// 
			// cmbArticulo
			// 
			cmbArticulo.FormattingEnabled = true;
			cmbArticulo.Location = new Point(13, 141);
			cmbArticulo.Name = "cmbArticulo";
			cmbArticulo.Size = new Size(263, 23);
			cmbArticulo.TabIndex = 8;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(278, 123);
			label6.Name = "label6";
			label6.Size = new Size(55, 15);
			label6.TabIndex = 9;
			label6.Text = "Cantidad";
			// 
			// txtCantidad
			// 
			txtCantidad.Location = new Point(278, 141);
			txtCantidad.Name = "txtCantidad";
			txtCantidad.Size = new Size(100, 23);
			txtCantidad.TabIndex = 10;
			// 
			// btnAgregar
			// 
			btnAgregar.Location = new Point(384, 140);
			btnAgregar.Name = "btnAgregar";
			btnAgregar.Size = new Size(75, 23);
			btnAgregar.TabIndex = 11;
			btnAgregar.Text = "Agregar";
			btnAgregar.UseVisualStyleBackColor = true;
			btnAgregar.Click += btnAgregar_Click;
			// 
			// dgvDetalles
			// 
			dgvDetalles.AllowUserToAddRows = false;
			dgvDetalles.AllowUserToDeleteRows = false;
			dgvDetalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDetalles.Columns.AddRange(new DataGridViewColumn[] { Id, colArticulo, colPrecio, colCantidad });
			dgvDetalles.Location = new Point(16, 175);
			dgvDetalles.Name = "dgvDetalles";
			dgvDetalles.ReadOnly = true;
			dgvDetalles.RowTemplate.Height = 25;
			dgvDetalles.Size = new Size(362, 121);
			dgvDetalles.TabIndex = 12;
			// 
			// Id
			// 
			Id.HeaderText = "Id";
			Id.Name = "Id";
			Id.ReadOnly = true;
			Id.Visible = false;
			// 
			// colArticulo
			// 
			colArticulo.HeaderText = "Articulo";
			colArticulo.Name = "colArticulo";
			colArticulo.ReadOnly = true;
			colArticulo.Width = 120;
			// 
			// colPrecio
			// 
			colPrecio.HeaderText = "Precio";
			colPrecio.Name = "colPrecio";
			colPrecio.ReadOnly = true;
			// 
			// colCantidad
			// 
			colCantidad.HeaderText = "Cantidad";
			colCantidad.Name = "colCantidad";
			colCantidad.ReadOnly = true;
			// 
			// txtSubtotal
			// 
			txtSubtotal.Location = new Point(278, 302);
			txtSubtotal.Name = "txtSubtotal";
			txtSubtotal.Size = new Size(100, 23);
			txtSubtotal.TabIndex = 13;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(231, 305);
			label7.Name = "label7";
			label7.Size = new Size(41, 15);
			label7.TabIndex = 15;
			label7.Text = "Total $";
			// 
			// btnAceptar
			// 
			btnAceptar.Location = new Point(127, 336);
			btnAceptar.Name = "btnAceptar";
			btnAceptar.Size = new Size(75, 23);
			btnAceptar.TabIndex = 17;
			btnAceptar.Text = "Aceptar";
			btnAceptar.UseVisualStyleBackColor = true;
			btnAceptar.Click += btnAceptar_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(236, 336);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(75, 23);
			btnCancelar.TabIndex = 18;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			// 
			// lblNroFactura
			// 
			lblNroFactura.AutoSize = true;
			lblNroFactura.Location = new Point(82, 13);
			lblNroFactura.Name = "lblNroFactura";
			lblNroFactura.Size = new Size(0, 15);
			lblNroFactura.TabIndex = 19;
			// 
			// FrmFacturacion
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(462, 364);
			Controls.Add(lblNroFactura);
			Controls.Add(btnCancelar);
			Controls.Add(btnAceptar);
			Controls.Add(label7);
			Controls.Add(txtSubtotal);
			Controls.Add(dgvDetalles);
			Controls.Add(btnAgregar);
			Controls.Add(txtCantidad);
			Controls.Add(label6);
			Controls.Add(cmbArticulo);
			Controls.Add(label5);
			Controls.Add(txtCliente);
			Controls.Add(label4);
			Controls.Add(cmbFormaPago);
			Controls.Add(label3);
			Controls.Add(txtFecha);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "FrmFacturacion";
			Text = "FrmFacturacion";
			Load += FrmFacturacion_Load;
			((System.ComponentModel.ISupportInitialize)dgvDetalles).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtFecha;
		private Label label3;
		private ComboBox cmbFormaPago;
		private Label label4;
		private TextBox txtCliente;
		private Label label5;
		private ComboBox cmbArticulo;
		private Label label6;
		private TextBox txtCantidad;
		private Button btnAgregar;
		private DataGridView dgvDetalles;
		private TextBox txtSubtotal;
		private Label label7;
		private Button btnAceptar;
		private Button btnCancelar;
		private Label lblNroFactura;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn colArticulo;
		private DataGridViewTextBoxColumn colPrecio;
		private DataGridViewTextBoxColumn colCantidad;
	}
}