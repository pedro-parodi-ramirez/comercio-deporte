/*
 * Created by SharpDevelop.
 * User: PETER
 * Date: 09/12/2018
 * Time: 16:13
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TiendaOnline
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage pageProdyProm;
		private System.Windows.Forms.TableLayoutPanel tableLayoutProdyProm;
		private System.Windows.Forms.TabPage pageCompras;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPrincipal;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.Button btnAgregarProd;
		private System.Windows.Forms.Button btnAgregarProm;
		private System.Windows.Forms.Button btnListarProductos;
		private System.Windows.Forms.Button btnListarProdProm;
		private System.Windows.Forms.TabPage pageTarjetas;
		private System.Windows.Forms.TabPage pageAdministracion;
		private System.Windows.Forms.TableLayoutPanel layoutAdministracion;
		private System.Windows.Forms.Button btnVentasTienda;
		private System.Windows.Forms.Button btnVentasCliente;
		private System.Windows.Forms.Button btnVentasTarjeta;
		private System.Windows.Forms.TableLayoutPanel layoutTotalVendidoAdm;
		private System.Windows.Forms.Label labelTotalEtiqueta;
		private System.Windows.Forms.Label labelTotalNumero;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnAgregarTarjeta;
		private System.Windows.Forms.Button btnBonificarTarjeta;
		private System.Windows.Forms.Button btnListarTarjetas;
		private System.Windows.Forms.Button btnListarTarjBenef;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel layoutCompras;
		private System.Windows.Forms.Label labelTituloCarro;
		private System.Windows.Forms.TableLayoutPanel layoutCarro;
		private System.Windows.Forms.Button btnAgregarProdCarro;
		private System.Windows.Forms.Button btnQuitarProdCarro;
		private System.Windows.Forms.Button btnIdCliente;
		private System.Windows.Forms.TableLayoutPanel layoutQuitarProdCarro;
		private System.Windows.Forms.Label labelQuitarProd;
		private System.Windows.Forms.Button btnRemoverProd;
		private System.Windows.Forms.Button btnCancelarQuitarProd;
		private System.Windows.Forms.Label labelBtnIdCliente;
		private System.Windows.Forms.Label labelProdYPromLista;
		private System.Windows.Forms.TableLayoutPanel layourProdyPromLista;
		private System.Windows.Forms.TableLayoutPanel layoutComprasLista;
		private System.Windows.Forms.Label labelComprasLista;
		private System.Windows.Forms.TableLayoutPanel layoutTarjetasLista;
		private System.Windows.Forms.Label labelTarjetasLista;
		private System.Windows.Forms.TableLayoutPanel layoutAdministracionLista;
		private System.Windows.Forms.Label labelAdministracionLista;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn Banco;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cuotas;
		private System.Windows.Forms.DataGridViewTextBoxColumn Interés;
		private System.Windows.Forms.DataGridView dataGridViewTarjetas;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
		private System.Windows.Forms.DataGridViewTextBoxColumn Talle;
		private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
		private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
		private System.Windows.Forms.DataGridView dataGridViewProdyProm;
		private System.Windows.Forms.DataGridView dataGridViewAdministracion;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridView dataGridViewCompras;
		private System.Windows.Forms.DataGridViewTextBoxColumn Columna1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.Button btnListarProdCarro;
		
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.pageProdyProm = new System.Windows.Forms.TabPage();
			this.layourProdyPromLista = new System.Windows.Forms.TableLayoutPanel();
			this.labelProdYPromLista = new System.Windows.Forms.Label();
			this.dataGridViewProdyProm = new System.Windows.Forms.DataGridView();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Talle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutProdyProm = new System.Windows.Forms.TableLayoutPanel();
			this.btnAgregarProd = new System.Windows.Forms.Button();
			this.btnAgregarProm = new System.Windows.Forms.Button();
			this.btnListarProdProm = new System.Windows.Forms.Button();
			this.btnListarProductos = new System.Windows.Forms.Button();
			this.pageCompras = new System.Windows.Forms.TabPage();
			this.layoutComprasLista = new System.Windows.Forms.TableLayoutPanel();
			this.labelComprasLista = new System.Windows.Forms.Label();
			this.dataGridViewCompras = new System.Windows.Forms.DataGridView();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Columna1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.layoutQuitarProdCarro = new System.Windows.Forms.TableLayoutPanel();
			this.labelQuitarProd = new System.Windows.Forms.Label();
			this.btnRemoverProd = new System.Windows.Forms.Button();
			this.btnCancelarQuitarProd = new System.Windows.Forms.Button();
			this.layoutCompras = new System.Windows.Forms.TableLayoutPanel();
			this.layoutCarro = new System.Windows.Forms.TableLayoutPanel();
			this.labelTituloCarro = new System.Windows.Forms.Label();
			this.btnAgregarProdCarro = new System.Windows.Forms.Button();
			this.btnQuitarProdCarro = new System.Windows.Forms.Button();
			this.btnListarProdCarro = new System.Windows.Forms.Button();
			this.labelBtnIdCliente = new System.Windows.Forms.Label();
			this.btnIdCliente = new System.Windows.Forms.Button();
			this.pageTarjetas = new System.Windows.Forms.TabPage();
			this.layoutTarjetasLista = new System.Windows.Forms.TableLayoutPanel();
			this.labelTarjetasLista = new System.Windows.Forms.Label();
			this.dataGridViewTarjetas = new System.Windows.Forms.DataGridView();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Interés = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnAgregarTarjeta = new System.Windows.Forms.Button();
			this.btnBonificarTarjeta = new System.Windows.Forms.Button();
			this.btnListarTarjetas = new System.Windows.Forms.Button();
			this.btnListarTarjBenef = new System.Windows.Forms.Button();
			this.pageAdministracion = new System.Windows.Forms.TabPage();
			this.layoutAdministracionLista = new System.Windows.Forms.TableLayoutPanel();
			this.labelAdministracionLista = new System.Windows.Forms.Label();
			this.dataGridViewAdministracion = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.layoutTotalVendidoAdm = new System.Windows.Forms.TableLayoutPanel();
			this.labelTotalEtiqueta = new System.Windows.Forms.Label();
			this.labelTotalNumero = new System.Windows.Forms.Label();
			this.layoutAdministracion = new System.Windows.Forms.TableLayoutPanel();
			this.btnVentasTienda = new System.Windows.Forms.Button();
			this.btnVentasCliente = new System.Windows.Forms.Button();
			this.btnVentasTarjeta = new System.Windows.Forms.Button();
			this.tableLayoutPrincipal = new System.Windows.Forms.TableLayoutPanel();
			this.labelTitulo = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1.SuspendLayout();
			this.pageProdyProm.SuspendLayout();
			this.layourProdyPromLista.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdyProm)).BeginInit();
			this.tableLayoutProdyProm.SuspendLayout();
			this.pageCompras.SuspendLayout();
			this.layoutComprasLista.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).BeginInit();
			this.layoutQuitarProdCarro.SuspendLayout();
			this.layoutCompras.SuspendLayout();
			this.layoutCarro.SuspendLayout();
			this.pageTarjetas.SuspendLayout();
			this.layoutTarjetasLista.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarjetas)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.pageAdministracion.SuspendLayout();
			this.layoutAdministracionLista.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdministracion)).BeginInit();
			this.layoutTotalVendidoAdm.SuspendLayout();
			this.layoutAdministracion.SuspendLayout();
			this.tableLayoutPrincipal.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.pageProdyProm);
			this.tabControl1.Controls.Add(this.pageCompras);
			this.tabControl1.Controls.Add(this.pageTarjetas);
			this.tabControl1.Controls.Add(this.pageAdministracion);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(3, 215);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1066, 568);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1SelectedIndexChanged);
			// 
			// pageProdyProm
			// 
			this.pageProdyProm.Controls.Add(this.layourProdyPromLista);
			this.pageProdyProm.Controls.Add(this.tableLayoutProdyProm);
			this.pageProdyProm.Location = new System.Drawing.Point(4, 25);
			this.pageProdyProm.Name = "pageProdyProm";
			this.pageProdyProm.Padding = new System.Windows.Forms.Padding(3);
			this.pageProdyProm.Size = new System.Drawing.Size(1058, 539);
			this.pageProdyProm.TabIndex = 0;
			this.pageProdyProm.Text = "Productos y Promociones";
			this.pageProdyProm.UseVisualStyleBackColor = true;
			// 
			// layourProdyPromLista
			// 
			this.layourProdyPromLista.ColumnCount = 1;
			this.layourProdyPromLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layourProdyPromLista.Controls.Add(this.labelProdYPromLista, 0, 0);
			this.layourProdyPromLista.Controls.Add(this.dataGridViewProdyProm, 0, 1);
			this.layourProdyPromLista.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layourProdyPromLista.Location = new System.Drawing.Point(3, 3);
			this.layourProdyPromLista.Name = "layourProdyPromLista";
			this.layourProdyPromLista.RowCount = 2;
			this.layourProdyPromLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.layourProdyPromLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
			this.layourProdyPromLista.Size = new System.Drawing.Size(852, 533);
			this.layourProdyPromLista.TabIndex = 3;
			// 
			// labelProdYPromLista
			// 
			this.labelProdYPromLista.BackColor = System.Drawing.SystemColors.Info;
			this.labelProdYPromLista.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelProdYPromLista.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelProdYPromLista.Location = new System.Drawing.Point(3, 0);
			this.labelProdYPromLista.Name = "labelProdYPromLista";
			this.labelProdYPromLista.Size = new System.Drawing.Size(846, 53);
			this.labelProdYPromLista.TabIndex = 2;
			this.labelProdYPromLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridViewProdyProm
			// 
			this.dataGridViewProdyProm.AllowUserToAddRows = false;
			this.dataGridViewProdyProm.AllowUserToDeleteRows = false;
			this.dataGridViewProdyProm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProdyProm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Tipo,
			this.Marca,
			this.Talle,
			this.Precio,
			this.Descuento});
			this.dataGridViewProdyProm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewProdyProm.Location = new System.Drawing.Point(3, 56);
			this.dataGridViewProdyProm.Name = "dataGridViewProdyProm";
			this.dataGridViewProdyProm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewProdyProm.Size = new System.Drawing.Size(846, 474);
			this.dataGridViewProdyProm.TabIndex = 3;
			// 
			// Tipo
			// 
			this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			this.Tipo.ReadOnly = true;
			// 
			// Marca
			// 
			this.Marca.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Marca.HeaderText = "Marca";
			this.Marca.Name = "Marca";
			this.Marca.ReadOnly = true;
			// 
			// Talle
			// 
			this.Talle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Talle.HeaderText = "Talle";
			this.Talle.Name = "Talle";
			this.Talle.ReadOnly = true;
			// 
			// Precio
			// 
			this.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Precio.HeaderText = "Precio";
			this.Precio.Name = "Precio";
			this.Precio.ReadOnly = true;
			// 
			// Descuento
			// 
			this.Descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Descuento.HeaderText = "Descuento";
			this.Descuento.Name = "Descuento";
			this.Descuento.ReadOnly = true;
			// 
			// tableLayoutProdyProm
			// 
			this.tableLayoutProdyProm.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.tableLayoutProdyProm.ColumnCount = 1;
			this.tableLayoutProdyProm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutProdyProm.Controls.Add(this.btnAgregarProd, 0, 0);
			this.tableLayoutProdyProm.Controls.Add(this.btnAgregarProm, 0, 1);
			this.tableLayoutProdyProm.Controls.Add(this.btnListarProdProm, 0, 3);
			this.tableLayoutProdyProm.Controls.Add(this.btnListarProductos, 0, 2);
			this.tableLayoutProdyProm.Dock = System.Windows.Forms.DockStyle.Right;
			this.tableLayoutProdyProm.Location = new System.Drawing.Point(855, 3);
			this.tableLayoutProdyProm.Name = "tableLayoutProdyProm";
			this.tableLayoutProdyProm.RowCount = 4;
			this.tableLayoutProdyProm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutProdyProm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutProdyProm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutProdyProm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutProdyProm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutProdyProm.Size = new System.Drawing.Size(200, 533);
			this.tableLayoutProdyProm.TabIndex = 0;
			// 
			// btnAgregarProd
			// 
			this.btnAgregarProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnAgregarProd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarProd.Location = new System.Drawing.Point(32, 3);
			this.btnAgregarProd.Name = "btnAgregarProd";
			this.btnAgregarProd.Size = new System.Drawing.Size(135, 127);
			this.btnAgregarProd.TabIndex = 0;
			this.btnAgregarProd.Text = "Agregar Producto";
			this.btnAgregarProd.UseVisualStyleBackColor = true;
			this.btnAgregarProd.Click += new System.EventHandler(this.BtnAgregarProdClick);
			// 
			// btnAgregarProm
			// 
			this.btnAgregarProm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnAgregarProm.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnAgregarProm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarProm.Location = new System.Drawing.Point(32, 136);
			this.btnAgregarProm.Name = "btnAgregarProm";
			this.btnAgregarProm.Size = new System.Drawing.Size(135, 127);
			this.btnAgregarProm.TabIndex = 1;
			this.btnAgregarProm.Text = "Modificar Descuento";
			this.btnAgregarProm.UseVisualStyleBackColor = false;
			this.btnAgregarProm.Click += new System.EventHandler(this.BtnAgregarPromClick);
			// 
			// btnListarProdProm
			// 
			this.btnListarProdProm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnListarProdProm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListarProdProm.Location = new System.Drawing.Point(32, 402);
			this.btnListarProdProm.Name = "btnListarProdProm";
			this.btnListarProdProm.Size = new System.Drawing.Size(135, 128);
			this.btnListarProdProm.TabIndex = 3;
			this.btnListarProdProm.Text = "Listar Promociones";
			this.btnListarProdProm.UseVisualStyleBackColor = true;
			this.btnListarProdProm.Click += new System.EventHandler(this.BtnListarProdPromClick);
			// 
			// btnListarProductos
			// 
			this.btnListarProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnListarProductos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListarProductos.Location = new System.Drawing.Point(32, 269);
			this.btnListarProductos.Name = "btnListarProductos";
			this.btnListarProductos.Size = new System.Drawing.Size(135, 127);
			this.btnListarProductos.TabIndex = 2;
			this.btnListarProductos.Text = "Listar Productos";
			this.btnListarProductos.UseVisualStyleBackColor = true;
			this.btnListarProductos.Click += new System.EventHandler(this.BtnListarProductosClick);
			// 
			// pageCompras
			// 
			this.pageCompras.Controls.Add(this.layoutComprasLista);
			this.pageCompras.Controls.Add(this.layoutQuitarProdCarro);
			this.pageCompras.Controls.Add(this.layoutCompras);
			this.pageCompras.Location = new System.Drawing.Point(4, 25);
			this.pageCompras.Name = "pageCompras";
			this.pageCompras.Padding = new System.Windows.Forms.Padding(3);
			this.pageCompras.Size = new System.Drawing.Size(1058, 539);
			this.pageCompras.TabIndex = 1;
			this.pageCompras.Text = "Compras";
			this.pageCompras.UseVisualStyleBackColor = true;
			// 
			// layoutComprasLista
			// 
			this.layoutComprasLista.ColumnCount = 1;
			this.layoutComprasLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutComprasLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutComprasLista.Controls.Add(this.labelComprasLista, 0, 0);
			this.layoutComprasLista.Controls.Add(this.dataGridViewCompras, 0, 1);
			this.layoutComprasLista.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutComprasLista.Location = new System.Drawing.Point(3, 3);
			this.layoutComprasLista.Name = "layoutComprasLista";
			this.layoutComprasLista.RowCount = 2;
			this.layoutComprasLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.layoutComprasLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
			this.layoutComprasLista.Size = new System.Drawing.Size(644, 533);
			this.layoutComprasLista.TabIndex = 6;
			// 
			// labelComprasLista
			// 
			this.labelComprasLista.BackColor = System.Drawing.SystemColors.Info;
			this.labelComprasLista.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelComprasLista.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelComprasLista.Location = new System.Drawing.Point(3, 0);
			this.labelComprasLista.Name = "labelComprasLista";
			this.labelComprasLista.Size = new System.Drawing.Size(638, 53);
			this.labelComprasLista.TabIndex = 0;
			this.labelComprasLista.Text = "No hay productos en carro";
			this.labelComprasLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridViewCompras
			// 
			this.dataGridViewCompras.AllowUserToAddRows = false;
			this.dataGridViewCompras.AllowUserToDeleteRows = false;
			this.dataGridViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column8,
			this.Columna1,
			this.Column4,
			this.Column5,
			this.Column6,
			this.Column7});
			this.dataGridViewCompras.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewCompras.Location = new System.Drawing.Point(3, 56);
			this.dataGridViewCompras.MultiSelect = false;
			this.dataGridViewCompras.Name = "dataGridViewCompras";
			this.dataGridViewCompras.ReadOnly = true;
			this.dataGridViewCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewCompras.Size = new System.Drawing.Size(638, 474);
			this.dataGridViewCompras.TabIndex = 1;
			this.dataGridViewCompras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewComprasCellClick);
			// 
			// Column8
			// 
			this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column8.HeaderText = "Cantidad";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			// 
			// Columna1
			// 
			this.Columna1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Columna1.HeaderText = "Tipo";
			this.Columna1.Name = "Columna1";
			this.Columna1.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column4.HeaderText = "Marca";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column5.HeaderText = "Talle";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column6.HeaderText = "Precio";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column7.HeaderText = "Descuento";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			// 
			// layoutQuitarProdCarro
			// 
			this.layoutQuitarProdCarro.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.layoutQuitarProdCarro.ColumnCount = 1;
			this.layoutQuitarProdCarro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutQuitarProdCarro.Controls.Add(this.labelQuitarProd, 0, 0);
			this.layoutQuitarProdCarro.Controls.Add(this.btnRemoverProd, 0, 1);
			this.layoutQuitarProdCarro.Controls.Add(this.btnCancelarQuitarProd, 0, 2);
			this.layoutQuitarProdCarro.Dock = System.Windows.Forms.DockStyle.Right;
			this.layoutQuitarProdCarro.Enabled = false;
			this.layoutQuitarProdCarro.Location = new System.Drawing.Point(647, 3);
			this.layoutQuitarProdCarro.Name = "layoutQuitarProdCarro";
			this.layoutQuitarProdCarro.RowCount = 4;
			this.layoutQuitarProdCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66518F));
			this.layoutQuitarProdCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.23737F));
			this.layoutQuitarProdCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.23737F));
			this.layoutQuitarProdCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.86008F));
			this.layoutQuitarProdCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutQuitarProdCarro.Size = new System.Drawing.Size(208, 533);
			this.layoutQuitarProdCarro.TabIndex = 5;
			this.layoutQuitarProdCarro.Visible = false;
			// 
			// labelQuitarProd
			// 
			this.labelQuitarProd.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labelQuitarProd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelQuitarProd.Location = new System.Drawing.Point(3, 179);
			this.labelQuitarProd.Name = "labelQuitarProd";
			this.labelQuitarProd.Size = new System.Drawing.Size(202, 43);
			this.labelQuitarProd.TabIndex = 3;
			this.labelQuitarProd.Text = "Seleccione el producto que desea remover:";
			this.labelQuitarProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// btnRemoverProd
			// 
			this.btnRemoverProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnRemoverProd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRemoverProd.Location = new System.Drawing.Point(61, 225);
			this.btnRemoverProd.Name = "btnRemoverProd";
			this.btnRemoverProd.Size = new System.Drawing.Size(85, 101);
			this.btnRemoverProd.TabIndex = 4;
			this.btnRemoverProd.Text = "Remover";
			this.btnRemoverProd.UseVisualStyleBackColor = true;
			this.btnRemoverProd.Click += new System.EventHandler(this.BtnRemoverProdClick);
			// 
			// btnCancelarQuitarProd
			// 
			this.btnCancelarQuitarProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnCancelarQuitarProd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelarQuitarProd.Location = new System.Drawing.Point(61, 332);
			this.btnCancelarQuitarProd.Name = "btnCancelarQuitarProd";
			this.btnCancelarQuitarProd.Size = new System.Drawing.Size(85, 101);
			this.btnCancelarQuitarProd.TabIndex = 5;
			this.btnCancelarQuitarProd.Text = "Cancelar";
			this.btnCancelarQuitarProd.UseVisualStyleBackColor = true;
			this.btnCancelarQuitarProd.Click += new System.EventHandler(this.BtnCancelarQuitarProdClick);
			// 
			// layoutCompras
			// 
			this.layoutCompras.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.layoutCompras.ColumnCount = 1;
			this.layoutCompras.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutCompras.Controls.Add(this.layoutCarro, 0, 0);
			this.layoutCompras.Controls.Add(this.labelBtnIdCliente, 0, 1);
			this.layoutCompras.Controls.Add(this.btnIdCliente, 0, 2);
			this.layoutCompras.Dock = System.Windows.Forms.DockStyle.Right;
			this.layoutCompras.Location = new System.Drawing.Point(855, 3);
			this.layoutCompras.Name = "layoutCompras";
			this.layoutCompras.RowCount = 3;
			this.layoutCompras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.layoutCompras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.layoutCompras.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutCompras.Size = new System.Drawing.Size(200, 533);
			this.layoutCompras.TabIndex = 0;
			// 
			// layoutCarro
			// 
			this.layoutCarro.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.layoutCarro.ColumnCount = 1;
			this.layoutCarro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutCarro.Controls.Add(this.labelTituloCarro, 0, 0);
			this.layoutCarro.Controls.Add(this.btnAgregarProdCarro, 0, 1);
			this.layoutCarro.Controls.Add(this.btnQuitarProdCarro, 0, 2);
			this.layoutCarro.Controls.Add(this.btnListarProdCarro, 0, 3);
			this.layoutCarro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutCarro.Location = new System.Drawing.Point(3, 3);
			this.layoutCarro.Name = "layoutCarro";
			this.layoutCarro.RowCount = 4;
			this.layoutCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutCarro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutCarro.Size = new System.Drawing.Size(194, 313);
			this.layoutCarro.TabIndex = 1;
			// 
			// labelTituloCarro
			// 
			this.labelTituloCarro.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelTituloCarro.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTituloCarro.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTituloCarro.Location = new System.Drawing.Point(3, 0);
			this.labelTituloCarro.Name = "labelTituloCarro";
			this.labelTituloCarro.Size = new System.Drawing.Size(188, 78);
			this.labelTituloCarro.TabIndex = 0;
			this.labelTituloCarro.Text = "Opciones de Carro:";
			this.labelTituloCarro.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// btnAgregarProdCarro
			// 
			this.btnAgregarProdCarro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnAgregarProdCarro.BackColor = System.Drawing.Color.Transparent;
			this.btnAgregarProdCarro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarProdCarro.Location = new System.Drawing.Point(29, 81);
			this.btnAgregarProdCarro.Name = "btnAgregarProdCarro";
			this.btnAgregarProdCarro.Size = new System.Drawing.Size(135, 72);
			this.btnAgregarProdCarro.TabIndex = 1;
			this.btnAgregarProdCarro.Text = "Agregar Producto";
			this.btnAgregarProdCarro.UseVisualStyleBackColor = false;
			this.btnAgregarProdCarro.Click += new System.EventHandler(this.BtnAgregarProdCarroClick);
			// 
			// btnQuitarProdCarro
			// 
			this.btnQuitarProdCarro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnQuitarProdCarro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuitarProdCarro.Location = new System.Drawing.Point(29, 159);
			this.btnQuitarProdCarro.Name = "btnQuitarProdCarro";
			this.btnQuitarProdCarro.Size = new System.Drawing.Size(135, 72);
			this.btnQuitarProdCarro.TabIndex = 2;
			this.btnQuitarProdCarro.Text = "Quitar Producto";
			this.btnQuitarProdCarro.UseVisualStyleBackColor = true;
			this.btnQuitarProdCarro.Click += new System.EventHandler(this.BtnQuitarProdCarroClick);
			// 
			// btnListarProdCarro
			// 
			this.btnListarProdCarro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnListarProdCarro.Location = new System.Drawing.Point(29, 237);
			this.btnListarProdCarro.Name = "btnListarProdCarro";
			this.btnListarProdCarro.Size = new System.Drawing.Size(135, 73);
			this.btnListarProdCarro.TabIndex = 4;
			this.btnListarProdCarro.Text = "Listar Productos";
			this.btnListarProdCarro.UseVisualStyleBackColor = true;
			this.btnListarProdCarro.Click += new System.EventHandler(this.BtnListarProdCarroClick);
			// 
			// labelBtnIdCliente
			// 
			this.labelBtnIdCliente.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBtnIdCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelBtnIdCliente.Location = new System.Drawing.Point(3, 319);
			this.labelBtnIdCliente.Name = "labelBtnIdCliente";
			this.labelBtnIdCliente.Size = new System.Drawing.Size(194, 79);
			this.labelBtnIdCliente.TabIndex = 3;
			this.labelBtnIdCliente.Text = "Continuar a Pago:";
			this.labelBtnIdCliente.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// btnIdCliente
			// 
			this.btnIdCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnIdCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnIdCliente.Location = new System.Drawing.Point(32, 401);
			this.btnIdCliente.Name = "btnIdCliente";
			this.btnIdCliente.Size = new System.Drawing.Size(135, 73);
			this.btnIdCliente.TabIndex = 2;
			this.btnIdCliente.Text = "Identificar Cliente";
			this.btnIdCliente.UseVisualStyleBackColor = true;
			this.btnIdCliente.Click += new System.EventHandler(this.BtnIdClienteClick);
			// 
			// pageTarjetas
			// 
			this.pageTarjetas.Controls.Add(this.layoutTarjetasLista);
			this.pageTarjetas.Controls.Add(this.tableLayoutPanel1);
			this.pageTarjetas.Location = new System.Drawing.Point(4, 25);
			this.pageTarjetas.Name = "pageTarjetas";
			this.pageTarjetas.Padding = new System.Windows.Forms.Padding(3);
			this.pageTarjetas.Size = new System.Drawing.Size(1058, 539);
			this.pageTarjetas.TabIndex = 2;
			this.pageTarjetas.Text = "Tarjetas";
			this.pageTarjetas.UseVisualStyleBackColor = true;
			// 
			// layoutTarjetasLista
			// 
			this.layoutTarjetasLista.ColumnCount = 1;
			this.layoutTarjetasLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutTarjetasLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutTarjetasLista.Controls.Add(this.labelTarjetasLista, 0, 0);
			this.layoutTarjetasLista.Controls.Add(this.dataGridViewTarjetas, 0, 1);
			this.layoutTarjetasLista.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutTarjetasLista.Location = new System.Drawing.Point(3, 3);
			this.layoutTarjetasLista.Name = "layoutTarjetasLista";
			this.layoutTarjetasLista.RowCount = 2;
			this.layoutTarjetasLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.layoutTarjetasLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
			this.layoutTarjetasLista.Size = new System.Drawing.Size(852, 533);
			this.layoutTarjetasLista.TabIndex = 2;
			// 
			// labelTarjetasLista
			// 
			this.labelTarjetasLista.BackColor = System.Drawing.SystemColors.Info;
			this.labelTarjetasLista.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTarjetasLista.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTarjetasLista.Location = new System.Drawing.Point(3, 0);
			this.labelTarjetasLista.Name = "labelTarjetasLista";
			this.labelTarjetasLista.Size = new System.Drawing.Size(846, 53);
			this.labelTarjetasLista.TabIndex = 2;
			this.labelTarjetasLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridViewTarjetas
			// 
			this.dataGridViewTarjetas.AllowUserToAddRows = false;
			this.dataGridViewTarjetas.AllowUserToDeleteRows = false;
			this.dataGridViewTarjetas.AllowUserToResizeRows = false;
			this.dataGridViewTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Nombre,
			this.Banco,
			this.Cuotas,
			this.Interés});
			this.dataGridViewTarjetas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewTarjetas.Location = new System.Drawing.Point(3, 56);
			this.dataGridViewTarjetas.MultiSelect = false;
			this.dataGridViewTarjetas.Name = "dataGridViewTarjetas";
			this.dataGridViewTarjetas.ReadOnly = true;
			this.dataGridViewTarjetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewTarjetas.Size = new System.Drawing.Size(846, 474);
			this.dataGridViewTarjetas.TabIndex = 3;
			this.dataGridViewTarjetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTarjetasCellClick);
			// 
			// Nombre
			// 
			this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			this.Nombre.ReadOnly = true;
			this.Nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Banco
			// 
			this.Banco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Banco.HeaderText = "Banco";
			this.Banco.Name = "Banco";
			this.Banco.ReadOnly = true;
			this.Banco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Cuotas
			// 
			this.Cuotas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Cuotas.HeaderText = "Cuotas";
			this.Cuotas.Name = "Cuotas";
			this.Cuotas.ReadOnly = true;
			this.Cuotas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// Interés
			// 
			this.Interés.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Interés.HeaderText = "Interés";
			this.Interés.Name = "Interés";
			this.Interés.ReadOnly = true;
			this.Interés.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.btnAgregarTarjeta, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnBonificarTarjeta, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btnListarTarjetas, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btnListarTarjBenef, 0, 3);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(855, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 533);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// btnAgregarTarjeta
			// 
			this.btnAgregarTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnAgregarTarjeta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarTarjeta.Location = new System.Drawing.Point(32, 3);
			this.btnAgregarTarjeta.Name = "btnAgregarTarjeta";
			this.btnAgregarTarjeta.Size = new System.Drawing.Size(135, 127);
			this.btnAgregarTarjeta.TabIndex = 0;
			this.btnAgregarTarjeta.Text = "Agregar Tarjeta";
			this.btnAgregarTarjeta.UseVisualStyleBackColor = true;
			this.btnAgregarTarjeta.Click += new System.EventHandler(this.BtnAgregarTarjetaClick);
			// 
			// btnBonificarTarjeta
			// 
			this.btnBonificarTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnBonificarTarjeta.BackColor = System.Drawing.Color.LightGreen;
			this.btnBonificarTarjeta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBonificarTarjeta.Location = new System.Drawing.Point(32, 136);
			this.btnBonificarTarjeta.Name = "btnBonificarTarjeta";
			this.btnBonificarTarjeta.Size = new System.Drawing.Size(135, 127);
			this.btnBonificarTarjeta.TabIndex = 1;
			this.btnBonificarTarjeta.Text = "Bonificar Tarjeta";
			this.btnBonificarTarjeta.UseVisualStyleBackColor = false;
			this.btnBonificarTarjeta.Click += new System.EventHandler(this.BtnBonificarTarjetaClick);
			// 
			// btnListarTarjetas
			// 
			this.btnListarTarjetas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnListarTarjetas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListarTarjetas.Location = new System.Drawing.Point(32, 269);
			this.btnListarTarjetas.Name = "btnListarTarjetas";
			this.btnListarTarjetas.Size = new System.Drawing.Size(135, 127);
			this.btnListarTarjetas.TabIndex = 2;
			this.btnListarTarjetas.Text = "Listar Tarjetas";
			this.btnListarTarjetas.UseVisualStyleBackColor = true;
			this.btnListarTarjetas.Click += new System.EventHandler(this.BtnListarTarjetasClick);
			// 
			// btnListarTarjBenef
			// 
			this.btnListarTarjBenef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnListarTarjBenef.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnListarTarjBenef.Location = new System.Drawing.Point(32, 402);
			this.btnListarTarjBenef.Name = "btnListarTarjBenef";
			this.btnListarTarjBenef.Size = new System.Drawing.Size(135, 128);
			this.btnListarTarjBenef.TabIndex = 3;
			this.btnListarTarjBenef.Text = "Listar Tarjetas con Beneficio";
			this.btnListarTarjBenef.UseVisualStyleBackColor = true;
			this.btnListarTarjBenef.Click += new System.EventHandler(this.BtnListarTarjBenefClick);
			// 
			// pageAdministracion
			// 
			this.pageAdministracion.BackColor = System.Drawing.Color.Transparent;
			this.pageAdministracion.Controls.Add(this.layoutAdministracionLista);
			this.pageAdministracion.Controls.Add(this.layoutTotalVendidoAdm);
			this.pageAdministracion.Controls.Add(this.layoutAdministracion);
			this.pageAdministracion.Location = new System.Drawing.Point(4, 25);
			this.pageAdministracion.Name = "pageAdministracion";
			this.pageAdministracion.Padding = new System.Windows.Forms.Padding(3);
			this.pageAdministracion.Size = new System.Drawing.Size(1058, 539);
			this.pageAdministracion.TabIndex = 3;
			this.pageAdministracion.Text = "Administraición";
			// 
			// layoutAdministracionLista
			// 
			this.layoutAdministracionLista.ColumnCount = 1;
			this.layoutAdministracionLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutAdministracionLista.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutAdministracionLista.Controls.Add(this.labelAdministracionLista, 0, 0);
			this.layoutAdministracionLista.Controls.Add(this.dataGridViewAdministracion, 0, 1);
			this.layoutAdministracionLista.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutAdministracionLista.Location = new System.Drawing.Point(3, 3);
			this.layoutAdministracionLista.Name = "layoutAdministracionLista";
			this.layoutAdministracionLista.RowCount = 2;
			this.layoutAdministracionLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.layoutAdministracionLista.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
			this.layoutAdministracionLista.Size = new System.Drawing.Size(852, 533);
			this.layoutAdministracionLista.TabIndex = 3;
			// 
			// labelAdministracionLista
			// 
			this.labelAdministracionLista.BackColor = System.Drawing.SystemColors.Info;
			this.labelAdministracionLista.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAdministracionLista.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAdministracionLista.Location = new System.Drawing.Point(3, 0);
			this.labelAdministracionLista.Name = "labelAdministracionLista";
			this.labelAdministracionLista.Size = new System.Drawing.Size(846, 53);
			this.labelAdministracionLista.TabIndex = 0;
			this.labelAdministracionLista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridViewAdministracion
			// 
			this.dataGridViewAdministracion.AllowUserToAddRows = false;
			this.dataGridViewAdministracion.AllowUserToDeleteRows = false;
			this.dataGridViewAdministracion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAdministracion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column1,
			this.Column2,
			this.Column3});
			this.dataGridViewAdministracion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewAdministracion.Location = new System.Drawing.Point(3, 56);
			this.dataGridViewAdministracion.Name = "dataGridViewAdministracion";
			this.dataGridViewAdministracion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewAdministracion.Size = new System.Drawing.Size(846, 474);
			this.dataGridViewAdministracion.TabIndex = 1;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.HeaderText = "Nombre";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText = "";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText = "";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// layoutTotalVendidoAdm
			// 
			this.layoutTotalVendidoAdm.BackColor = System.Drawing.Color.LightGreen;
			this.layoutTotalVendidoAdm.ColumnCount = 1;
			this.layoutTotalVendidoAdm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutTotalVendidoAdm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutTotalVendidoAdm.Controls.Add(this.labelTotalEtiqueta, 0, 0);
			this.layoutTotalVendidoAdm.Controls.Add(this.labelTotalNumero, 0, 1);
			this.layoutTotalVendidoAdm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutTotalVendidoAdm.Enabled = false;
			this.layoutTotalVendidoAdm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutTotalVendidoAdm.Location = new System.Drawing.Point(3, 3);
			this.layoutTotalVendidoAdm.Name = "layoutTotalVendidoAdm";
			this.layoutTotalVendidoAdm.RowCount = 2;
			this.layoutTotalVendidoAdm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.layoutTotalVendidoAdm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.layoutTotalVendidoAdm.Size = new System.Drawing.Size(852, 533);
			this.layoutTotalVendidoAdm.TabIndex = 2;
			this.layoutTotalVendidoAdm.Visible = false;
			// 
			// labelTotalEtiqueta
			// 
			this.labelTotalEtiqueta.BackColor = System.Drawing.Color.Transparent;
			this.labelTotalEtiqueta.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTotalEtiqueta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalEtiqueta.Location = new System.Drawing.Point(3, 0);
			this.labelTotalEtiqueta.Name = "labelTotalEtiqueta";
			this.labelTotalEtiqueta.Size = new System.Drawing.Size(846, 266);
			this.labelTotalEtiqueta.TabIndex = 0;
			this.labelTotalEtiqueta.Text = "El total vendido por la Tienda es:";
			this.labelTotalEtiqueta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// labelTotalNumero
			// 
			this.labelTotalNumero.BackColor = System.Drawing.Color.Transparent;
			this.labelTotalNumero.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTotalNumero.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalNumero.Location = new System.Drawing.Point(3, 266);
			this.labelTotalNumero.Name = "labelTotalNumero";
			this.labelTotalNumero.Size = new System.Drawing.Size(846, 267);
			this.labelTotalNumero.TabIndex = 1;
			this.labelTotalNumero.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// layoutAdministracion
			// 
			this.layoutAdministracion.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.layoutAdministracion.ColumnCount = 1;
			this.layoutAdministracion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutAdministracion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutAdministracion.Controls.Add(this.btnVentasTienda, 0, 0);
			this.layoutAdministracion.Controls.Add(this.btnVentasCliente, 0, 1);
			this.layoutAdministracion.Controls.Add(this.btnVentasTarjeta, 0, 2);
			this.layoutAdministracion.Dock = System.Windows.Forms.DockStyle.Right;
			this.layoutAdministracion.Location = new System.Drawing.Point(855, 3);
			this.layoutAdministracion.Name = "layoutAdministracion";
			this.layoutAdministracion.RowCount = 3;
			this.layoutAdministracion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.layoutAdministracion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.layoutAdministracion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.layoutAdministracion.Size = new System.Drawing.Size(200, 533);
			this.layoutAdministracion.TabIndex = 0;
			// 
			// btnVentasTienda
			// 
			this.btnVentasTienda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnVentasTienda.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVentasTienda.Location = new System.Drawing.Point(32, 3);
			this.btnVentasTienda.Name = "btnVentasTienda";
			this.btnVentasTienda.Size = new System.Drawing.Size(135, 171);
			this.btnVentasTienda.TabIndex = 0;
			this.btnVentasTienda.Text = "Ventas Tienda";
			this.btnVentasTienda.UseVisualStyleBackColor = true;
			this.btnVentasTienda.Click += new System.EventHandler(this.BtnVentasTiendaClick);
			// 
			// btnVentasCliente
			// 
			this.btnVentasCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnVentasCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnVentasCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVentasCliente.Location = new System.Drawing.Point(32, 180);
			this.btnVentasCliente.Name = "btnVentasCliente";
			this.btnVentasCliente.Size = new System.Drawing.Size(135, 171);
			this.btnVentasCliente.TabIndex = 1;
			this.btnVentasCliente.Text = "Ventas por Cliente";
			this.btnVentasCliente.UseVisualStyleBackColor = true;
			this.btnVentasCliente.Click += new System.EventHandler(this.BtnVentasClienteClick);
			// 
			// btnVentasTarjeta
			// 
			this.btnVentasTarjeta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnVentasTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnVentasTarjeta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnVentasTarjeta.Location = new System.Drawing.Point(32, 357);
			this.btnVentasTarjeta.Name = "btnVentasTarjeta";
			this.btnVentasTarjeta.Size = new System.Drawing.Size(135, 173);
			this.btnVentasTarjeta.TabIndex = 2;
			this.btnVentasTarjeta.Text = "Ventas por Tarjeta";
			this.btnVentasTarjeta.UseVisualStyleBackColor = true;
			this.btnVentasTarjeta.Click += new System.EventHandler(this.BtnVentasTarjetaClick);
			// 
			// tableLayoutPrincipal
			// 
			this.tableLayoutPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.tableLayoutPrincipal.ColumnCount = 1;
			this.tableLayoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPrincipal.Controls.Add(this.tabControl1, 0, 2);
			this.tableLayoutPrincipal.Controls.Add(this.labelTitulo, 0, 1);
			this.tableLayoutPrincipal.Controls.Add(this.menuStrip1, 0, 0);
			this.tableLayoutPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPrincipal.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPrincipal.Name = "tableLayoutPrincipal";
			this.tableLayoutPrincipal.RowCount = 3;
			this.tableLayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
			this.tableLayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73F));
			this.tableLayoutPrincipal.Size = new System.Drawing.Size(1072, 786);
			this.tableLayoutPrincipal.TabIndex = 1;
			// 
			// labelTitulo
			// 
			this.labelTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTitulo.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
				| System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitulo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.labelTitulo.Location = new System.Drawing.Point(3, 55);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(1066, 157);
			this.labelTitulo.TabIndex = 1;
			this.labelTitulo.Text = "SITANDBUY ON-LINE";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1072, 25);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.salirToolStripMenuItem});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
			this.menuToolStripMenuItem.Text = "Menu";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1072, 786);
			this.Controls.Add(this.tableLayoutPrincipal);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TiendaOnline";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.tabControl1.ResumeLayout(false);
			this.pageProdyProm.ResumeLayout(false);
			this.layourProdyPromLista.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdyProm)).EndInit();
			this.tableLayoutProdyProm.ResumeLayout(false);
			this.pageCompras.ResumeLayout(false);
			this.layoutComprasLista.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).EndInit();
			this.layoutQuitarProdCarro.ResumeLayout(false);
			this.layoutCompras.ResumeLayout(false);
			this.layoutCarro.ResumeLayout(false);
			this.pageTarjetas.ResumeLayout(false);
			this.layoutTarjetasLista.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarjetas)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.pageAdministracion.ResumeLayout(false);
			this.layoutAdministracionLista.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdministracion)).EndInit();
			this.layoutTotalVendidoAdm.ResumeLayout(false);
			this.layoutAdministracion.ResumeLayout(false);
			this.tableLayoutPrincipal.ResumeLayout(false);
			this.tableLayoutPrincipal.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}