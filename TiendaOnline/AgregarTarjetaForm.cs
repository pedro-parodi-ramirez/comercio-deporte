using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace TiendaOnline
{
	public partial class AgregarTarjetaForm : Form
	{
		string nombre, banco;
		int cantFormasPago, i = 1;
		List<int> listaCuotas = new List<int>();
		List<int> listaIntereses = new List<int>();
		
		public AgregarTarjetaForm()
		{
			InitializeComponent();
		}
		
		void checkValues(){
			nombre = textBoxNombre.Text.ToUpperInvariant();
			banco = textBoxBanco.Text.ToUpperInvariant();
			cantFormasPago = int.Parse(textBoxFormasPago.Text);
			
			if( nombre == "" || banco == "" )
				throw new Exception();
			else{
				if( cantFormasPago == 0 ){
					throw new Exception();
				}
				
				if( cantFormasPago == 1 )
					btnOkFormasPago.Text = "Agregar Tarjeta";
				
				labelTitulo.Text = string.Format("Para forma de pago #{0}, ingrese:", i);
				
				layoutTarjeta.Enabled = false;
				layoutTarjeta.Visible = false;
				
				layoutFormasPago.Enabled = true;
				layoutFormasPago.Visible = true;
			}
		}
		
		
		void ButtonOkClick(object sender, EventArgs e)
		{
			try{
				checkValues();
//				nombre = textBoxNombre.Text.ToUpperInvariant();
//				banco = textBoxBanco.Text.ToUpperInvariant();
//				cantFormasPago = int.Parse(textBoxFormasPago.Text);
//				
//				if( nombre == "" || banco == "" )
//					throw new Exception();
//				else{
//					if( cantFormasPago == 0 ){
//						throw new Exception();
//					}
//					
//					if( cantFormasPago == 1 )
//						btnOkFormasPago.Text = "Agregar Tarjeta";
//					
//					labelTitulo.Text = string.Format("Para forma de pago #{0}, ingrese:", i);
//					
//					layoutTarjeta.Enabled = false;
//					layoutTarjeta.Visible = false;
//					
//					layoutFormasPago.Enabled = true;
//					layoutFormasPago.Visible = true;
//				}
			}
			catch( Exception ){
				textBoxNombre.Clear();
				textBoxBanco.Clear();
				textBoxFormasPago.Clear();
				MessageBox.Show("Error. Verifique e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void BtnOkFormasPagoClick(object sender, EventArgs e)
		{
			try{
				int cuotas = int.Parse(textBoxCuota.Text);
				int interes = int.Parse(textBoxInteres.Text);
				
				if( cuotas <= 0 || interes < 0 ){ throw new Exception(); }
				else if( listaCuotas.Contains( cuotas ) ){ throw new Exception(); }
				
				listaCuotas.Add( cuotas );
				listaIntereses.Add( interes );
					
				textBoxCuota.Clear();
				textBoxInteres.Clear();
					
				i++;
				if( i == cantFormasPago )
					btnOkFormasPago.Text = "Agregar Tarjeta";
				else if ( i > cantFormasPago )
					this.Dispose();
				
				labelTitulo.Text = string.Format("Para forma de pago #{0}, ingrese:", i);
			}
			catch( Exception ){
				textBoxCuota.Clear();
				textBoxInteres.Clear();
				MessageBox.Show("Error. Verifique e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public string NOMBRE{ get{ return nombre; } }
		public string BANCO{ get{ return banco; } }
		public int CANTFORMASPAGO{ get{ return cantFormasPago; } }
		public List<int> CUOTAS{ get{ return listaCuotas; } }
		public List<int> INTERESES{ get{ return listaIntereses; } }
		
		void TextBoxNombreTextChanged(object sender, EventArgs e)
		{
			if( textBoxNombre.Text != "" )
				textBoxBanco.Enabled = true;
		}
		
		void TextBoxBancoTextChanged(object sender, EventArgs e)
		{
			if( textBoxBanco.Text != "" )
				textBoxFormasPago.Enabled = true;
		}
		
		void TextBoxFormasPagoTextChanged(object sender, EventArgs e)
		{
			btnOk.Enabled = true;
		}
		
		void TextBoxCuotaTextChanged(object sender, EventArgs e)
		{
			textBoxInteres.Enabled = true;
		}
		
		void TextBoxInteresTextChanged(object sender, EventArgs e)
		{
			btnOkFormasPago.Enabled = true;
		}
		
		void AgregarTarjetaFormFormClosed(object sender, FormClosedEventArgs e)
		{
			try{
				if( e.CloseReason == CloseReason.UserClosing ){
					throw new OperacionCanceladaException();
				}
			}
			catch( OperacionCanceladaException ){
				checkValues();
			}
		}
		
		void BtnCancelar1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtnCancelar2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		
	}
	
}
