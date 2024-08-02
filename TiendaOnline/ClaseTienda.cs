using System;
using System.Collections.Generic;
using System.Linq;

namespace TiendaOnline
{
	public class Tienda
	{
		Dictionary<int, Cliente> Clientes = new Dictionary<int, Cliente>();
		List<Tarjeta> Tarjetas = new List<Tarjeta>();
		List<Producto> Productos = new List<Producto>();
		
		
		/******************* SECCION CLIENTES *******************/
		
		public void agregarCliente(string nombre, string apellido, DateTime fechaNacimiento, int dni){
			Clientes.Add(dni, new Cliente(nombre, apellido, fechaNacimiento, dni));
		}
		// Para pre-cargar algunos Clientes al inicio del programa ( se agrega totalGastado )
		public void agregarCliente(string nombre, string apellido, DateTime fechaNacimiento, int dni, double totalGastado){
			Clientes.Add(dni, new Cliente(nombre, apellido, fechaNacimiento, dni, totalGastado));
		}
		
		public bool verClientes(out Dictionary<int, Cliente> clientesDuplicado){
			if( Clientes.Values.Count == 0 ){ clientesDuplicado = null; return false; }
			else{
				Dictionary<int, Cliente> clientesAux = Clientes;
				clientesDuplicado = clientesAux;
				return true;
			}
		}
		
		public Cliente buscarCliente(int dni){
			Cliente clienteCompra;
			if( Clientes.TryGetValue( dni, out clienteCompra ) )
				return clienteCompra;
			else
				return null;
		}
		
		/******************* SECCION PRODUCTOS *******************/
		
		public void agregarProducto(Producto p){
			Productos.Add(p);
			Productos = Productos.OrderBy(x=>x.TIPO).ToList();
		}
		public void agregarProducto(string tipo, string marca, string talle, float precio){
			Productos.Add(new Producto(tipo, marca, talle, precio));
			Productos = Productos.OrderBy(x=>x.TIPO).ToList();
		}
		
		public void agregarProducto(string tipo, string marca, string talle, float precio, int descuento){
			Productos.Add(new Producto(tipo, marca, talle, precio, descuento));
			Productos = Productos.OrderBy(x=>x.TIPO).ToList();
		}
		
		public bool verProductosTienda( out List<Producto> prodDuplicado ){
			// genera copia de los productos en la tienda
			// devuelve false si no hay productos registrados
			if( Productos.Count == 0 ){ prodDuplicado = null; return false; }
			else{
				List<Producto> prodsAux = Productos;
				prodDuplicado = prodsAux;
				return true;
			}
		}
		
		public bool promocionarProducto( int nuevoDescuento, int indiceProducto ){
			// true: exito; false caso contrario
			if( nuevoDescuento >= 0 && nuevoDescuento <= 100 ){
				Productos[indiceProducto].modificarDescuento(nuevoDescuento);
				return true;
			}
			else
				return false;
		}
		
		public int CANT_PRODUCTOS{ get{ return Productos.Count; } }
		
		/******************** SECCION TARJETAS *******************/
		
		public void agregarTarjeta(string nombre, string banco, List<int> cuotas, List<int> interes){
			Tarjetas.Add(new Tarjeta(nombre, banco, cuotas, interes));
		}
		// Para pre-cargar algunas Tarjetas al inicio del programa ( se agrega totalCompras )
		public void agregarTarjeta(string nombre, string banco, List<int> cuotas, List<int> interes, double totalCompras, bool beneficio){
			Tarjetas.Add(new Tarjeta(nombre, banco, cuotas, interes, totalCompras, beneficio));
		}
		
		public Tarjeta ultimaTarjeta(){
			return Tarjetas[Tarjetas.Count-1];
		}
		
		public bool verTarjetas( out List<Tarjeta> tarjetasDuplicado ){
			// genera copia de la lista de tarjetas disponibles 
			// devuelve false si no hay tarjetas registradas
			if( Tarjetas.Count == 0 ){ tarjetasDuplicado = null; return false; }
			else{
				List<Tarjeta> tarjAux = Tarjetas;
				tarjetasDuplicado = tarjAux;
				return true;
			}
		}
		
		public bool verTarjetas( out List<Tarjeta> tarjetasDuplicado, out List<List<FormaDePago>> formasDuplicado){
			// genera copia de la lista de tarjetas disponibles y sus formas de pago correspondientes ( metodo sobrecargado )
			// devuelve false si no hay tarjetas registradas
			if( Tarjetas.Count == 0 ){ tarjetasDuplicado = null; formasDuplicado = null; return false; }
			else{
				List<Tarjeta> tarjAux = Tarjetas;
				List<List<FormaDePago>> formasAux = new List<List<FormaDePago>>();
				
				foreach(Tarjeta t in Tarjetas){
					// agrego a una lista todas las formas de pago de la tarjeta actual
					formasAux.Add(t.verFormasDePago());
				}
				tarjetasDuplicado = tarjAux;
				formasDuplicado = formasAux;
				return true;
			}
		}
		
		public int peekTarjeta( string name ){
			for(int i=0; i < Tarjetas.Count; i++){
				if( Tarjetas[i].NOMBRE == name )
					return i;
			}
			return -1;
		}
		
		public bool bonificarTarjeta( int cuotas, int interes, int indiceTarjeta ){
			if( interes >= 0 && cuotas > 0 ){
				Tarjetas[indiceTarjeta].agegarBeneficio(cuotas, interes);
				return true;
			}
			else
				return false;
		}
		
		public int CANT_TARJETAS{ get{ return Tarjetas.Count; } }
		
		/******************** SECCION VENTAS ********************/
		
		public double calcularTotalVendidoTienda(){
			double totalVendido = 0;
			foreach(Tarjeta t in Tarjetas){
				totalVendido += t.TOTALCOMPRAS;
			}
			return totalVendido;
		}
		
		public void actualizarVentas( double totalPago, int indiceTarjeta, int dni ){
			Cliente clienteActualizarPago;
			Tarjetas[indiceTarjeta].TOTALCOMPRAS = totalPago;
			Clientes.TryGetValue( dni, out clienteActualizarPago );
			clienteActualizarPago.TOTALGASTADO = totalPago;
		}
		
	}
}
