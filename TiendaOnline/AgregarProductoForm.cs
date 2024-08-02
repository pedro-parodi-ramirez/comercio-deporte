using System;
using System.Drawing;
using System.Windows.Forms;

namespace TiendaOnline
{
	public partial class AgregarProductoForm : Form
	{
		Producto p = null;
		
		public AgregarProductoForm()
		{
			InitializeComponent();
		}
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			float precio;
			if( !float.TryParse( textBoxPrecio.Text, out precio ) ){
				textBoxPrecio.Clear();
				MessageBox.Show("Error. Verifique e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else{
				p = new Producto( textBoxTipo.Text.ToUpperInvariant(), textBoxMarca.Text.ToUpperInvariant(), textBoxTalle.Text.ToUpperInvariant(), precio );
				this.Dispose();
			}
		}
		
		public Producto NUEVOPRODUCTO{ get { return p; } }
		
		void TextBoxTipoTextChanged(object sender, EventArgs e)
		{
			if( textBoxTipo.Text != "" )
				textBoxMarca.Enabled = true;
		}
		
		void TextBoxMarcaTextChanged(object sender, EventArgs e)
		{
			if( textBoxMarca.Text != "" )
				textBoxTalle.Enabled = true;
		}
		
		void TextBoxTalleTextChanged(object sender, EventArgs e)
		{
			if( textBoxTalle.Text != "" )
				textBoxPrecio.Enabled = true;
		}
		
		void TextBoxPrecioTextChanged(object sender, EventArgs e)
		{
			btnAgregar.Enabled = true;
		}
		
		void AgregarProductoFormFormClosed(object sender, FormClosedEventArgs e)
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
