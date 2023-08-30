namespace Facturacion.Presentacion
{
	partial class FrmNuevoArticulo
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
			txtNombreArticulo = new TextBox();
			label3 = new Label();
			txtPrecioArticulo = new TextBox();
			btnGuardar = new Button();
			btnCancelar = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(14, 9);
			label1.Name = "label1";
			label1.Size = new Size(85, 15);
			label1.TabIndex = 0;
			label1.Text = "Nuevo articulo";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(14, 36);
			label2.Name = "label2";
			label2.Size = new Size(54, 15);
			label2.TabIndex = 1;
			label2.Text = "Nombre:";
			// 
			// txtNombreArticulo
			// 
			txtNombreArticulo.Location = new Point(74, 33);
			txtNombreArticulo.Name = "txtNombreArticulo";
			txtNombreArticulo.Size = new Size(133, 23);
			txtNombreArticulo.TabIndex = 2;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(14, 61);
			label3.Name = "label3";
			label3.Size = new Size(87, 15);
			label3.TabIndex = 3;
			label3.Text = "Precio unitario:";
			// 
			// txtPrecioArticulo
			// 
			txtPrecioArticulo.Location = new Point(107, 58);
			txtPrecioArticulo.Name = "txtPrecioArticulo";
			txtPrecioArticulo.Size = new Size(100, 23);
			txtPrecioArticulo.TabIndex = 4;
			// 
			// btnGuardar
			// 
			btnGuardar.Location = new Point(51, 96);
			btnGuardar.Name = "btnGuardar";
			btnGuardar.Size = new Size(75, 23);
			btnGuardar.TabIndex = 5;
			btnGuardar.Text = "Guardar";
			btnGuardar.UseVisualStyleBackColor = true;
			btnGuardar.Click += btnGuardar_Click;
			// 
			// btnCancelar
			// 
			btnCancelar.Location = new Point(132, 96);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(75, 23);
			btnCancelar.TabIndex = 6;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = true;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// FrmNuevoArticulo
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(237, 133);
			Controls.Add(btnCancelar);
			Controls.Add(btnGuardar);
			Controls.Add(txtPrecioArticulo);
			Controls.Add(label3);
			Controls.Add(txtNombreArticulo);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "FrmNuevoArticulo";
			Text = "Nuevo articulo";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox txtNombreArticulo;
		private Label label3;
		private TextBox txtPrecioArticulo;
		private Button btnGuardar;
		private Button btnCancelar;
	}
}