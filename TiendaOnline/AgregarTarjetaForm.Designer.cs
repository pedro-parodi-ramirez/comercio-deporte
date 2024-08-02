/*
 * Created by SharpDevelop.
 * User: PETER
 * Date: 09/12/2018
 * Time: 22:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TiendaOnline
{
	partial class AgregarTarjetaForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.TableLayoutPanel layoutTarjeta;
		private System.Windows.Forms.Label labelNombre;
		private System.Windows.Forms.Label labelBanco;
		private System.Windows.Forms.TextBox textBoxNombre;
		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.TextBox textBoxBanco;
		private System.Windows.Forms.Label labelFormasPago;
		private System.Windows.Forms.TextBox textBoxFormasPago;
		private System.Windows.Forms.TableLayoutPanel layoutFormasPago;
		private System.Windows.Forms.TextBox textBoxInteres;
		private System.Windows.Forms.Button btnOkFormasPago;
		private System.Windows.Forms.Label labelInteres;
		private System.Windows.Forms.TextBox textBoxCuota;
		private System.Windows.Forms.Label labelCuota;
		private System.Windows.Forms.Button btnCancelar1;
		private System.Windows.Forms.Button btnCancelar2;
		
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
			this.labelTitulo = new System.Windows.Forms.Label();
			this.layoutTarjeta = new System.Windows.Forms.TableLayoutPanel();
			this.labelNombre = new System.Windows.Forms.Label();
			this.labelBanco = new System.Windows.Forms.Label();
			this.textBoxNombre = new System.Windows.Forms.TextBox();
			this.textBoxBanco = new System.Windows.Forms.TextBox();
			this.labelFormasPago = new System.Windows.Forms.Label();
			this.textBoxFormasPago = new System.Windows.Forms.TextBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancelar1 = new System.Windows.Forms.Button();
			this.layoutFormasPago = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxInteres = new System.Windows.Forms.TextBox();
			this.btnOkFormasPago = new System.Windows.Forms.Button();
			this.labelInteres = new System.Windows.Forms.Label();
			this.textBoxCuota = new System.Windows.Forms.TextBox();
			this.labelCuota = new System.Windows.Forms.Label();
			this.btnCancelar2 = new System.Windows.Forms.Button();
			this.layoutTarjeta.SuspendLayout();
			this.layoutFormasPago.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTitulo
			// 
			this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitulo.Location = new System.Drawing.Point(0, 0);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(267, 64);
			this.labelTitulo.TabIndex = 0;
			this.labelTitulo.Text = "Ingrese datos de Tarjeta: ";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// layoutTarjeta
			// 
			this.layoutTarjeta.ColumnCount = 1;
			this.layoutTarjeta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutTarjeta.Controls.Add(this.labelNombre, 0, 0);
			this.layoutTarjeta.Controls.Add(this.labelBanco, 0, 2);
			this.layoutTarjeta.Controls.Add(this.textBoxNombre, 0, 1);
			this.layoutTarjeta.Controls.Add(this.textBoxBanco, 0, 3);
			this.layoutTarjeta.Controls.Add(this.labelFormasPago, 0, 4);
			this.layoutTarjeta.Controls.Add(this.textBoxFormasPago, 0, 5);
			this.layoutTarjeta.Controls.Add(this.btnOk, 0, 6);
			this.layoutTarjeta.Controls.Add(this.btnCancelar1, 0, 7);
			this.layoutTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutTarjeta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.layoutTarjeta.Location = new System.Drawing.Point(0, 64);
			this.layoutTarjeta.Name = "layoutTarjeta";
			this.layoutTarjeta.RowCount = 8;
			this.layoutTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.layoutTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.layoutTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.layoutTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.layoutTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.layoutTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.layoutTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.layoutTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
			this.layoutTarjeta.Size = new System.Drawing.Size(267, 269);
			this.layoutTarjeta.TabIndex = 1;
			// 
			// labelNombre
			// 
			this.labelNombre.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelNombre.Location = new System.Drawing.Point(3, 0);
			this.labelNombre.Name = "labelNombre";
			this.labelNombre.Size = new System.Drawing.Size(261, 33);
			this.labelNombre.TabIndex = 0;
			this.labelNombre.Text = "Nombre";
			this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelBanco
			// 
			this.labelBanco.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBanco.Location = new System.Drawing.Point(3, 66);
			this.labelBanco.Name = "labelBanco";
			this.labelBanco.Size = new System.Drawing.Size(261, 33);
			this.labelBanco.TabIndex = 1;
			this.labelBanco.Text = "Banco";
			this.labelBanco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxNombre
			// 
			this.textBoxNombre.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxNombre.Location = new System.Drawing.Point(3, 36);
			this.textBoxNombre.Name = "textBoxNombre";
			this.textBoxNombre.Size = new System.Drawing.Size(261, 21);
			this.textBoxNombre.TabIndex = 2;
			this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxNombre.TextChanged += new System.EventHandler(this.TextBoxNombreTextChanged);
			// 
			// textBoxBanco
			// 
			this.textBoxBanco.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxBanco.Enabled = false;
			this.textBoxBanco.Location = new System.Drawing.Point(3, 102);
			this.textBoxBanco.Name = "textBoxBanco";
			this.textBoxBanco.Size = new System.Drawing.Size(261, 21);
			this.textBoxBanco.TabIndex = 3;
			this.textBoxBanco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxBanco.TextChanged += new System.EventHandler(this.TextBoxBancoTextChanged);
			// 
			// labelFormasPago
			// 
			this.labelFormasPago.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelFormasPago.Location = new System.Drawing.Point(3, 132);
			this.labelFormasPago.Name = "labelFormasPago";
			this.labelFormasPago.Size = new System.Drawing.Size(261, 33);
			this.labelFormasPago.TabIndex = 4;
			this.labelFormasPago.Text = "Cantidad de Formas de Pago";
			this.labelFormasPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxFormasPago
			// 
			this.textBoxFormasPago.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxFormasPago.Enabled = false;
			this.textBoxFormasPago.Location = new System.Drawing.Point(3, 168);
			this.textBoxFormasPago.Name = "textBoxFormasPago";
			this.textBoxFormasPago.Size = new System.Drawing.Size(261, 21);
			this.textBoxFormasPago.TabIndex = 5;
			this.textBoxFormasPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxFormasPago.TextChanged += new System.EventHandler(this.TextBoxFormasPagoTextChanged);
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnOk.Enabled = false;
			this.btnOk.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOk.Location = new System.Drawing.Point(68, 201);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(130, 27);
			this.btnOk.TabIndex = 6;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.ButtonOkClick);
			// 
			// btnCancelar1
			// 
			this.btnCancelar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnCancelar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar1.Location = new System.Drawing.Point(68, 234);
			this.btnCancelar1.Name = "btnCancelar1";
			this.btnCancelar1.Size = new System.Drawing.Size(130, 32);
			this.btnCancelar1.TabIndex = 5;
			this.btnCancelar1.Text = "Cancelar";
			this.btnCancelar1.UseVisualStyleBackColor = true;
			this.btnCancelar1.Click += new System.EventHandler(this.BtnCancelar1Click);
			// 
			// layoutFormasPago
			// 
			this.layoutFormasPago.ColumnCount = 1;
			this.layoutFormasPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutFormasPago.Controls.Add(this.textBoxInteres, 0, 3);
			this.layoutFormasPago.Controls.Add(this.btnOkFormasPago, 0, 4);
			this.layoutFormasPago.Controls.Add(this.labelInteres, 0, 2);
			this.layoutFormasPago.Controls.Add(this.textBoxCuota, 0, 1);
			this.layoutFormasPago.Controls.Add(this.labelCuota, 0, 0);
			this.layoutFormasPago.Controls.Add(this.btnCancelar2, 0, 5);
			this.layoutFormasPago.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutFormasPago.Enabled = false;
			this.layoutFormasPago.Location = new System.Drawing.Point(0, 64);
			this.layoutFormasPago.Name = "layoutFormasPago";
			this.layoutFormasPago.RowCount = 6;
			this.layoutFormasPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.layoutFormasPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.layoutFormasPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.layoutFormasPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.layoutFormasPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.layoutFormasPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.layoutFormasPago.Size = new System.Drawing.Size(267, 269);
			this.layoutFormasPago.TabIndex = 2;
			this.layoutFormasPago.Visible = false;
			// 
			// textBoxInteres
			// 
			this.textBoxInteres.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxInteres.Enabled = false;
			this.textBoxInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxInteres.Location = new System.Drawing.Point(3, 135);
			this.textBoxInteres.Name = "textBoxInteres";
			this.textBoxInteres.Size = new System.Drawing.Size(261, 20);
			this.textBoxInteres.TabIndex = 3;
			this.textBoxInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxInteres.TextChanged += new System.EventHandler(this.TextBoxInteresTextChanged);
			// 
			// btnOkFormasPago
			// 
			this.btnOkFormasPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnOkFormasPago.Enabled = false;
			this.btnOkFormasPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOkFormasPago.Location = new System.Drawing.Point(68, 179);
			this.btnOkFormasPago.Name = "btnOkFormasPago";
			this.btnOkFormasPago.Size = new System.Drawing.Size(130, 38);
			this.btnOkFormasPago.TabIndex = 4;
			this.btnOkFormasPago.Text = "Ok";
			this.btnOkFormasPago.UseVisualStyleBackColor = true;
			this.btnOkFormasPago.Click += new System.EventHandler(this.BtnOkFormasPagoClick);
			// 
			// labelInteres
			// 
			this.labelInteres.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelInteres.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInteres.Location = new System.Drawing.Point(3, 88);
			this.labelInteres.Name = "labelInteres";
			this.labelInteres.Size = new System.Drawing.Size(261, 44);
			this.labelInteres.TabIndex = 1;
			this.labelInteres.Text = "Interés";
			this.labelInteres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBoxCuota
			// 
			this.textBoxCuota.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxCuota.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxCuota.Location = new System.Drawing.Point(3, 47);
			this.textBoxCuota.Name = "textBoxCuota";
			this.textBoxCuota.Size = new System.Drawing.Size(261, 20);
			this.textBoxCuota.TabIndex = 2;
			this.textBoxCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxCuota.TextChanged += new System.EventHandler(this.TextBoxCuotaTextChanged);
			// 
			// labelCuota
			// 
			this.labelCuota.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCuota.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCuota.Location = new System.Drawing.Point(3, 0);
			this.labelCuota.Name = "labelCuota";
			this.labelCuota.Size = new System.Drawing.Size(261, 44);
			this.labelCuota.TabIndex = 0;
			this.labelCuota.Text = "Cuota";
			this.labelCuota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnCancelar2
			// 
			this.btnCancelar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnCancelar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar2.Location = new System.Drawing.Point(68, 223);
			this.btnCancelar2.Name = "btnCancelar2";
			this.btnCancelar2.Size = new System.Drawing.Size(130, 43);
			this.btnCancelar2.TabIndex = 5;
			this.btnCancelar2.Text = "Cancelar";
			this.btnCancelar2.UseVisualStyleBackColor = true;
			this.btnCancelar2.Click += new System.EventHandler(this.BtnCancelar2Click);
			// 
			// AgregarTarjetaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(267, 333);
			this.Controls.Add(this.layoutFormasPago);
			this.Controls.Add(this.layoutTarjeta);
			this.Controls.Add(this.labelTitulo);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "AgregarTarjetaForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Agregar Tarjeta";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AgregarTarjetaFormFormClosed);
			this.layoutTarjeta.ResumeLayout(false);
			this.layoutTarjeta.PerformLayout();
			this.layoutFormasPago.ResumeLayout(false);
			this.layoutFormasPago.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
