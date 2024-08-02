using System;

namespace TiendaOnline
{
	public class Producto
	{
		string tipo;
		string marca;
		string talle;
		float precio;
		int descuento;
		
		public Producto(){}
		public Producto(string tipo, string marca, string talle, float precio){
			this.tipo = tipo;
			this.marca = marca;
			this.talle = talle;
			this.precio = precio;
			descuento = 0;
		}
		public Producto(string tipo, string marca, string talle, float precio, int descuento){
			this.tipo = tipo;
			this.marca = marca;
			this.talle = talle;
			this.precio = precio;
			this.descuento = descuento;
		}
		
		public void modificarDescuento(int nuevoDescuento){
			descuento = nuevoDescuento;
		}
		
		public void modificarPrecio(float nuevoPrecio){
			precio = nuevoPrecio;
		}
		
		public string TIPO{ get{ return tipo; } }
		public string MARCA{ get{ return marca; } }
		public string TALLE{ get{ return talle; } }
		public int DESCUENTO{ get{ return descuento; } }
		public double PRECIO{ get{ return (double)precio; } }
	}
}
