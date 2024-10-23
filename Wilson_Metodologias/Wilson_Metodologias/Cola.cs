/*
 * Creado por SharpDevelop.
 * Usuario: Estudiante
 * Fecha: 12/10/2024
 * Hora: 23:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace Wilson_Metodologias
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	public class Cola : IColeccionable
	{
		private List<Comparable> cola;
		
		public Cola()
		{
			cola = new List<Comparable>();
		}
		
		public void encolar(Comparable comparable){
//			cola.Add(comparable);
			agregar(comparable); // reutilizamos el metodo agregar que hace lo mismo que encolar
		}
		
		public Comparable desencolar(){
			Comparable elem = cola[0];
			cola.RemoveAt(0);
			return elem;
		}
		
		public List<Comparable> getCola(){
			return this.cola;
		}

		#region IColeccionable implementation

		public int cuantos()
		{
			return this.cola.Count;
		}

		public Comparable minimo(){
			Comparable menor = cola[0];
			for(int i = 1; i < cola.Count; i++){
				if(menor.sosMayor(cola[i])){
					menor = cola[i];
				}
			}
			return menor;
		}
	

		public Comparable maximo()
		{
			Comparable mayor = cola[0];
			for (int i = 1; i < cola.Count; i++) {
				if(mayor.sosMenor(cola[i])){
					mayor = cola[i];
				}
			}
			return mayor;
		}
		

		public void agregar(Comparable comparable)
		{
			cola.Add(comparable);
		}

		public bool contiene(Comparable comparable)
		{
//			return cola.Contains(comparable); (preguntar si se puede usar !)
//			foreach (var c in cola)  cuando se pone var c# analiza el tipo de dato de la collecion y lo asigna a la variable c
//			si la coleccion es un string var le asignara (srt  a "c"),si es int (int a "c") asi con los otros tipos de variables
			foreach (Comparable c in cola){
				if(c.sosIgual(comparable)){
					return true;
				}
			}
			return false;
		}

		#endregion
	}
}
