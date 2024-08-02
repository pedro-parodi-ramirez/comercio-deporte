using System;
using System.Drawing;
using System.Windows.Forms;

namespace TiendaOnline
{
	public partial class AgregarProdCarroForm : Form
	{
		int indiceProducto;
		int cantidad; // cantidad de productos a comprar
		int cantProdDisponibles; // cantidad de productos disponibles en la tienda
		
		public AgregarProdCarroForm( DataGridView listaProductos, int cantProdDisponibles )
		{
			InitializeComponent();
			
			for( int i = 0; i < cantProdDisponibles; i++ ){
				dataGridView1.Rows.Add( listaProductos.Rows[i].Cells[0].Value,
				                       listaProductos.Rows[i].Cells[1].Value,
				                       listaProductos.Rows[i].Cells[2].Value,
				                       listaProductos.Rows[i].Cells[3].Value,
				                       listaProductos.Rows[i].Cells[4].Value );
			}
			
			this.cantProdDisponibles = cantProdDisponibles;
		}
		
		void BtnAgregarProdCarroClick(object sender, EventArgs e)
		{
			try{
				indiceProducto = dataGridView1.CurrentRow.Index;
				cantidad = int.Parse(textBoxCantidad.Text);
				this.Dispose();
			}
			catch( Exception ){
				textBoxCantidad.Clear();
				indiceProducto = -1;
				MessageBox.Show("Error. Verifique e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		public int INDICEPRODUCTO{ get{ return indiceProducto; } }
		public int CANTIDAD{ get{ return cantidad; } }
		
		void AgregarProdCarroFormFormClosed(object sender, FormClosedEventArgs e)
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
