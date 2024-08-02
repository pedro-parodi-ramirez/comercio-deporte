/*
 * Created by SharpDevelop.
 * User: PETER
 * Date: 09/12/2018
 * Time: 18:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TiendaOnline
{
	partial class PromocionarProductoForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelDescActual;
		private System.Windows.Forms.Label labelNuevoDescuento;
		private System.Windows.Forms.TextBox textBoxValorDesc;
		private System.Windows.Forms.Button buttPromocionar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label labelProdSeleccionado;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDescuentos;
		private System.Windows.Forms.Label labelValorDescActual;
		
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
			this.btnCancelar = new System.Windows.Forms.Button();
			this.buttPromocionar = new System.Windows.Forms.Button();
			this.textBoxValorDesc = new System.Windows.Forms.TextBox();
			this.labelNuevoDescuento = new System.Windows.Forms.Label();
			this.labelProdSeleccionado = new System.Windows.Forms.Label();
			this.labelDescActual = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanelDescuentos = new System.Windows.Forms.TableLayoutPanel();
			this.labelValorDescActual = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tableLayoutPanelDescuentos.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(265, 343);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(148, 94);
			this.btnCancelar.TabIndex = 7;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// buttPromocionar
			// 
			this.buttPromocionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.buttPromocionar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttPromocionar.Location = new System.Drawing.Point(265, 246);
			this.buttPromocionar.Name = "buttPromocionar";
			this.buttPromocionar.Size = new System.Drawing.Size(148, 91);
			this.buttPromocionar.TabIndex = 4;
			this.buttPromocionar.Text = "Agregar Descuento";
			this.buttPromocionar.UseVisualStyleBackColor = true;
			this.buttPromocionar.Click += new System.EventHandler(this.ButtPromocionarClick);
			// 
			// textBoxValorDesc
			// 
			this.textBoxValorDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.textBoxValorDesc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxValorDesc.Location = new System.Drawing.Point(339, 55);
			this.textBoxValorDesc.Name = "textBoxValorDesc";
			this.textBoxValorDesc.Size = new System.Drawing.Size(330, 22);
			this.textBoxValorDesc.TabIndex = 2;
			this.textBoxValorDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelNuevoDescuento
			// 
			this.labelNuevoDescuento.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNuevoDescuento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNuevoDescuento.Location = new System.Drawing.Point(3, 40);
			this.labelNuevoDescuento.Name = "labelNuevoDescuento";
			this.labelNuevoDescuento.Size = new System.Drawing.Size(330, 40);
			this.labelNuevoDescuento.TabIndex = 1;
			this.labelNuevoDescuento.Text = "Nuevo descuento (0-100):";
			this.labelNuevoDescuento.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// labelProdSeleccionado
			// 
			this.labelProdSeleccionado.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelProdSeleccionado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelProdSeleccionado.Location = new System.Drawing.Point(3, 0);
			this.labelProdSeleccionado.Name = "labelProdSeleccionado";
			this.labelProdSeleccionado.Size = new System.Drawing.Size(672, 108);
			this.labelProdSeleccionado.TabIndex = 0;
			this.labelProdSeleccionado.Text = "Producto Seleccionado:";
			this.labelProdSeleccionado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelDescActual
			// 
			this.labelDescActual.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDescActual.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDescActual.Location = new System.Drawing.Point(3, 0);
			this.labelDescActual.Name = "labelDescActual";
			this.labelDescActual.Size = new System.Drawing.Size(330, 40);
			this.labelDescActual.TabIndex = 0;
			this.labelDescActual.Text = "Descuento actual:";
			this.labelDescActual.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.buttPromocionar, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.labelProdSeleccionado, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelDescuentos, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 0, 4);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.67655F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.16441F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.74125F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.2089F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.2089F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(678, 440);
			this.tableLayoutPanel1.TabIndex = 1;
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
			this.dataGridView1.Location = new System.Drawing.Point(3, 111);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(672, 43);
			this.dataGridView1.TabIndex = 8;
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
			// tableLayoutPanelDescuentos
			// 
			this.tableLayoutPanelDescuentos.ColumnCount = 2;
			this.tableLayoutPanelDescuentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelDescuentos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelDescuentos.Controls.Add(this.labelDescActual, 0, 0);
			this.tableLayoutPanelDescuentos.Controls.Add(this.labelNuevoDescuento, 0, 1);
			this.tableLayoutPanelDescuentos.Controls.Add(this.textBoxValorDesc, 1, 1);
			this.tableLayoutPanelDescuentos.Controls.Add(this.labelValorDescActual, 1, 0);
			this.tableLayoutPanelDescuentos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelDescuentos.Location = new System.Drawing.Point(3, 160);
			this.tableLayoutPanelDescuentos.Name = "tableLayoutPanelDescuentos";
			this.tableLayoutPanelDescuentos.RowCount = 2;
			this.tableLayoutPanelDescuentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelDescuentos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanelDescuentos.Size = new System.Drawing.Size(672, 80);
			this.tableLayoutPanelDescuentos.TabIndex = 9;
			// 
			// labelValorDescActual
			// 
			this.labelValorDescActual.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelValorDescActual.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelValorDescActual.Location = new System.Drawing.Point(339, 0);
			this.labelValorDescActual.Name = "labelValorDescActual";
			this.labelValorDescActual.Size = new System.Drawing.Size(330, 40);
			this.labelValorDescActual.TabIndex = 3;
			this.labelValorDescActual.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// PromocionarProductoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(678, 440);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "PromocionarProductoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Promocionar Producto";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PromocionarProductoFormFormClosed);
			this.Load += new System.EventHandler(this.PromocionarProductoFormLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tableLayoutPanelDescuentos.ResumeLayout(false);
			this.tableLayoutPanelDescuentos.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
