/*
 * Created by SharpDevelop.
 * User: PETER
 * Date: 10/12/2018
 * Time: 13:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TiendaOnline
{
	partial class AgregarProdCarroForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel layoutAgregarProdCarro;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.Label labelCantProdCarro;
		private System.Windows.Forms.TextBox textBoxCantidad;
		private System.Windows.Forms.Button btnAgregarProdCarro;
		private System.Windows.Forms.Label labelSelectProd;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		
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
			this.layoutAgregarProdCarro = new System.Windows.Forms.TableLayoutPanel();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.labelCantProdCarro = new System.Windows.Forms.Label();
			this.textBoxCantidad = new System.Windows.Forms.TextBox();
			this.btnAgregarProdCarro = new System.Windows.Forms.Button();
			this.labelSelectProd = new System.Windows.Forms.Label();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.layoutAgregarProdCarro.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutAgregarProdCarro
			// 
			this.layoutAgregarProdCarro.ColumnCount = 1;
			this.layoutAgregarProdCarro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutAgregarProdCarro.Controls.Add(this.labelTitulo, 0, 2);
			this.layoutAgregarProdCarro.Controls.Add(this.labelCantProdCarro, 0, 3);
			this.layoutAgregarProdCarro.Controls.Add(this.textBoxCantidad, 0, 4);
			this.layoutAgregarProdCarro.Controls.Add(this.btnAgregarProdCarro, 0, 5);
			this.layoutAgregarProdCarro.Controls.Add(this.labelSelectProd, 0, 0);
			this.layoutAgregarProdCarro.Controls.Add(this.btnCancelar, 0, 6);
			this.layoutAgregarProdCarro.Controls.Add(this.dataGridView1, 0, 1);
			this.layoutAgregarProdCarro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutAgregarProdCarro.Location = new System.Drawing.Point(0, 0);
			this.layoutAgregarProdCarro.Name = "layoutAgregarProdCarro";
			this.layoutAgregarProdCarro.RowCount = 7;
			this.layoutAgregarProdCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
			this.layoutAgregarProdCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.71429F));
			this.layoutAgregarProdCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.90476F));
			this.layoutAgregarProdCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
			this.layoutAgregarProdCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.523809F));
			this.layoutAgregarProdCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
			this.layoutAgregarProdCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
			this.layoutAgregarProdCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutAgregarProdCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutAgregarProdCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutAgregarProdCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutAgregarProdCarro.Size = new System.Drawing.Size(683, 539);
			this.layoutAgregarProdCarro.TabIndex = 0;
			// 
			// labelTitulo
			// 
			this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitulo.Location = new System.Drawing.Point(3, 256);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(677, 64);
			this.labelTitulo.TabIndex = 0;
			this.labelTitulo.Text = "Seleccione un producto de la lista y complete:";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// labelCantProdCarro
			// 
			this.labelCantProdCarro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCantProdCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCantProdCarro.Location = new System.Drawing.Point(3, 320);
			this.labelCantProdCarro.Name = "labelCantProdCarro";
			this.labelCantProdCarro.Size = new System.Drawing.Size(677, 51);
			this.labelCantProdCarro.TabIndex = 2;
			this.labelCantProdCarro.Text = "Cantidad:";
			this.labelCantProdCarro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// textBoxCantidad
			// 
			this.textBoxCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.textBoxCantidad.Location = new System.Drawing.Point(279, 374);
			this.textBoxCantidad.Name = "textBoxCantidad";
			this.textBoxCantidad.Size = new System.Drawing.Size(125, 20);
			this.textBoxCantidad.TabIndex = 4;
			this.textBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnAgregarProdCarro
			// 
			this.btnAgregarProdCarro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnAgregarProdCarro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarProdCarro.Location = new System.Drawing.Point(266, 425);
			this.btnAgregarProdCarro.Name = "btnAgregarProdCarro";
			this.btnAgregarProdCarro.Size = new System.Drawing.Size(150, 51);
			this.btnAgregarProdCarro.TabIndex = 5;
			this.btnAgregarProdCarro.Text = "Agregar Producto";
			this.btnAgregarProdCarro.UseVisualStyleBackColor = true;
			this.btnAgregarProdCarro.Click += new System.EventHandler(this.BtnAgregarProdCarroClick);
			// 
			// labelSelectProd
			// 
			this.labelSelectProd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSelectProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSelectProd.Location = new System.Drawing.Point(3, 0);
			this.labelSelectProd.Name = "labelSelectProd";
			this.labelSelectProd.Size = new System.Drawing.Size(677, 64);
			this.labelSelectProd.TabIndex = 6;
			this.labelSelectProd.Text = "Productos disponibles:";
			this.labelSelectProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(266, 482);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(150, 54);
			this.btnCancelar.TabIndex = 8;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column1,
			this.Column2,
			this.Column3,
			this.Column4,
			this.Column5});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 67);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(677, 186);
			this.dataGridView1.TabIndex = 9;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.HeaderText = "Tipo";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText = "Marca";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText = "Talle";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column4.HeaderText = "Precio";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column5.HeaderText = "Descuento";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// AgregarProdCarroForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(683, 539);
			this.Controls.Add(this.layoutAgregarProdCarro);
			this.Name = "AgregarProdCarroForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar Producto al Carro";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AgregarProdCarroFormFormClosed);
			this.layoutAgregarProdCarro.ResumeLayout(false);
			this.layoutAgregarProdCarro.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
