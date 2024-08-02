using System;

namespace TiendaOnline
{
	public class Cliente
	{
		string nombre;
		string apellido;
		DateTime fechaNacimiento;
		int dni;
		double totalGastado;
		
		public Cliente(){}
		public Cliente( string nombre, string apellido, DateTime fechaNacimiento, int dni){
			this.nombre = nombre;
			this.apellido = apellido;
			this.fechaNacimiento = fechaNacimiento;
			this.dni = dni;
			totalGastado = 0D;
		}
		// Para pre-cargar algunos Clientes al inicio del programa ( se agrega totalGastado )
		public Cliente( string nombre, string apellido, DateTime fechaNacimiento, int dni, double totalGastado){
			this.nombre = nombre;
			this.apellido = apellido;
			this.fechaNacimiento = fechaNacimiento;
			this.dni = dni;
			this.totalGastado = totalGastado;
		}
		
		public string NOMBRE{ get{ return nombre; } }
		public string APELLIDO{ get{ return apellido; } }
		public DateTime FECHANACIMIENTO{ get{ return fechaNacimiento; } }
		public int DNI{ get{ return dni; } }
		public double TOTALGASTADO{ 
			get{ return totalGastado; } 
			set{ totalGastado += value; }
		}
	}
}
