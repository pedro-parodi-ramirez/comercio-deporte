/*
 * Created by SharpDevelop.
 * User: PETER
 * Date: 10/12/2018
 * Time: 15:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TiendaOnline
{
	partial class ClienteyPagoForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel layoutIngresoDNI;
		private System.Windows.Forms.Label labelDNI;
		private System.Windows.Forms.TextBox textBoxDNI;
		private System.Windows.Forms.Button buttoOkDNI;
		private System.Windows.Forms.TableLayoutPanel layoutPago;
		private System.Windows.Forms.Label labelInfoCliente;
		private System.Windows.Forms.TableLayoutPanel layoutAgregarCliente;
		private System.Windows.Forms.Label labelCompletarDatos;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.Label labelApellido;
		private System.Windows.Forms.Label labelFechaNacimiento;
		private System.Windows.Forms.Button btnAgregarCliente;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.TextBox textBoxApellido;
		private System.Windows.Forms.TextBox textBoxFechaNacimiento;
		private System.Windows.Forms.TableLayoutPanel layoutTarjetasyPago;
		private System.Windows.Forms.TableLayoutPanel layoutSelectTarjeta;
		private System.Windows.Forms.Label labelIndiceTarjeta;
		private System.Windows.Forms.Label labelCuotas;
		private System.Windows.Forms.Button btnComprar;
		private System.Windows.Forms.Label labelTotalCompra;
		private System.Windows.Forms.Label labelSelectTarjeta;
		private System.Windows.Forms.Button btnCancelar2;
		private System.Windows.Forms.Button btnCancelar3;
		private System.Windows.Forms.Button btnCancelar1;
		private System.Windows.Forms.ComboBox comboBoxTarjetas;
		private System.Windows.Forms.ComboBox comboBoxCuotas;
		private System.Windows.Forms.DataGridView dataGridViewTarjetas;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		
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
			this.layoutIngresoDNI = new System.Windows.Forms.TableLayoutPanel();
			this.labelDNI = new System.Windows.Forms.Label();
			this.textBoxDNI = new System.Windows.Forms.TextBox();
			this.buttoOkDNI = new System.Windows.Forms.Button();
			this.btnCancelar1 = new System.Windows.Forms.Button();
			this.layoutPago = new System.Windows.Forms.TableLayoutPanel();
			this.labelInfoCliente = new System.Windows.Forms.Label();
			this.layoutTarjetasyPago = new System.Windows.Forms.TableLayoutPanel();
			this.layoutSelectTarjeta = new System.Windows.Forms.TableLayoutPanel();
			this.labelIndiceTarjeta = new System.Windows.Forms.Label();
			this.labelCuotas = new System.Windows.Forms.Label();
			this.btnComprar = new System.Windows.Forms.Button();
			this.btnCancelar3 = new System.Windows.Forms.Button();
			this.comboBoxTarjetas = new System.Windows.Forms.ComboBox();
			this.comboBoxCuotas = new System.Windows.Forms.ComboBox();
			this.dataGridViewTarjetas = new System.Windows.Forms.DataGridView();
			this.labelTotalCompra = new System.Windows.Forms.Label();
			this.labelSelectTarjeta = new System.Windows.Forms.Label();
			this.layoutAgregarCliente = new System.Windows.Forms.TableLayoutPanel();
			this.labelCompletarDatos = new System.Windows.Forms.Label();
			this.labelNombre = new System.Windows.Forms.Label();
			this.labelApellido = new System.Windows.Forms.Label();
			this.labelFechaNacimiento = new System.Windows.Forms.Label();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.textBoxApellido = new System.Windows.Forms.TextBox();
			this.textBoxFechaNacimiento = new System.Windows.Forms.TextBox();
			this.btnAgregarCliente = new System.Windows.Forms.Button();
			this.btnCancelar2 = new System.Windows.Forms.Button();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.layoutIngresoDNI.SuspendLayout();
			this.layoutPago.SuspendLayout();
			this.layoutTarjetasyPago.SuspendLayout();
			this.layoutSelectTarjeta.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarjetas)).BeginInit();
			this.layoutAgregarCliente.SuspendLayout();
			this.SuspendLayout();
			// 
			// layoutIngresoDNI
			// 
			this.layoutIngresoDNI.ColumnCount = 1;
			this.layoutIngresoDNI.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutIngresoDNI.Controls.Add(this.labelDNI, 0, 0);
			this.layoutIngresoDNI.Controls.Add(this.textBoxDNI, 0, 1);
			this.layoutIngresoDNI.Controls.Add(this.buttoOkDNI, 0, 2);
			this.layoutIngresoDNI.Controls.Add(this.btnCancelar1, 0, 3);
			this.layoutIngresoDNI.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutIngresoDNI.Location = new System.Drawing.Point(0, 0);
			this.layoutIngresoDNI.Name = "layoutIngresoDNI";
			this.layoutIngresoDNI.RowCount = 4;
			this.layoutIngresoDNI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutIngresoDNI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutIngresoDNI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutIngresoDNI.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layoutIngresoDNI.Size = new System.Drawing.Size(912, 525);
			this.layoutIngresoDNI.TabIndex = 0;
			// 
			// labelDNI
			// 
			this.labelDNI.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDNI.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDNI.Location = new System.Drawing.Point(3, 0);
			this.labelDNI.Name = "labelDNI";
			this.labelDNI.Size = new System.Drawing.Size(906, 131);
			this.labelDNI.TabIndex = 0;
			this.labelDNI.Text = "Ingrese DNI del Cliente:";
			this.labelDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxDNI
			// 
			this.textBoxDNI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxDNI.Location = new System.Drawing.Point(3, 134);
			this.textBoxDNI.Name = "textBoxDNI";
			this.textBoxDNI.Size = new System.Drawing.Size(906, 20);
			this.textBoxDNI.TabIndex = 1;
			this.textBoxDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// buttoOkDNI
			// 
			this.buttoOkDNI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.buttoOkDNI.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttoOkDNI.Location = new System.Drawing.Point(406, 265);
			this.buttoOkDNI.Name = "buttoOkDNI";
			this.buttoOkDNI.Size = new System.Drawing.Size(100, 125);
			this.buttoOkDNI.TabIndex = 2;
			this.buttoOkDNI.Text = "Ok";
			this.buttoOkDNI.UseVisualStyleBackColor = true;
			this.buttoOkDNI.Click += new System.EventHandler(this.ButtoOkDNIClick);
			// 
			// btnCancelar1
			// 
			this.btnCancelar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnCancelar1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar1.Location = new System.Drawing.Point(406, 396);
			this.btnCancelar1.Name = "btnCancelar1";
			this.btnCancelar1.Size = new System.Drawing.Size(100, 126);
			this.btnCancelar1.TabIndex = 3;
			this.btnCancelar1.Text = "Cancelar";
			this.btnCancelar1.UseVisualStyleBackColor = true;
			this.btnCancelar1.Click += new System.EventHandler(this.BtnCancelar1Click);
			// 
			// layoutPago
			// 
			this.layoutPago.ColumnCount = 1;
			this.layoutPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutPago.Controls.Add(this.labelInfoCliente, 0, 0);
			this.layoutPago.Controls.Add(this.layoutTarjetasyPago, 0, 3);
			this.layoutPago.Controls.Add(this.labelTotalCompra, 0, 4);
			this.layoutPago.Controls.Add(this.labelSelectTarjeta, 0, 2);
			this.layoutPago.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutPago.Enabled = false;
			this.layoutPago.Location = new System.Drawing.Point(0, 0);
			this.layoutPago.Name = "layoutPago";
			this.layoutPago.RowCount = 5;
			this.layoutPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.75269F));
			this.layoutPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.526882F));
			this.layoutPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.75269F));
			this.layoutPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.21505F));
			this.layoutPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.75269F));
			this.layoutPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutPago.Size = new System.Drawing.Size(912, 525);
			this.layoutPago.TabIndex = 1;
			this.layoutPago.Visible = false;
			// 
			// labelInfoCliente
			// 
			this.labelInfoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelInfoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInfoCliente.Location = new System.Drawing.Point(3, 0);
			this.labelInfoCliente.Name = "labelInfoCliente";
			this.labelInfoCliente.Size = new System.Drawing.Size(906, 56);
			this.labelInfoCliente.TabIndex = 0;
			this.labelInfoCliente.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// layoutTarjetasyPago
			// 
			this.layoutTarjetasyPago.ColumnCount = 2;
			this.layoutTarjetasyPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.layoutTarjetasyPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.layoutTarjetasyPago.Controls.Add(this.layoutSelectTarjeta, 1, 0);
			this.layoutTarjetasyPago.Controls.Add(this.dataGridViewTarjetas, 0, 0);
			this.layoutTarjetasyPago.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutTarjetasyPago.Location = new System.Drawing.Point(3, 154);
			this.layoutTarjetasyPago.Name = "layoutTarjetasyPago";
			this.layoutTarjetasyPago.RowCount = 1;
			this.layoutTarjetasyPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutTarjetasyPago.Size = new System.Drawing.Size(906, 310);
			this.layoutTarjetasyPago.TabIndex = 1;
			// 
			// layoutSelectTarjeta
			// 
			this.layoutSelectTarjeta.ColumnCount = 1;
			this.layoutSelectTarjeta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutSelectTarjeta.Controls.Add(this.labelIndiceTarjeta, 0, 0);
			this.layoutSelectTarjeta.Controls.Add(this.labelCuotas, 0, 2);
			this.layoutSelectTarjeta.Controls.Add(this.btnComprar, 0, 4);
			this.layoutSelectTarjeta.Controls.Add(this.btnCancelar3, 0, 5);
			this.layoutSelectTarjeta.Controls.Add(this.comboBoxTarjetas, 0, 1);
			this.layoutSelectTarjeta.Controls.Add(this.comboBoxCuotas, 0, 3);
			this.layoutSelectTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutSelectTarjeta.Location = new System.Drawing.Point(637, 3);
			this.layoutSelectTarjeta.Name = "layoutSelectTarjeta";
			this.layoutSelectTarjeta.RowCount = 6;
			this.layoutSelectTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.layoutSelectTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.layoutSelectTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.layoutSelectTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.layoutSelectTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.layoutSelectTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.layoutSelectTarjeta.Size = new System.Drawing.Size(266, 304);
			this.layoutSelectTarjeta.TabIndex = 1;
			// 
			// labelIndiceTarjeta
			// 
			this.labelIndiceTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelIndiceTarjeta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelIndiceTarjeta.Location = new System.Drawing.Point(3, 0);
			this.labelIndiceTarjeta.Name = "labelIndiceTarjeta";
			this.labelIndiceTarjeta.Size = new System.Drawing.Size(260, 50);
			this.labelIndiceTarjeta.TabIndex = 0;
			this.labelIndiceTarjeta.Text = "Seleccione una Tarjeta:";
			this.labelIndiceTarjeta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// labelCuotas
			// 
			this.labelCuotas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCuotas.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCuotas.Location = new System.Drawing.Point(3, 100);
			this.labelCuotas.Name = "labelCuotas";
			this.labelCuotas.Size = new System.Drawing.Size(260, 50);
			this.labelCuotas.TabIndex = 1;
			this.labelCuotas.Text = "Cantidad de Cuotas:";
			this.labelCuotas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// btnComprar
			// 
			this.btnComprar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnComprar.Enabled = false;
			this.btnComprar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnComprar.Location = new System.Drawing.Point(93, 203);
			this.btnComprar.Name = "btnComprar";
			this.btnComprar.Size = new System.Drawing.Size(80, 44);
			this.btnComprar.TabIndex = 6;
			this.btnComprar.Text = "Comprar";
			this.btnComprar.UseVisualStyleBackColor = true;
			this.btnComprar.Click += new System.EventHandler(this.BtnComprarClick);
			// 
			// btnCancelar3
			// 
			this.btnCancelar3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnCancelar3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar3.Location = new System.Drawing.Point(93, 253);
			this.btnCancelar3.Name = "btnCancelar3";
			this.btnCancelar3.Size = new System.Drawing.Size(80, 48);
			this.btnCancelar3.TabIndex = 7;
			this.btnCancelar3.Text = "Cancelar";
			this.btnCancelar3.UseVisualStyleBackColor = true;
			this.btnCancelar3.Click += new System.EventHandler(this.BtnCancelar3Click);
			// 
			// comboBoxTarjetas
			// 
			this.comboBoxTarjetas.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.comboBoxTarjetas.FormattingEnabled = true;
			this.comboBoxTarjetas.Location = new System.Drawing.Point(73, 53);
			this.comboBoxTarjetas.Name = "comboBoxTarjetas";
			this.comboBoxTarjetas.Size = new System.Drawing.Size(120, 21);
			this.comboBoxTarjetas.TabIndex = 8;
			this.comboBoxTarjetas.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTarjetasSelectedIndexChanged);
			// 
			// comboBoxCuotas
			// 
			this.comboBoxCuotas.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.comboBoxCuotas.FormattingEnabled = true;
			this.comboBoxCuotas.Location = new System.Drawing.Point(73, 153);
			this.comboBoxCuotas.Name = "comboBoxCuotas";
			this.comboBoxCuotas.Size = new System.Drawing.Size(120, 21);
			this.comboBoxCuotas.TabIndex = 9;
			this.comboBoxCuotas.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCuotasSelectedIndexChanged);
			// 
			// dataGridViewTarjetas
			// 
			this.dataGridViewTarjetas.AllowUserToAddRows = false;
			this.dataGridViewTarjetas.AllowUserToDeleteRows = false;
			this.dataGridViewTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTarjetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column1,
			this.Column2,
			this.Column3,
			this.Column4});
			this.dataGridViewTarjetas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewTarjetas.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewTarjetas.Name = "dataGridViewTarjetas";
			this.dataGridViewTarjetas.ReadOnly = true;
			this.dataGridViewTarjetas.Size = new System.Drawing.Size(628, 304);
			this.dataGridViewTarjetas.TabIndex = 2;
			// 
			// labelTotalCompra
			// 
			this.labelTotalCompra.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTotalCompra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalCompra.Location = new System.Drawing.Point(3, 467);
			this.labelTotalCompra.Name = "labelTotalCompra";
			this.labelTotalCompra.Size = new System.Drawing.Size(906, 58);
			this.labelTotalCompra.TabIndex = 2;
			this.labelTotalCompra.Text = "En el carro hay un total de: ";
			this.labelTotalCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelSelectTarjeta
			// 
			this.labelSelectTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelSelectTarjeta.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSelectTarjeta.Location = new System.Drawing.Point(3, 95);
			this.labelSelectTarjeta.Name = "labelSelectTarjeta";
			this.labelSelectTarjeta.Size = new System.Drawing.Size(906, 56);
			this.labelSelectTarjeta.TabIndex = 3;
			this.labelSelectTarjeta.Text = "Tarjetas disponibles:";
			this.labelSelectTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// layoutAgregarCliente
			// 
			this.layoutAgregarCliente.ColumnCount = 1;
			this.layoutAgregarCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutAgregarCliente.Controls.Add(this.labelCompletarDatos, 0, 0);
			this.layoutAgregarCliente.Controls.Add(this.labelNombre, 0, 1);
			this.layoutAgregarCliente.Controls.Add(this.labelApellido, 0, 3);
			this.layoutAgregarCliente.Controls.Add(this.labelFechaNacimiento, 0, 5);
			this.layoutAgregarCliente.Controls.Add(this.textBoxNombre, 0, 2);
			this.layoutAgregarCliente.Controls.Add(this.textBoxApellido, 0, 4);
			this.layoutAgregarCliente.Controls.Add(this.textBoxFechaNacimiento, 0, 6);
			this.layoutAgregarCliente.Controls.Add(this.btnAgregarCliente, 0, 7);
			this.layoutAgregarCliente.Controls.Add(this.btnCancelar2, 0, 8);
			this.layoutAgregarCliente.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutAgregarCliente.Enabled = false;
			this.layoutAgregarCliente.Location = new System.Drawing.Point(0, 0);
			this.layoutAgregarCliente.Name = "layoutAgregarCliente";
			this.layoutAgregarCliente.RowCount = 9;
			this.layoutAgregarCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.layoutAgregarCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.layoutAgregarCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.layoutAgregarCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.layoutAgregarCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.layoutAgregarCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.layoutAgregarCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.layoutAgregarCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.layoutAgregarCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.layoutAgregarCliente.Size = new System.Drawing.Size(912, 525);
			this.layoutAgregarCliente.TabIndex = 2;
			this.layoutAgregarCliente.Visible = false;
			// 
			// labelCompletarDatos
			// 
			this.labelCompletarDatos.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCompletarDatos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCompletarDatos.Location = new System.Drawing.Point(3, 0);
			this.labelCompletarDatos.Name = "labelCompletarDatos";
			this.labelCompletarDatos.Size = new System.Drawing.Size(906, 105);
			this.labelCompletarDatos.TabIndex = 0;
			this.labelCompletarDatos.Text = "Complete los siguientes datos:";
			this.labelCompletarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelNombre
			// 
			this.labelNombre.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNombre.Location = new System.Drawing.Point(3, 105);
			this.labelNombre.Name = "labelNombre";
			this.labelNombre.Size = new System.Drawing.Size(906, 52);
			this.labelNombre.TabIndex = 1;
			this.labelNombre.Text = "Nombre:";
			this.labelNombre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// labelApellido
			// 
			this.labelApellido.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelApellido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelApellido.Location = new System.Drawing.Point(3, 209);
			this.labelApellido.Name = "labelApellido";
			this.labelApellido.Size = new System.Drawing.Size(906, 52);
			this.labelApellido.TabIndex = 2;
			this.labelApellido.Text = "Apellido:";
			this.labelApellido.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// labelFechaNacimiento
			// 
			this.labelFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFechaNacimiento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFechaNacimiento.Location = new System.Drawing.Point(3, 313);
			this.labelFechaNacimiento.Name = "labelFechaNacimiento";
			this.labelFechaNacimiento.Size = new System.Drawing.Size(906, 52);
			this.labelFechaNacimiento.TabIndex = 3;
			this.labelFechaNacimiento.Text = "Fecha de Nacimiento (DD/MM/AAAA):";
			this.labelFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxNombre.Location = new System.Drawing.Point(3, 160);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(906, 22);
			this.textBoxNombre.TabIndex = 4;
			this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxNombre.TextChanged += new System.EventHandler(this.TextBoxNombreTextChanged);
			// 
			// textBoxApellido
			// 
			this.textBoxApellido.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxApellido.Enabled = false;
			this.textBoxApellido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxApellido.Location = new System.Drawing.Point(3, 264);
			this.textBoxApellido.Name = "textBoxApellido";
			this.textBoxApellido.Size = new System.Drawing.Size(906, 22);
			this.textBoxApellido.TabIndex = 5;
			this.textBoxApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxApellido.TextChanged += new System.EventHandler(this.TextBoxApellidoTextChanged);
			// 
			// textBoxFechaNacimiento
			// 
			this.textBoxFechaNacimiento.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxFechaNacimiento.Enabled = false;
			this.textBoxFechaNacimiento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxFechaNacimiento.Location = new System.Drawing.Point(3, 368);
			this.textBoxFechaNacimiento.Name = "textBoxFechaNacimiento";
			this.textBoxFechaNacimiento.Size = new System.Drawing.Size(906, 22);
			this.textBoxFechaNacimiento.TabIndex = 6;
			this.textBoxFechaNacimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxFechaNacimiento.TextChanged += new System.EventHandler(this.TextBoxFechaNacimientoTextChanged);
			// 
			// btnAgregarCliente
			// 
			this.btnAgregarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnAgregarCliente.Enabled = false;
			this.btnAgregarCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarCliente.Location = new System.Drawing.Point(402, 420);
			this.btnAgregarCliente.Name = "btnAgregarCliente";
			this.btnAgregarCliente.Size = new System.Drawing.Size(107, 46);
			this.btnAgregarCliente.TabIndex = 7;
			this.btnAgregarCliente.Text = "Agregar Cliente";
			this.btnAgregarCliente.UseVisualStyleBackColor = true;
			this.btnAgregarCliente.Click += new System.EventHandler(this.BtnAgregarClienteClick);
			// 
			// btnCancelar2
			// 
			this.btnCancelar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnCancelar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar2.Location = new System.Drawing.Point(402, 472);
			this.btnCancelar2.Name = "btnCancelar2";
			this.btnCancelar2.Size = new System.Drawing.Size(107, 50);
			this.btnCancelar2.TabIndex = 8;
			this.btnCancelar2.Text = "Cancelar";
			this.btnCancelar2.UseVisualStyleBackColor = true;
			this.btnCancelar2.Click += new System.EventHandler(this.BtnCancelar2Click);
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
			this.Column2.HeaderText = "Banco";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText = "Cuotas";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column4.HeaderText = "Interés";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// ClienteyPagoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(912, 525);
			this.Controls.Add(this.layoutAgregarCliente);
			this.Controls.Add(this.layoutPago);
			this.Controls.Add(this.layoutIngresoDNI);
			this.Name = "ClienteyPagoForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Identificar Cliente";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClienteyPagoFormFormClosed);
			this.Load += new System.EventHandler(this.ClienteyPagoFormLoad);
			this.layoutIngresoDNI.ResumeLayout(false);
			this.layoutIngresoDNI.PerformLayout();
			this.layoutPago.ResumeLayout(false);
			this.layoutTarjetasyPago.ResumeLayout(false);
			this.layoutSelectTarjeta.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTarjetas)).EndInit();
			this.layoutAgregarCliente.ResumeLayout(false);
			this.layoutAgregarCliente.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
