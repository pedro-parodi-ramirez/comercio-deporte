/*
 * Created by SharpDevelop.
 * User: PETER
 * Date: 09/12/2018
 * Time: 17:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TiendaOnline
{
	partial class AgregarProductoForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelTipo;
		private System.Windows.Forms.Label labelMarca;
		private System.Windows.Forms.Label labelTalle;
		private System.Windows.Forms.Label labelPrecio;
		private System.Windows.Forms.TextBox textBoxTipo;
		private System.Windows.Forms.TextBox textBoxMarca;
		private System.Windows.Forms.TextBox textBoxPrecio;
		private System.Windows.Forms.TextBox textBoxTalle;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.Button btnCancelar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelTipo = new System.Windows.Forms.Label();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.textBoxPrecio = new System.Windows.Forms.TextBox();
			this.labelPrecio = new System.Windows.Forms.Label();
			this.labelTalle = new System.Windows.Forms.Label();
			this.textBoxTalle = new System.Windows.Forms.TextBox();
			this.textBoxMarca = new System.Windows.Forms.TextBox();
			this.labelMarca = new System.Windows.Forms.Label();
			this.textBoxTipo = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(298, 62);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ingrese datos del Producto:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.labelTipo, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnAgregar, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.textBoxPrecio, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.labelPrecio, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.labelTalle, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.textBoxTalle, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.textBoxMarca, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelMarca, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxTipo, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 0, 9);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 62);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 10;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(298, 333);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// labelTipo
			// 
			this.labelTipo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTipo.Location = new System.Drawing.Point(3, 0);
			this.labelTipo.Name = "labelTipo";
			this.labelTipo.Size = new System.Drawing.Size(292, 33);
			this.labelTipo.TabIndex = 0;
			this.labelTipo.Text = "Tipo: ";
			this.labelTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAgregar
			// 
			this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnAgregar.Enabled = false;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(84, 267);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(130, 27);
			this.btnAgregar.TabIndex = 9;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// textBoxPrecio
			// 
			this.textBoxPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxPrecio.Enabled = false;
			this.textBoxPrecio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPrecio.Location = new System.Drawing.Point(3, 234);
			this.textBoxPrecio.Name = "textBoxPrecio";
			this.textBoxPrecio.Size = new System.Drawing.Size(292, 22);
			this.textBoxPrecio.TabIndex = 7;
			this.textBoxPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxPrecio.TextChanged += new System.EventHandler(this.TextBoxPrecioTextChanged);
			// 
			// labelPrecio
			// 
			this.labelPrecio.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPrecio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPrecio.Location = new System.Drawing.Point(3, 198);
			this.labelPrecio.Name = "labelPrecio";
			this.labelPrecio.Size = new System.Drawing.Size(292, 33);
			this.labelPrecio.TabIndex = 3;
			this.labelPrecio.Text = "Precio: ";
			this.labelPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelTalle
			// 
			this.labelTalle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTalle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTalle.Location = new System.Drawing.Point(3, 132);
			this.labelTalle.Name = "labelTalle";
			this.labelTalle.Size = new System.Drawing.Size(292, 33);
			this.labelTalle.TabIndex = 2;
			this.labelTalle.Text = "Talle: ";
			this.labelTalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxTalle
			// 
			this.textBoxTalle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxTalle.Enabled = false;
			this.textBoxTalle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTalle.Location = new System.Drawing.Point(3, 168);
			this.textBoxTalle.Name = "textBoxTalle";
			this.textBoxTalle.Size = new System.Drawing.Size(292, 22);
			this.textBoxTalle.TabIndex = 6;
			this.textBoxTalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxTalle.TextChanged += new System.EventHandler(this.TextBoxTalleTextChanged);
			// 
			// textBoxMarca
			// 
			this.textBoxMarca.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxMarca.Enabled = false;
			this.textBoxMarca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxMarca.Location = new System.Drawing.Point(3, 102);
			this.textBoxMarca.Name = "textBoxMarca";
			this.textBoxMarca.Size = new System.Drawing.Size(292, 22);
			this.textBoxMarca.TabIndex = 5;
			this.textBoxMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxMarca.TextChanged += new System.EventHandler(this.TextBoxMarcaTextChanged);
			// 
			// labelMarca
			// 
			this.labelMarca.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelMarca.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMarca.Location = new System.Drawing.Point(3, 66);
			this.labelMarca.Name = "labelMarca";
			this.labelMarca.Size = new System.Drawing.Size(292, 33);
			this.labelMarca.TabIndex = 1;
			this.labelMarca.Text = "Marca: ";
			this.labelMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxTipo
			// 
			this.textBoxTipo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxTipo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxTipo.Location = new System.Drawing.Point(3, 36);
			this.textBoxTipo.Name = "textBoxTipo";
			this.textBoxTipo.Size = new System.Drawing.Size(292, 22);
			this.textBoxTipo.TabIndex = 4;
			this.textBoxTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxTipo.TextChanged += new System.EventHandler(this.TextBoxTipoTextChanged);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(84, 300);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(130, 30);
			this.btnCancelar.TabIndex = 10;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// AgregarProductoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(298, 395);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.label1);
			this.Name = "AgregarProductoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar Producto";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AgregarProductoFormFormClosed);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
