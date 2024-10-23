/*
 * Creado por SharpDevelop.
 * Usuario: Estudiante
 * Fecha: 14/10/2024
 * Hora: 08:17
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Wilson_Metodologias
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona : Comparable
	{
		// implementar la clase Persona ejercicio 11 y que implemente la interface Comparable
		
		
		private string nombre;
		private int dni;
		public Persona(string nom, int doc)
		{
			this.nombre = nom;
			this.dni = doc;
		}
		
		// getters
		public string getNombre(){
			return this.nombre;
		}
		
		public int getDNI(){
			return this.dni;
		}
		
		// Implementacion de Interface Comparable 
		
		// por Dni sos Igual
		public virtual bool sosIgual(Comparable c)
		{
			return this.dni == ((Persona)c).getDNI();
		}
		public virtual bool sosMenor(Comparable c)
		{
			return this.dni < ((Persona)c).getDNI();
		}
		public virtual bool sosMayor(Comparable c)
		{
			return this.dni > ((Persona)c).getDNI();
		}
		
		public override string ToString()
		{
		    return nombre.ToString();
		}
		
	}
}
