/*
 * Created by SharpDevelop.
 * User: PETER
 * Date: 10/12/2018
 * Time: 1:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TiendaOnline
{
	partial class BonificarTarjetaForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label labelTitulo;
		private System.Windows.Forms.TableLayoutPanel layoutBonificarTarjeta;
		private System.Windows.Forms.Label labelCuotas;
		private System.Windows.Forms.Label labelInteres;
		private System.Windows.Forms.Button btnAgregarBeneficio;
		private System.Windows.Forms.TextBox textCuota;
		private System.Windows.Forms.TextBox textInteres;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Label labelTarjeta;
		
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
			this.layoutBonificarTarjeta = new System.Windows.Forms.TableLayoutPanel();
			this.labelCuotas = new System.Windows.Forms.Label();
			this.labelInteres = new System.Windows.Forms.Label();
			this.btnAgregarBeneficio = new System.Windows.Forms.Button();
			this.textCuota = new System.Windows.Forms.TextBox();
			this.textInteres = new System.Windows.Forms.TextBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.labelTarjeta = new System.Windows.Forms.Label();
			this.layoutBonificarTarjeta.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTitulo
			// 
			this.labelTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTitulo.Location = new System.Drawing.Point(3, 66);
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Size = new System.Drawing.Size(459, 67);
			this.labelTitulo.TabIndex = 0;
			this.labelTitulo.Text = "Complete los siguientes datos:";
			this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// layoutBonificarTarjeta
			// 
			this.layoutBonificarTarjeta.ColumnCount = 1;
			this.layoutBonificarTarjeta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layoutBonificarTarjeta.Controls.Add(this.labelCuotas, 0, 2);
			this.layoutBonificarTarjeta.Controls.Add(this.labelInteres, 0, 4);
			this.layoutBonificarTarjeta.Controls.Add(this.btnAgregarBeneficio, 0, 6);
			this.layoutBonificarTarjeta.Controls.Add(this.textCuota, 0, 3);
			this.layoutBonificarTarjeta.Controls.Add(this.textInteres, 0, 5);
			this.layoutBonificarTarjeta.Controls.Add(this.btnCancelar, 0, 7);
			this.layoutBonificarTarjeta.Controls.Add(this.labelTitulo, 0, 1);
			this.layoutBonificarTarjeta.Controls.Add(this.labelTarjeta, 0, 0);
			this.layoutBonificarTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutBonificarTarjeta.Location = new System.Drawing.Point(0, 0);
			this.layoutBonificarTarjeta.Name = "layoutBonificarTarjeta";
			this.layoutBonificarTarjeta.RowCount = 8;
			this.layoutBonificarTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
			this.layoutBonificarTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.layoutBonificarTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
			this.layoutBonificarTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
			this.layoutBonificarTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
			this.layoutBonificarTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
			this.layoutBonificarTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.layoutBonificarTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
			this.layoutBonificarTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutBonificarTarjeta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layoutBonificarTarjeta.Size = new System.Drawing.Size(465, 402);
			this.layoutBonificarTarjeta.TabIndex = 1;
			// 
			// labelCuotas
			// 
			this.labelCuotas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCuotas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCuotas.Location = new System.Drawing.Point(3, 133);
			this.labelCuotas.Name = "labelCuotas";
			this.labelCuotas.Size = new System.Drawing.Size(459, 33);
			this.labelCuotas.TabIndex = 1;
			this.labelCuotas.Text = "Cantidad de Cuotas:";
			this.labelCuotas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelInteres
			// 
			this.labelInteres.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelInteres.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelInteres.Location = new System.Drawing.Point(3, 199);
			this.labelInteres.Name = "labelInteres";
			this.labelInteres.Size = new System.Drawing.Size(459, 33);
			this.labelInteres.TabIndex = 2;
			this.labelInteres.Text = "Interés:";
			this.labelInteres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnAgregarBeneficio
			// 
			this.btnAgregarBeneficio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnAgregarBeneficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarBeneficio.Location = new System.Drawing.Point(157, 268);
			this.btnAgregarBeneficio.Name = "btnAgregarBeneficio";
			this.btnAgregarBeneficio.Size = new System.Drawing.Size(150, 61);
			this.btnAgregarBeneficio.TabIndex = 3;
			this.btnAgregarBeneficio.Text = "Agregar Beneficio";
			this.btnAgregarBeneficio.UseVisualStyleBackColor = true;
			this.btnAgregarBeneficio.Click += new System.EventHandler(this.BtnAgregarBeneficioClick);
			// 
			// textCuota
			// 
			this.textCuota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.textCuota.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textCuota.Location = new System.Drawing.Point(118, 169);
			this.textCuota.Name = "textCuota";
			this.textCuota.Size = new System.Drawing.Size(228, 21);
			this.textCuota.TabIndex = 5;
			this.textCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// textInteres
			// 
			this.textInteres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.textInteres.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textInteres.Location = new System.Drawing.Point(118, 235);
			this.textInteres.Name = "textInteres";
			this.textInteres.Size = new System.Drawing.Size(228, 21);
			this.textInteres.TabIndex = 6;
			this.textInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnCancelar
			// 
			this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancelar.Location = new System.Drawing.Point(157, 335);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(150, 64);
			this.btnCancelar.TabIndex = 7;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// labelTarjeta
			// 
			this.labelTarjeta.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTarjeta.Location = new System.Drawing.Point(3, 0);
			this.labelTarjeta.Name = "labelTarjeta";
			this.labelTarjeta.Size = new System.Drawing.Size(459, 66);
			this.labelTarjeta.TabIndex = 9;
			this.labelTarjeta.Text = "Tarjeta: ";
			this.labelTarjeta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BonificarTarjetaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(465, 402);
			this.Controls.Add(this.layoutBonificarTarjeta);
			this.Name = "BonificarTarjetaForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bonificar Tarjeta";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BonificarTarjetaFormFormClosed);
			this.Load += new System.EventHandler(this.BonificarTarjetaFormLoad);
			this.layoutBonificarTarjeta.ResumeLayout(false);
			this.layoutBonificarTarjeta.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
