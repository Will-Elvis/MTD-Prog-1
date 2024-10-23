/*
 * Creado por SharpDevelop.
 * Usuario: Estudiante
 * Fecha: 12/10/2024
 * Hora: 21:35
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Wilson_Metodologias
{
	/// <summary>
	/// Description of Numero.
	/// </summary>
	public class Numero : Comparable
	{
		// --- ejercicio 2 ----
		private int valor;
		
		public Numero(int v)
		{
			this.valor = v;
		}
		
		private int getValor(){
			return this.valor;
		}
		
		// Implementacion de Comparable
		public bool sosIgual(Comparable c)
		{
			return this.valor == ((Numero)c).getValor();
		}
		public bool sosMenor(Comparable c)
		{
			return this.valor < ((Numero)c).getValor();
		}
		public bool sosMayor(Comparable c)
		{
			return this.valor > ((Numero)c).getValor();
		}
		
		// Sobrescribir el método ToString para devolver el valor.
		public override string ToString()
		{
		    return valor.ToString();
		}
	}
}
