using System;

namespace TiendaOnline
{
	public class FormaDePago
	{
		int cuotas;
		int interes;
		
		public FormaDePago(){}
		public FormaDePago( int cuotas, int interes){
			this.cuotas = cuotas;
			this.interes = interes;
		}
		
		public int CUOTAS{ get{ return cuotas;} }
		public int INTERES{ get{ return interes;} }
	}
}
