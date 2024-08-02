using System;
using System.Drawing;
using System.Windows.Forms;

namespace TiendaOnline
{
	public partial class BonificarTarjetaForm : Form
	{
		int cuota, interes;
		string nombre, banco;
		
		public BonificarTarjetaForm( string nombre, string banco )
		{
			InitializeComponent();
			this.nombre = nombre;
			this.banco = banco;
		}
		
		void BonificarTarjetaFormLoad(object sender, EventArgs e)
		{
			labelTarjeta.Text += nombre + " Banco: " + banco;
		}
		
		void BtnAgregarBeneficioClick(object sender, EventArgs e)
		{
			try{
				cuota = int.Parse(textCuota.Text);
				interes = int.Parse(textInteres.Text);
				
				this.Dispose();
			}
			catch( Exception ){
				textCuota.Clear();
				textInteres.Clear();
				MessageBox.Show("Error. Verifique e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public int CUOTA{ get{ return cuota; } }
		public int INTERES{ get{ return interes; } }
		
		void BonificarTarjetaFormFormClosed(object sender, FormClosedEventArgs e)
		{
			try{
				if( e.CloseReason == CloseReason.UserClosing )
					throw new OperacionCanceladaException();
			}
			catch( OperacionCanceladaException ){
				MessageBox.Show("Operación cancelada !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
