using System;
using System.Drawing;
using System.Windows.Forms;

namespace TiendaOnline
{
	public partial class PromocionarProductoForm : Form
	{
		int nuevoDescuento;
		Producto prod;
		
		public PromocionarProductoForm( Producto prod )
		{
			InitializeComponent();
			this.prod = prod;
		}
		
		void PromocionarProductoFormLoad(object sender, EventArgs e)
		{
			dataGridView1.Rows.Add( prod.TIPO, prod.MARCA, prod.TALLE, "$"+prod.PRECIO, prod.DESCUENTO+"%" );
			labelValorDescActual.Text = prod.DESCUENTO+"%";
		}
		
		void ButtPromocionarClick(object sender, EventArgs e)
		{
			try{
				nuevoDescuento = int.Parse( textBoxValorDesc.Text );
				this.Dispose();
			}
			catch( Exception ){
				textBoxValorDesc.Clear();
				MessageBox.Show("Error. Verifique e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public int NUEVODESCUENTO{ get { return nuevoDescuento; } }
		
		void PromocionarProductoFormFormClosed(object sender, FormClosedEventArgs e)
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
