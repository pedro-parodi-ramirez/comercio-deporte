using System;
using System.Collections.Generic;

namespace TiendaOnline
{
	public class Carro
	{
		List<int> cantidades = new List<int>();
		List<Producto> productosCompra = new List<Producto>();
		double totalPago;
		
		public double TOTALPAGO{ get{ return totalPago; } }

		public bool agregarProducto(Producto p, int cantidad){
			if( cantidad > 0 ){
				cantidades.Add(cantidad);
				productosCompra.Add(p);
				totalPago += p.PRECIO * ( 1 - p.DESCUENTO/100.0 ) * cantidad;
				return true;
			}
			else
				return false;
		}
		
		public void quitarProducto(int indiceProducto){
			totalPago -= productosCompra[indiceProducto].PRECIO * ( 1 - productosCompra[indiceProducto].DESCUENTO/100.0 ) * cantidades[indiceProducto];
			cantidades.Remove(cantidades[indiceProducto]);
			productosCompra.Remove(productosCompra[indiceProducto]);
		}
		
		public bool verProductosCarro(out List<Producto> prodDuplicado, out List<int> cantDuplicado){
			// genera copia de la lista de productos en carro y tambien de sus cantidades
			// devuelve true si el carro está vacío
			if( productosCompra.Count == 0 ){ prodDuplicado = null; cantDuplicado = null; return true; }
			else{
				List<Producto> prodAux;
				List<int> cantAux;
				prodAux = productosCompra;
				cantAux = cantidades;
				prodDuplicado = prodAux;
				cantDuplicado = cantAux;
				return false;
			}
		}
		
		public void vaciarCarro(){
			cantidades.Clear();
			productosCompra.Clear();
			totalPago = 0D;
		}
		
		public int prodsEnCarro{ get{ return productosCompra.Count; } }
	}
}