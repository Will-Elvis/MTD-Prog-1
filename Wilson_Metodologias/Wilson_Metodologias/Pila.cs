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
	/// Description of Pila.
	/// </summary>
	public class Pila : IColeccionable
	{
		private List<Comparable> pila;
		
		public Pila()
		{
			pila = new List<Comparable>();
		}
		
		public void apilar(Comparable c){
			agregar(c);
		}
		
		public Comparable desapilar(){
			Comparable elem = pila[pila.Count -1];
			pila.RemoveAt(pila.Count -1);
			return elem;
		}
		
		public List<Comparable> getPila(){
			return this.pila;
		}
		
		
	
		public int cuantos()
		{
			return this.pila.Count;
		}
		public Comparable minimo()
		{
			Comparable menor= pila[0];
			foreach (Comparable c in pila) {
				if(menor.sosMayor(c)){
					menor = c;
				}
			}
			return menor;
		}
		public Comparable maximo()
		{
			Comparable mayor = pila[0];
			foreach (Comparable c in pila) {
				if (mayor.sosMenor(c)) {
					mayor = c;
				}
			}
			return mayor;
		}
		public void agregar(Comparable comparable)
		{
			this.pila.Add(comparable);
		}
		public bool contiene(Comparable comparable)
		{
			//podemos usar Contains(c) mas sencillo pero:
			for(int i=0;i < pila.Count;i++){
				if(comparable.sosIgual(pila[i])){
					return true;
				}
			}
			return false;
		}
		
		
		//Implementar mejor este metodo en el main para como una funcion para ver colecciones
		//mejoprar a una version mejor
//		public void mostrarColeccionPila(){
//			foreach(Comparable c in pila){
//				Console.WriteLine(c);
//			}
//		}
//		public override string ToString()
//		{
//		    return pila.ToString();
//		}

	}
}