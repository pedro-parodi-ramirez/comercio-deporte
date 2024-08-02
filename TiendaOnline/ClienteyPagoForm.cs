using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TiendaOnline
{
	public partial class ClienteyPagoForm : Form
	{
		Tienda SitandBuy = new Tienda();
		Carro Carrito = new Carro();
		List<Tarjeta> tarjetasDuplicado;
		List<List<FormaDePago>> formasDePagoDuplicado;
		
		public ClienteyPagoForm( Tienda SitandBuy, Carro Carrito, List<Tarjeta> tarjetasDuplicado, List<List<FormaDePago>> formasDePagoDuplicado){
			InitializeComponent();
			this.Size = new System.Drawing.Size(256, 210);
			this.SitandBuy = SitandBuy;
			this.Carrito = Carrito;
			this.tarjetasDuplicado = tarjetasDuplicado;
			this.formasDePagoDuplicado = formasDePagoDuplicado;
		}
		
		public ClienteyPagoForm(){}
		
		void ClienteyPagoFormLoad(object sender, EventArgs e)
		{
			for(int i = 0; i < tarjetasDuplicado.Count; i++){
				dataGridViewTarjetas.Rows.Add( tarjetasDuplicado[i].NOMBRE, tarjetasDuplicado[i].BANCO );
				
				for( int j = 0; j < formasDePagoDuplicado[i].Count; j++ ){
					dataGridViewTarjetas.Rows.Add( "", "", formasDePagoDuplicado[i][j].CUOTAS, formasDePagoDuplicado[i][j].INTERES+"%" );
				}
			}
			foreach(Tarjeta t in tarjetasDuplicado){
				comboBoxTarjetas.Items.Add(t.NOMBRE);
			}
		}
		
		void ComboBoxTarjetasSelectedIndexChanged(object sender, EventArgs e)
		{
			comboBoxCuotas.Items.Clear();
			comboBoxCuotas.Text = null;
			foreach(FormaDePago f in formasDePagoDuplicado[comboBoxTarjetas.SelectedIndex]){
				comboBoxCuotas.Items.Add(f.CUOTAS);
			}
		}
		
		void ComboBoxCuotasSelectedIndexChanged(object sender, EventArgs e)
		{
			btnComprar.Enabled = true;
		}
		
		void ButtoOkDNIClick(object sender, EventArgs e)
		{
			layoutIngresoDNI.Enabled = false;
			layoutIngresoDNI.Visible = false;
			int dni = int.Parse(textBoxDNI.Text);
				
			Cliente clienteCompra = SitandBuy.buscarCliente( dni );
			if( clienteCompra != null ){
				MessageBox.Show("CLIENTE EXISTENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				labelInfoCliente.Text = string.Format("Cliente: Nombre={0}, Apellido={1}, DNI={2:N0}, Nacimiento={3}, Total Gastado= {4:C}",
										                  clienteCompra.NOMBRE, 
										                  clienteCompra.APELLIDO, 
										                  clienteCompra.DNI, 
										                  clienteCompra.FECHANACIMIENTO.ToShortDateString(), 
										                  clienteCompra.TOTALGASTADO);
				
				this.Text = "Realizar Pago";
				this.Size = new System.Drawing.Size(928, 564);
				comboBoxTarjetas.Size = new System.Drawing.Size(120, 21);
				comboBoxCuotas.Size = new System.Drawing.Size(120, 21);
				layoutPago.Enabled = true;
				layoutPago.Visible = true;
				
				labelTotalCompra.Text += string.Format("{0:C}", Carrito.TOTALPAGO);
			}
			else{
				this.Text = "Registrar Cliente";
				MessageBox.Show("NUEVO CLIENTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
				this.Size = new System.Drawing.Size(400, 484);
				layoutAgregarCliente.Enabled = true;
				layoutAgregarCliente.Visible = true;
			}
		}
		
		void ClienteyPagoFormFormClosed(object sender, FormClosedEventArgs e)
		{
			try{
				if( e.CloseReason == CloseReason.UserClosing )
					throw new OperacionCanceladaException();
			}
			catch( OperacionCanceladaException ){
				MessageBox.Show("Operación cancelada !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		void TextBoxNombreTextChanged(object sender, EventArgs e)
		{
			textBoxApellido.Enabled = true;
		}
		
		void TextBoxApellidoTextChanged(object sender, EventArgs e)
		{
			textBoxFechaNacimiento.Enabled = true;
		}
		
		void TextBoxFechaNacimientoTextChanged(object sender, EventArgs e)
		{
			btnAgregarCliente.Enabled = true;
		}
		
		void BtnAgregarClienteClick(object sender, EventArgs e)
		{
			try{
				string nombre = textBoxNombre.Text.ToUpperInvariant();
				string apellido = textBoxApellido.Text.ToUpperInvariant();
				int dni = int.Parse(textBoxDNI.Text);
				DateTime fechaNacimiento = DateTime.Parse(textBoxFechaNacimiento.Text);
				
				SitandBuy.agregarCliente(nombre, apellido, fechaNacimiento, dni);
				MessageBox.Show("CLIENTE AGREGADO.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
				labelInfoCliente.Text = string.Format("Cliente: Nombre={0}, Apellido={1}, DNI={2}, Nacimiento={3}, Total Gastado=${4:F2}",
	                  nombre, 
	                  apellido, 
	                  dni, 
	                  fechaNacimiento.ToShortDateString(), 
	                  0F);
				
				this.Text = "Realizar Pago";
				this.Size = new System.Drawing.Size(928, 564);
				comboBoxTarjetas.Size = new System.Drawing.Size(120, 21);
				comboBoxCuotas.Size = new System.Drawing.Size(120, 21);
				layoutPago.Enabled = true;
				layoutPago.Visible = true;
				
				labelTotalCompra.Text += string.Format("{0:C}", Carrito.TOTALPAGO);
				
				layoutAgregarCliente.Enabled = false;
				layoutAgregarCliente.Visible = false;
			}
			catch( Exception )
			{
				textBoxNombre.Clear();
				textBoxApellido.Clear();
				textBoxFechaNacimiento.Clear();
				MessageBox.Show("Error. Verifique e intente nuevamente !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
		}
		
		void BtnComprarClick(object sender, EventArgs e)
		{
			try{
				int opcionTarjeta = comboBoxTarjetas.SelectedIndex;
				int cuotas = int.Parse(comboBoxCuotas.SelectedItem.ToString());
				int interes = tarjetasDuplicado[opcionTarjeta][cuotas];
				int dni = int.Parse(textBoxDNI.Text);
				
				// tarjetasDuplicado posee un indexador que devuelve el interés asociado a la cantidad de cuotas
				// pasada como parámetro o devuelve '-1' si no se encontró dicha cantidad de cuotas
				if( interes == -1 ){
					throw new Exception();
				}
				else{
					MessageBox.Show(string.Format("En {0} cuotas tiene un interés de {1}%", cuotas, interes), 
					                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
					DialogResult opcionCompra = MessageBox.Show(string.Format("El precio total financiado es de ${0:F2}, en {1} cuotas de ${2:F2}. ¿Confirmar compra?",
																Carrito.TOTALPAGO * (1 + interes/100.0),
																cuotas,
																Carrito.TOTALPAGO * (1 + interes/100.0) / cuotas),
																"Aviso", MessageBoxButtons.YesNo);
				
					
					if( opcionCompra == DialogResult.Yes ){
						SitandBuy.actualizarVentas( Carrito.TOTALPAGO * (1 + interes/100.0), opcionTarjeta, dni );
						MessageBox.Show("Compra realizada !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
						Carrito.vaciarCarro();
					}
					else
						throw new OperacionCanceladaException();
					this.Dispose();
				}
			}
			catch( OperacionCanceladaException ){
				this.Dispose();
				MessageBox.Show("Operación cancelada !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch( Exception ){
				MessageBox.Show("Error. Verifique e intente nuevamente !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
		}
		void BtnCancelar2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnCancelar3Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void BtnCancelar1Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
