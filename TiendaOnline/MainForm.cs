using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace TiendaOnline
{
	public partial class MainForm : Form
	{
		string nombreArchivoProductos = "Productos.CSV";
		string nombreArchivoClientes = "Clientes.CSV";
		string nombreArchivoTarjetas = "Tarjetas.CSV";
		
		Tienda SitandBuy = new Tienda();
		Carro Carrito = new Carro();
		
		bool stockProductos; //  para determinar si hay productos registrados
		bool tarjetasRegistradas; // para determinar si hay tarjetas registradas
		bool clientesRegistrados;	// para determinar si hay clientes registradas
		
		public MainForm()
		{
			// LEER BASE DE DATOS
			try{
				leerArchivoProductos(nombreArchivoProductos);
				leerArchivoClientes(nombreArchivoClientes);
				leerArchivoTarjetas(nombreArchivoTarjetas);
			}
			catch( FileNotFoundException ){
				MessageBox.Show( "Error. Archivo no encontrado al leer base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
			catch( Exception ){
				MessageBox.Show( "Error al leer base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
			// FIN LECTURA BASE DE DATOS
			
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			btnListarProductos.PerformClick();
		}
		
		void TabControl1SelectedIndexChanged(object sender, EventArgs e)
		{
			switch( tabControl1.SelectedIndex ){
				case 0: btnListarProductos.PerformClick(); break;
				case 2: btnListarTarjetas.PerformClick(); break;
				case 3: btnVentasCliente.PerformClick(); break;
				default : break;
			}
		}
		
		/*************************************************************************************************************************************/
		/****************************************************** SECCION PRODUCTOS ************************************************************/
		/*************************************************************************************************************************************/
		
		void actualizarListaProductos( List<Producto> prodDuplicado ){
			dataGridViewProdyProm.Rows.Clear();
			
			for(int i = 0; i < prodDuplicado.Count; i++ ){
				dataGridViewProdyProm.Rows.Add(prodDuplicado[i].TIPO,
				                               		prodDuplicado[i].MARCA,
				                               		prodDuplicado[i].TALLE,
				                               		string.Format("{0:C}", prodDuplicado[i].PRECIO),
				                               		prodDuplicado[i].DESCUENTO+"%");
			}
		}
		
		// Sobrecarga del método para usarlo también en la sección de 'Compras'
		void actualizarListaProductos( List<Producto> prodDuplicado, DataGridView lista ){
			lista.Rows.Clear();
			
			for(int i = 0; i < prodDuplicado.Count; i++ ){
				lista.Rows.Add(prodDuplicado[i].TIPO,
				               		prodDuplicado[i].MARCA,
				               		prodDuplicado[i].TALLE,
				               		string.Format("{0:C}", prodDuplicado[i].PRECIO),
				               		prodDuplicado[i].DESCUENTO+"%");
			}
		}
		
		bool actualizarListaProdProm( List<Producto> prodDuplicado ){
			dataGridViewProdyProm.Rows.Clear();
			
			int i = 1, numPromociones = 0;
			foreach( Producto p in prodDuplicado ){
				if( p.DESCUENTO > 0 ){
					dataGridViewProdyProm.Rows.Add(p.TIPO, p.MARCA, p.TALLE, string.Format("{0:C}", prodDuplicado[i].PRECIO), p.DESCUENTO+"%");
					i++;
					numPromociones++;
				}
			}
			
			if( numPromociones == 0)
				return false;
			else
				return true;
		}
		
		void BtnAgregarProdClick(object sender, EventArgs e)
		{
			try{
				AgregarProductoForm f = new AgregarProductoForm();
				f.ShowDialog();
				
				if( f.NUEVOPRODUCTO != null ){
					SitandBuy.agregarProducto(f.NUEVOPRODUCTO);
					MessageBox.Show("PRODUCTO AGREGADO !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				
				// Vuelvo a mostrar en pantalla los productos (actualizados)
				btnListarProductos.PerformClick();
				
				f.Dispose();
			}
			catch( OperacionCanceladaException ){
				MessageBox.Show("Operación cancelada !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch( Exception ){
				MessageBox.Show("Ha ocurrido un error ! Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void BtnAgregarPromClick(object sender, EventArgs e)
		{
			try{
				List<Producto> prodDuplicado = new List<Producto>(); // copia de la lista de productos en tienda
				
				// regenera copia por si se agregaron productos a la tienda
				stockProductos = SitandBuy.verProductosTienda( out prodDuplicado );
				
				if( !stockProductos ){
					MessageBox.Show("No hay productos registrados !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning );
					return;
				}
				else{
					int index = dataGridViewProdyProm.CurrentRow.Index;
					if( (index >= 0) && index < prodDuplicado.Count ){
						PromocionarProductoForm f = new PromocionarProductoForm( prodDuplicado[index] );
						f.ShowDialog();
						
						if( SitandBuy.promocionarProducto( f.NUEVODESCUENTO, index ) )
							MessageBox.Show("DESCUENTO MODIFICADO !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
						else
							MessageBox.Show("Error. Verifique e intente nuevamente !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
						
						f.Dispose();
						
						// Vuelvo a mostrar en pantalla los productos (actualizados)
						btnListarProductos.PerformClick();
					}
			
				}
			}
			catch( OperacionCanceladaException ){
				MessageBox.Show("Operación cancelada !", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			catch( Exception ){
				MessageBox.Show("Ha ocurrido un error ! Intente nuevamente.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		void BtnListarProductosClick(object sender, EventArgs e)
		{
			try{
				btnAgregarProm.Enabled = true;
				btnAgregarProm.BackColor = SystemColors.ControlLight;
				labelProdYPromLista.Text = "Lista de Productos Disponibles";
				
				List<Producto> prodDuplicado = new List<Producto>(); // copia de la lista de productos en tienda
				
				// regenera copia por si se agregaron productos a la tienda
				stockProductos = SitandBuy.verProductosTienda( out prodDuplicado );
				
				if( !stockProductos ){ 
					MessageBox.Show( "No hay productos registrados !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning );
				}
				else{
					actualizarListaProductos( prodDuplicado );
				}
			}
			catch( Exception ){
				MessageBox.Show("Ha ocurrido un error ! Intente nuevamente.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		void BtnListarProdPromClick(object sender, EventArgs e)
		{
			try{
				btnAgregarProm.Enabled = false;
				btnAgregarProm.BackColor = Color.DarkSalmon;
				labelProdYPromLista.Text = "Lista de Productos en Promoción";
				
				List<Producto> prodDuplicado = new List<Producto>(); // copia de la lista de productos en tienda
				
				// regenera copia por si se agregaron productos a la tienda
				stockProductos = SitandBuy.verProductosTienda( out prodDuplicado );
				
				if( !stockProductos ){
					MessageBox.Show( "No hay productos registrados !", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Warning );
				}
				else{
					if( !actualizarListaProdProm( prodDuplicado ) )
						MessageBox.Show( "No se encontraron productos en promocion.", "Aviso", MessageBoxButtons.OK,MessageBoxIcon.Information );
				}
			}
			catch( Exception ){
				MessageBox.Show("Ha ocurrido un error ! Intente nuevamente.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		/*************************************************************************************************************************************/
		/********************************************************* SECCION TARJETAS **********************************************************/
		/*************************************************************************************************************************************/
		
		void actualizarListaTarjetas( List<Tarjeta> t, List<List<FormaDePago>> f ){
			string[] row;
			dataGridViewTarjetas.Rows.Clear();
			
			for(int i = 0; i < t.Count; i++){
				row = new string[]{ t[i].NOMBRE, t[i].BANCO };
				dataGridViewTarjetas.Rows.Add(row);
				
				for( int j = 0; j < f[i].Count; j++ ){
					dataGridViewTarjetas.Rows.Add( "", "", f[i][j].CUOTAS, f[i][j].INTERES+"%" );
				}
			}
		}
		
		void actualizarListaTarjBenef( List<Tarjeta> t, List<List<FormaDePago>> f ){
			int contador = 0;
			string[] row;
			
			dataGridViewTarjetas.Rows.Clear();
			for(int i = 0; i < t.Count; i++){
				if( t[i].BENEFICIO == true ){
					row = new string[]{ t[i].NOMBRE, t[i].BANCO };
					dataGridViewTarjetas.Rows.Add(row);
					
					for( int j = 0; j < f[i].Count; j++ ){
						dataGridViewTarjetas.Rows.Add( "", "", f[i][j].CUOTAS, f[i][j].INTERES+"%" );
					}
					contador++;
				}
			}
			
			if( contador == 0 )
				MessageBox.Show("No se encontraron tarjetas con beneficios.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		void BtnListarTarjetasClick(object sender, EventArgs e)
		{
			btnBonificarTarjeta.Enabled = true;
			btnBonificarTarjeta.BackColor = Color.LightGreen;
			labelTarjetasLista.Text = "Tarjetas Disponibles";
			
			try{
				List<Tarjeta> tarjetasDuplicado; // copia de lista de tarjetas
				List<List<FormaDePago>> formasDePagoDuplicado; // lista de copias de formas de pago por tarjeta que a su vez
															   // también son listas --> una lista de formas de pago por tarjeta
				
				// se regenera copia en cada click por si se agregaron tarjetas a la tienda
				tarjetasRegistradas = SitandBuy.verTarjetas( out tarjetasDuplicado, out formasDePagoDuplicado );
				
				if( !tarjetasRegistradas ){ 
					MessageBox.Show("No se encontraron tarjetas registradas.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
				}
				else
					actualizarListaTarjetas( tarjetasDuplicado, formasDePagoDuplicado );
			}
			catch( Exception ){
				MessageBox.Show("Ha ocurrido un error ! Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void BtnListarTarjBenefClick(object sender, EventArgs e)
		{
			btnBonificarTarjeta.Enabled = false;
			btnBonificarTarjeta.BackColor = Color.DarkSalmon;
			labelTarjetasLista.Text = "Tarjetas con Beneficios Incluídos";
			try{
				List<Tarjeta> tarjetasDuplicado; // copia de lista de tarjetas
				List<List<FormaDePago>> formasDePagoDuplicado; // lista de copias de formas de pago por tarjeta que a su vez
															   // también son listas --> una lista de formas de pago por tarjeta
				
				// se regenera copia en cada click por si se agregaron tarjetas a la tienda
				tarjetasRegistradas = SitandBuy.verTarjetas( out tarjetasDuplicado, out formasDePagoDuplicado );
				
				if( !tarjetasRegistradas ){ 
					MessageBox.Show("No se encontraron tarjetas registradas.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
					actualizarListaTarjBenef( tarjetasDuplicado, formasDePagoDuplicado );
			}
			catch( Exception ){
				MessageBox.Show("Ha ocurrido un error ! Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void BtnAgregarTarjetaClick(object sender, EventArgs e)
		{
			try{
				AgregarTarjetaForm f = new AgregarTarjetaForm();
				f.ShowDialog();
				
				SitandBuy.agregarTarjeta( f.NOMBRE, f.BANCO, f.CUOTAS, f.INTERESES );
				MessageBox.Show("TARJETA AGREGADA !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
				btnListarTarjetas.PerformClick();
				
				f.Dispose();
			}
			catch( OperacionCanceladaException ){
				MessageBox.Show("Operación cancelada !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch( Exception ){
				MessageBox.Show("Ha ocurrido un error ! Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void BtnBonificarTarjetaClick(object sender, EventArgs e)
		{
			try{
				string nombre = dataGridViewTarjetas.CurrentRow.Cells[0].Value.ToString();
				string banco = dataGridViewTarjetas.CurrentRow.Cells[1].Value.ToString();
				int index = SitandBuy.peekTarjeta( nombre );
				
				BonificarTarjetaForm f = new BonificarTarjetaForm( nombre, banco );
				f.ShowDialog();
				
				// Se devuelve true en caso de éxito en la operación
				if( SitandBuy.bonificarTarjeta( f.CUOTA, f.INTERES, index ) ){
					MessageBox.Show("BENEFICIO AGREGADO !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
					throw new Exception();
				
				btnListarTarjBenef.PerformClick();
				
				f.Dispose();
			}
			catch( OperacionCanceladaException ){
				MessageBox.Show("Operación cancelada !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch( Exception ){
				MessageBox.Show("Ha ocurrido un error ! Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void DataGridViewTarjetasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if( dataGridViewTarjetas.CurrentRow.Cells[2].Value == null ){
				if( labelTarjetasLista.Text == "Tarjetas Disponibles" ){
					btnBonificarTarjeta.Enabled = true;
					btnBonificarTarjeta.BackColor = Color.LightGreen;
			   }
			}
			else{
				btnBonificarTarjeta.Enabled = false;
				btnBonificarTarjeta.BackColor = Color.DarkSalmon;
			}
		}
		
		/*************************************************************************************************************************************/
		/********************************************************** SECCION COMPRAS **********************************************************/
		/*************************************************************************************************************************************/
		
		void actualizarListaProdCarro( List<Producto> p , List<int> c ){
			// p : productos del carro; c : cantidades por cada producto
			
			dataGridViewCompras.Rows.Clear();
			
			for(int i = 0; i < p.Count; i++){
				dataGridViewCompras.Rows.Add( c[i], p[i].TIPO, p[i].MARCA, p[i].TALLE, 
				                             string.Format("{0:C}",p[i].PRECIO),
				                             string.Format("{0:C}",p[i].DESCUENTO) );
			}
			dataGridViewCompras.Rows.Add();
			dataGridViewCompras.Rows.Add("TOTAL COMPRA:", string.Format("{0:C}", Carrito.TOTALPAGO));
		}
		
		void BtnListarProdCarroClick(object sender, EventArgs e)
		{
			bool carroVacio;
			List<Producto> prodCarroDuplicado; // copia de la lista de productos en carro
			List<int> cantCarroDuplicado; // copia de la lista de cantidades por producto en carro
			
			try{
				// se regenera copia en cada iteración por si se agregaron productos al carro
				carroVacio = Carrito.verProductosCarro( out prodCarroDuplicado, out cantCarroDuplicado );
				
				if( carroVacio ){
					labelComprasLista.Text = "No hay productos en carro";
					MessageBox.Show("No se encontraron productos en el carro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else{
					labelComprasLista.Text = "Productos en Carro";
					// Listar productos disponibles en carro
					actualizarListaProdCarro( prodCarroDuplicado , cantCarroDuplicado );
				}
			}
			catch( Exception ){
				MessageBox.Show("Ha ocurrido un error ! Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void BtnAgregarProdCarroClick(object sender, EventArgs e)
		{
			try{
				List<Producto> prodDuplicado; // copia de la lista de productos en tienda
				
				// regeneran datos de productos disponibles
				stockProductos = SitandBuy.verProductosTienda( out prodDuplicado );
				
				if( !stockProductos ){
					MessageBox.Show("Error. No hay productos disponibles en la tienda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
					return;
				}
				
				// regenero la lista de productos disponibles en la tienda para pasarla
				// a la ventana 'AgregarProdCarroForm'
				actualizarListaProductos( prodDuplicado, dataGridViewProdyProm );
				
				AgregarProdCarroForm f = new AgregarProdCarroForm( dataGridViewProdyProm, prodDuplicado.Count );
				f.ShowDialog();
				
				// Se devuelve true en caso de éxito en la operación
				if( Carrito.agregarProducto( prodDuplicado[f.INDICEPRODUCTO], f.CANTIDAD ) ){
					MessageBox.Show("PRODUCTO AGREGADO !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
					btnListarProdCarro.PerformClick();
				}
				else
					MessageBox.Show("Error. Verifique e intente nuevamente !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				
				f.Dispose();
			}
			catch( OperacionCanceladaException ){
				MessageBox.Show("Operación cancelada !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch( Exception ){
				MessageBox.Show("Ha ocurrido un error ! Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		
		void BtnQuitarProdCarroClick(object sender, EventArgs e)
		{
			bool carroVacio;
			List<Producto> prodCarroDuplicado; // copia de la lista de productos en carro
			List<int> cantCarroDuplicado; // copia de la lista de cantidades por producto en carro
			
			// se regenera copia en cada iteración por si se agregaron productos al carro
			carroVacio = Carrito.verProductosCarro( out prodCarroDuplicado, out cantCarroDuplicado );
			
			if( carroVacio )
				MessageBox.Show("No se encontraron productos en el carro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else{
				actualizarListaProdCarro( prodCarroDuplicado , cantCarroDuplicado );
				
				layoutCompras.Enabled = false;
				layoutCompras.Visible = false;
				layoutCompras.Dock = DockStyle.None;
				
				layoutQuitarProdCarro.Enabled = true;
				layoutQuitarProdCarro.Visible = true;
				layoutQuitarProdCarro.Dock = DockStyle.Right;
			}
		}
		
		void BtnRemoverProdClick(object sender, EventArgs e)
		{
			try{
				Carrito.quitarProducto( dataGridViewCompras.CurrentRow.Index );
				MessageBox.Show("PRODUCTO REMOVIDO !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				
				layoutCompras.Enabled = true;
				layoutCompras.Visible = true;
				layoutCompras.Dock = DockStyle.Right;
				
				layoutQuitarProdCarro.Enabled = false;
				layoutQuitarProdCarro.Visible = false;
				layoutQuitarProdCarro.Dock = DockStyle.None;
				
				if( Carrito.prodsEnCarro != 0 )
					btnListarProdCarro.PerformClick();
				else{
					dataGridViewCompras.Rows.Clear();
					labelComprasLista.Text = "No hay productos en el carro";
				}
			}
			catch( Exception ){
				MessageBox.Show("Error. Verifique e intente nuevamente !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
			}
		}
		
		void BtnCancelarQuitarProdClick(object sender, EventArgs e)
		{
			layoutCompras.Enabled = true;
			layoutCompras.Visible = true;
			layoutCompras.Dock = DockStyle.Right;
			
			layoutQuitarProdCarro.Enabled = false;
			layoutQuitarProdCarro.Visible = false;
			layoutQuitarProdCarro.Dock = DockStyle.None;
		}
		
		void BtnIdClienteClick(object sender, EventArgs e)
		{
			try{
				List<Tarjeta> tarjetasDuplicado; // copia de lista de tarjetas
				List<List<FormaDePago>> formasDePagoDuplicado; // lista de copias de formas de pago por tarjeta que a su vez
															   // también son listas --> una lista de formas de pago por tarjeta
															   
				// se regenera copia en cada click por si se agregaron tarjetas a la tienda
				if( !SitandBuy.verTarjetas( out tarjetasDuplicado, out formasDePagoDuplicado ) ){
					MessageBox.Show("No se encontraron tarjetas registradas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
					return;
				}
				else if( Carrito.prodsEnCarro == 0 ){
					MessageBox.Show("No se encontraron productos en el carro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
					return;
				}
				
				ClienteyPagoForm f = new ClienteyPagoForm(SitandBuy, Carrito, tarjetasDuplicado, formasDePagoDuplicado);
				f.ShowDialog();
				
				// labelComprasLista.Text = "No hay productos en el carro";
				// dataGridViewCompras.Rows.Clear();
				f.Dispose();
			}
			catch( OperacionCanceladaException ){
				MessageBox.Show("Operación cancelada !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch( Exception ){
				MessageBox.Show("Ha ocurrido un error ! Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
		}
		
		void DataGridViewComprasCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if( dataGridViewCompras.CurrentRow.Cells[2].Value == null )
				btnRemoverProd.Enabled = false;
			else
				btnRemoverProd.Enabled = true;
		}
		
		/*************************************************************************************************************************************/
		/****************************************************** SECCION ADMINISTRACION *******************************************************/
		/*************************************************************************************************************************************/
		
		void BtnVentasTiendaClick(object sender, EventArgs e)
		{
			layoutAdministracionLista.Enabled = false;
			layoutAdministracionLista.Visible = false;
			
			layoutTotalVendidoAdm.Visible = true;
			layoutTotalVendidoAdm.Enabled = true;
			
			labelTotalNumero.Text = string.Format("{0:C}", SitandBuy.calcularTotalVendidoTienda());
		}
		
		void BtnVentasClienteClick(object sender, EventArgs e)
		{
			labelAdministracionLista.Text = "Ventas por Cliente";
			
			layoutAdministracionLista.Enabled = true;
			layoutAdministracionLista.Visible = true;
			
			layoutTotalVendidoAdm.Visible = false;
			layoutTotalVendidoAdm.Enabled = false;
			
			int i = 1;
			Dictionary<int, Cliente> clientesDuplicado;
			
			clientesRegistrados = SitandBuy.verClientes( out clientesDuplicado );
			
			dataGridViewAdministracion.Rows.Clear();
			
			if( dataGridViewAdministracion.Columns.Count != 5 ){
				dataGridViewAdministracion.Columns[1].HeaderText = "Apellido";
				dataGridViewAdministracion.Columns[2].HeaderText = "DNI";
				
				dataGridViewAdministracion.Columns.Add("fechaNac", "Fecha de Nacimiento");
				dataGridViewAdministracion.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				dataGridViewAdministracion.Columns.Add("Total Gastado", "Total Gastado");
				dataGridViewAdministracion.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			}
			
			if( !clientesRegistrados ){ 
				MessageBox.Show("No hay clientes registrados.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning );
			}
			else{
				foreach(Cliente c in clientesDuplicado.Values){
					dataGridViewAdministracion.Rows.Add( c.NOMBRE,
					                                    c.APELLIDO,
					                                    string.Format("{0:N0}", c.DNI),
					                                    c.FECHANACIMIENTO.ToShortDateString(),
					                                    string.Format("{0:C}", c.TOTALGASTADO) );
					i++;
				}
			}
			
		}
		
		void BtnVentasTarjetaClick(object sender, EventArgs e)
		{
			labelAdministracionLista.Text = "Ventas por Tarjeta";
			
			layoutAdministracionLista.Enabled = true;
			layoutAdministracionLista.Visible = true;
			
			layoutTotalVendidoAdm.Visible = false;
			layoutTotalVendidoAdm.Enabled = false;
			
			byte i = 1;
			List<Tarjeta> tarjetasDuplicado;
			
			tarjetasRegistradas = SitandBuy.verTarjetas( out tarjetasDuplicado );
			
			if( dataGridViewAdministracion.Columns.Count != 3 ){
				dataGridViewAdministracion.Columns.Remove("fechaNac");
				dataGridViewAdministracion.Columns.Remove("Total Gastado");
				dataGridViewAdministracion.Columns[1].HeaderText = "Banco";
				dataGridViewAdministracion.Columns[2].HeaderText = "Total Gastado";
			}
			
			dataGridViewAdministracion.Rows.Clear();
			
			if( !tarjetasRegistradas ){ 
				MessageBox.Show("No se encontraron tarjetas registradas.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else{
				foreach(Tarjeta t in tarjetasDuplicado){
					dataGridViewAdministracion.Rows.Add( t.NOMBRE, t.BANCO, string.Format("{0:C}", t.TOTALCOMPRAS) );
					i++;
				}
			}
			
		}
		
		/*************************************************************************************************************************************/
		/********************************************************SECCION BASE DE DATOS *******************************************************/
		/*************************************************************************************************************************************/
		
		void leerArchivoProductos(string nombreArchivo){
			
			FileStream fsLectura = new FileStream(nombreArchivo, FileMode.Open);
			StreamReader archivo = new StreamReader(fsLectura);
			string[] partes = new string[5];
			string lineaLeida;
			
			// partes[0] : tipo
			// partes[1] : marca
			// partes[2] : talle
			// partes[3] : precio
			// partes[4] : descuento
			
			archivo.ReadLine(); archivo.ReadLine();// descarto primeras dos lineas
			while( !archivo.EndOfStream ){
				lineaLeida = archivo.ReadLine();
				partes = lineaLeida.Split( new char[] {';'} );
				SitandBuy.agregarProducto(partes[0], partes[1], partes[2], float.Parse(partes[3]), int.Parse(partes[4]));
			}
			
			archivo.Close();
		}
		
		void leerArchivoClientes(string nombreArchivo){
			
			FileStream fsLectura = new FileStream(nombreArchivo, FileMode.Open);
			StreamReader archivo = new StreamReader(fsLectura);
			string[] partes = new string[5];
			string lineaLeida;
			
			// partes[0] : nombre
			// partes[1] : apellido
			// partes[2] : fecha de nacimiento
			// partes[3] : dni
			// partes[4] : total gastado
			
			archivo.ReadLine(); archivo.ReadLine();// descarto primeras dos lineas
			while( !archivo.EndOfStream ){
				lineaLeida = archivo.ReadLine();
				partes = lineaLeida.Split( new char[] {';'} );
				SitandBuy.agregarCliente(partes[0], partes[1], DateTime.Parse(partes[2]), int.Parse(partes[3]), double.Parse(partes[4]));
			}
			
			archivo.Close();
		}
		
		void leerArchivoTarjetas(string nombreArchivo){
			
			FileStream fsLectura = new FileStream(nombreArchivo, FileMode.Open);
			StreamReader archivo = new StreamReader(fsLectura);
			string[] partes = new string[5];
			string[] partes_formaDePago;
			string lineaLeida;
			List<int> cuotas = new List<int>();
			List<int> intereses = new List<int>();
			int cantFormasDePago;
			int i;
			
			archivo.ReadLine(); archivo.ReadLine();// descarto primeras dos lineas
			while( !archivo.EndOfStream ){
				lineaLeida = archivo.ReadLine();
				partes = lineaLeida.Split( new char[] {';'} );
				cantFormasDePago = int.Parse(partes[4]); // partes[4] es # de formas de pago
				
				// partes[0] : nombre
				// partes[1] : banco
				// partes[2] : beneficio
				// partes[3] : total compras
				// partes[4] : cantidad de formas de pago
				// partes[5 en adelante] : formas de pago --> formato "x,y" x:cuotas; y:interes
				
				// partes_formaDePago[0] : cuotas
				// partes_formaDePago[1] : intereses
				
				for( i = 0; i < cantFormasDePago; i++){
					partes_formaDePago = partes[5+i].Split( new char[] {'|'} );
					cuotas.Add(int.Parse(partes_formaDePago[0]));
					intereses.Add(int.Parse(partes_formaDePago[1]));
				}
				    
				SitandBuy.agregarTarjeta(partes[0], partes[1], cuotas, intereses, double.Parse(partes[3]), bool.Parse(partes[2]));
				cantFormasDePago = 0;
				cuotas.Clear();
				intereses.Clear();
			}
			
			archivo.Close();
		}
		
		void guardarArchivoProductos(string nombreArchivo){
			
			FileStream fsEscritura = new FileStream(nombreArchivo, FileMode.Create);
			StreamWriter archivo = new StreamWriter(fsEscritura);
			
			List<Producto> productos;
			
			archivo.WriteLine("TIPO;MARCA;TALLE;PRECIO;DESCUENTO\n");
			if( SitandBuy.verProductosTienda(out productos) ){
				string linea;
				foreach(Producto p in productos){
					linea = string.Format("{0};{1};{2};{3};{4}", p.TIPO, p.MARCA, p.TALLE, p.PRECIO, p.DESCUENTO);
					archivo.WriteLine(linea);
				}
			}
			archivo.Close();
		}
		
		void guardarArchivoClientes(string nombreArchivo){
			
			FileStream fsEscritura = new FileStream(nombreArchivo, FileMode.Create);
			StreamWriter archivo = new StreamWriter(fsEscritura);
			
			Dictionary<int, Cliente> clientes;
			
			archivo.WriteLine("NOMBRE;APELLIDO;FCHA_NACIM;DNI;TOTAL GASTADO\n");
			if( SitandBuy.verClientes(out clientes) ){
				string linea;
				foreach(Cliente c in clientes.Values){
					linea = string.Format("{0};{1};{2};{3};{4}", c.NOMBRE, c.APELLIDO, c.FECHANACIMIENTO.ToShortDateString(), c.DNI, c.TOTALGASTADO);
					archivo.WriteLine(linea);
				}
			}
			archivo.Close();
		}
		
		void guardarArchivoTarjetas(string nombreArchivo){
			
			FileStream fsEscritura = new FileStream(nombreArchivo, FileMode.Create);
			StreamWriter archivo = new StreamWriter(fsEscritura);
			
			List<Tarjeta> tarjetas;
			List<List<FormaDePago>> formasDePago;
			
			archivo.WriteLine("NOMBRE;BANCO;BONIF;TOTAL COMPRAS;#FMAS_PAGO;PAGOS{cuotas|interes}\n");
			int i, j;
			if( SitandBuy.verTarjetas(out tarjetas, out formasDePago) ){
				string linea;
				for( i = 0; i < tarjetas.Count; i++){
					linea = string.Format("{0};{1};{2};{3};{4}", tarjetas[i].NOMBRE, tarjetas[i].BANCO, tarjetas[i].BENEFICIO, tarjetas[i].TOTALCOMPRAS, formasDePago[i].Count);
					for( j = 0; j < formasDePago[i].Count; j++ ){
						linea += string.Format(";{0}|{1}", formasDePago[i][j].CUOTAS, formasDePago[i][j].INTERES);
					}
					archivo.WriteLine(linea);
				}
			}
			archivo.Close();
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult opcion = MessageBox.Show("Saliendo de la aplicación. ¿ Desea guardar los cambios realizados ?", 
									                "Exit", 
									                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
			if( opcion == DialogResult.Yes ){
				// ACTUALIZAR BASE DE DATOS
				try{
					guardarArchivoProductos(nombreArchivoProductos);
					guardarArchivoClientes(nombreArchivoClientes);
					guardarArchivoTarjetas(nombreArchivoTarjetas);
				}
				catch( Exception ){ 
					Console.WriteLine("Error al guardar en base de datos"+e);
					Console.Write("\nPresione una tecla para continuar ...");
					Console.ReadKey(true);
				}
			}
			else if( opcion == DialogResult.Cancel )
				e.Cancel = true;
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
	
	/*************************************************************************************************************************************/
	/******************************************************** SECCIÓN EXCEPCIONES ********************************************************/
	/*************************************************************************************************************************************/
	
	// Excepción que ataja (mayormente) las situaciones en las que el usuario cierra
	// las ventanas emergentes que aparecen sin completar los datos que se le pide
	public class OperacionCanceladaException : ApplicationException{}
}
