using System;
using System.Collections.Generic;
using System.Linq;

namespace TiendaOnline
{
	public class Tarjeta
	{
		string nombre;
		string banco;
		List<FormaDePago> formasDePago = new List<FormaDePago>();
		double totalCompras;
		bool beneficio;
		
		public Tarjeta(){}
		public Tarjeta(string nombre, string banco, List<int> cuotas, List<int> intereses){
			this.nombre = nombre;
			this.banco = banco;
			beneficio = false;
			totalCompras = 0D;
			for(int i = 0; i < cuotas.Count; i++){
				if( cuotas[i] <= 0 || intereses[i] < 0 ){ throw new Exception(); }
				
				formasDePago.Add(new FormaDePago(cuotas[i], intereses[i]));
			}
		}
		// Para pre-cargar algunas Tarjetas al inicio del programa
		public Tarjeta(string nombre, string banco, List<int> cuotas, List<int> intereses, double totalCompras, bool beneficio){
			this.nombre = nombre;
			this.banco = banco;
			this.beneficio = beneficio;
			this.totalCompras = totalCompras;
			for(int i = 0; i < cuotas.Count; i++){
				if( cuotas[i] <= 0 || intereses[i] < 0 ){ throw new Exception(); }
				formasDePago.Add(new FormaDePago(cuotas[i], intereses[i]));
			}
		}
		
		public void agregarFormaDePago(int cuotas, int interes){
			formasDePago.Add(new FormaDePago(cuotas, interes));
		}
		
		public void agegarBeneficio(int cuotas, int interes){
			foreach(FormaDePago f in formasDePago){
				if ( f.CUOTAS == cuotas ){
					// Si se quiere agregar un beneficio a una forma de pago ya existente,
					// se elimina esa forma de pago y se crea una nueva
					formasDePago.Remove(f);
					break;
				}
			}
			beneficio = true;
			agregarFormaDePago(cuotas, interes);
			formasDePago = formasDePago.OrderBy(x=>x.CUOTAS).ToList();
		}
		
		public List<FormaDePago> verFormasDePago(){
			List<FormaDePago> formasDuplicado = formasDePago;
			return formasDuplicado;
		}
		
		public string NOMBRE{ get{ return nombre; } }
		public string BANCO{ get{ return banco; } }
		public bool BENEFICIO{ get{ return beneficio; } }
		public double TOTALCOMPRAS{ 
			get{ return totalCompras; } 
			set{ totalCompras += value; }
		}
		
		public int this[int cuotas]{
			// devuelve el interes correspondiente a la cuota que se le espicifica
			get{
				foreach(FormaDePago f in formasDePago){
					if( cuotas == f.CUOTAS )
						return f.INTERES;
				}
				return -1;
			}
		}
	}
}