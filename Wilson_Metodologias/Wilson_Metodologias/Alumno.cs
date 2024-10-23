/*
 * Creado por SharpDevelop.
 * Usuario: Estudiante
 * Fecha: 15/10/2024
 * Hora: 04:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Wilson_Metodologias
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno : Persona
	{
		private int legajo;
		private double promedio;
		
		
		/*primero el constructor inicializa  el constrcutor de :base(nombre,dni) 
		 respetando el orden y tipo de dato que recibe la superclase en este caso Persona
		 supongamos un ejemplo inicialiozamos un objeto de Alumno
		 Alumno alum1 = new Alumno("Wilson",32423234,23412,8.5)
		 en este caso el Constrcutor de Alumno primero va a pasarle los datos a Persona mediante 
		 el : Base(nombre,dni)  nombre  = wilson , dni = 3223234 -> esto le llega al constructor de Persona y el lo  recibe  mediante su Constructor 
		 para luego asignarle los valores a this.nombre y this.dni, Luego de haber hecho todo eso vuelve al Constrcutor de Alumno para 
		 guardar los propios valores  que recibe el de Alumno , en este caso va a guardar this.legajo = 23412 y this.promedio = 8.5
		 Esta es la manera en como opera la herencia al tener un relacion entre sus Constructores*/
		
		public Alumno(string nombre,int dni,int l ,double p):base(nombre,dni)
		{
			this.legajo = l;
			this.promedio = p;
		}
		
		public int getLegajo(){
			return this.legajo;
		}
		
		public double getPromedio(){
			return this.promedio;
		}
		
		//Redefinimos los metodos de comparable Ejercicio 18
		public override bool sosIgual(Comparable c)
		{
			return this.legajo == ((Alumno)c).getLegajo();
		}
		public override bool sosMenor(Comparable c)
		{
			return this.legajo < ((Alumno)c).getLegajo();
		}
		public override bool sosMayor(Comparable c)
		{
			return this.legajo > ((Alumno)c).getLegajo();
		}
		
	
	}
}
