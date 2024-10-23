/*
 * Creado por SharpDevelop.
 * Usuario: Estudiante
 * Fecha: 13/10/2024
 * Hora: 21:44
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Wilson_Metodologias
{
	/// <summary>
	/// Description of ColeccionMultiple.
	/// </summary>
	public class ColeccionMultiple : IColeccionable
	{
		private Pila pila;
		private Cola cola;
		public ColeccionMultiple(Pila p , Cola c)
		{
			this.pila = p;
			this.cola = c;
		}
		//Implementacion de la Interface IColeccionable
		
		//devuelve cantidad de elemntos de Ambas Colecciones
		public int cuantos()
		{
			return (this.pila.cuantos() + this.cola.cuantos());
		}

		// devuelve el minimo entre ambas Colecciones
		public Comparable minimo()
		{
			//almacenamos en variables los minimos para que no realice calculos una y otra vez esto afecta a la memmoria a realizar calculos innecesarios
			Comparable a = pila.minimo();
			Comparable b = cola.minimo();
			
			// el if else se puede resumir a  (condición ? valorSiVerdadero : valorSiFalso;) sintaxis
			return a.sosMenor(b) ? a : b;
			
//			if(a.sosMenor(b)){
//				return a;
//			}else
//				return b;
			
		}
		// devuelve el Comparable mayor entre ambas Colecciones
		public Comparable maximo()
		{
			Comparable a = pila.maximo();
			Comparable b = cola.maximo();
			// usamos la comparacion ternaria sintaxis (condición ? valorSiVerdadero : valorSiFalso;) sintaxis
			return a.sosMayor(b) ? a : b ;
		}
		// no hace Nada
		public void agregar(Comparable comparable)
		{
			throw new NotImplementedException();
		}
		// retorna true si el Comparable recibido por parametro esta en una o ambas Colecciones caso contrario False
		public bool contiene(Comparable comparable)
		{
			// guaradar valores de ambas coleeciones para que no haga demasiados calculos 
			bool p = this.pila.contiene(comparable);
			bool c = this.cola.contiene(comparable);
			//esta linea devuelve true si en algunos de los casos se encuentra comparable caso contraio de que en nunguno este devuelve false
			// fijarse bien el manejo de operadores logicos and y or.
			if (p||c){
				if(p && c){
					Console.WriteLine("El comparable esta en ambas Colecciones");
				}
				return true; // devuelve true si almenos se encuentra el alguna de las colecciones
			}
			else
				return false; // false si no esta en ninguna de las colecciones
		
				
		}
	}
}
