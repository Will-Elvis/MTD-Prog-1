/*
 * Creado por SharpDevelop.
 * Usuario: Estudiante
 * Fecha: 12/10/2024
 * Hora: 21:01
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Wilson_Metodologias
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			// Instaciamos Random (para solucionar problema con el metodo LLenar) 
			Random random = new Random();
			
			//--- prueba de Comparable 
			Numero num1 = new Numero(5);
			Numero num2 = new Numero (4);
			Console.WriteLine("Es Igual: " +  num1.sosIgual(num2));
			Console.WriteLine("Es Mayor :" + num1.sosMayor(num2));
			Console.WriteLine("Es Menor: " + num1.sosMenor(num2));
			
			// ---- ejercicio 4 ---- cola de Enteros 
//			Cola co1 = new Cola();
//			co1.encolar(num1);
//			Console.WriteLine(co1.cuantos());
//			co1.encolar(2);
//			co1.encolar(5);
//			Console.WriteLine(co1.desencolar());
//			
//			Pila p1 = new Pila();
//			p1.apilar(4);
//			p1.apilar(3);
//			p1.apilar(2);
//			p1.apilar(1);
//			Console.WriteLine(p1.desapilar());
//			
			
			//Lenar Pila Con funcion llenar
//			Pila p1 = new Pila();
//			llenar(p1);
//			// usamos el foreach para ver lo valores Rellenados
//			Console.WriteLine("==============  Muestra de la PIla LLENA ===============");
//			mostrarColeccion(p1);
//			foreach(Comparable p in p1.getPila()){
//				Console.WriteLine(p);
//			}
			
			//====== ejercicio 6 prueba  de Funcionamineto ============
//			informar(p1);
			
//			======== Ejercicio 7 ===========================
			//crear pila y cola
			Pila pila = new Pila();
			Cola cola = new Cola();
			Pila pilaPersonas = new Pila();
			Cola colaPersonas = new Cola();
			Cola colaAlum = new Cola();
			Pila pilaAlum = new Pila();
			
			//Llenar Pila y cola 
			llenar(pila,random);
			llenar(cola,random);
			llenarPersonas(pilaPersonas,random);
			llenarPersonas(colaPersonas,random);
			llenarAlumnos(colaAlum,random);
			llenarAlumnos(pilaAlum,random);
			
			
			//mostra valores de pila y cola con la sobrecarga de metodos creada debajo
			mostrarColeccion(pila);
			mostrarColeccion(cola);
			mostrarColeccionPersona(pilaPersonas);
			mostrarColeccionPersona(colaPersonas);
			mostrarColeccionAlumno(pilaAlum);
			mostrarColeccionAlumno(colaAlum);
			IColeccionable multipleAlumnos = new ColeccionMultiple(pilaAlum,colaAlum);
			informarAlumnos(multipleAlumnos);
			
			// ejercicio 13 MAIN (Coleccion Multiple de personas)
			IColeccionable multiplePersonas = new ColeccionMultiple(pilaPersonas,colaPersonas);
			informarPersona(multiplePersonas);
			
			//Informar Pila y cola
			informar(pila);
			informar(cola);
			
			// ==== Ejercicio 9 ====
			
			IColeccionable multiple = new ColeccionMultiple(pila,cola);
			informar(multiple);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static void llenar( IColeccionable colecc,Random r){
			//Random r = new Random(); // esta linea lo lleve al main  para pasarlo por parametro a la instancia creada debido
			// a que me generaba un error de repetimiento exacto en cada una de las colecciones que llenaba
			for(int i = 0; i < 20;i++){
				int numero_aleatorio = r.Next(0,101); // genera numero ramdon del 0 al 100
				Comparable comparable = new Numero(numero_aleatorio);
				colecc.agregar(comparable);
			}
		}
		
		// funciona correctamente 
		// Error que tenia era en la clase Pila en el metodo Contiene
		// dentrod el if puse incorrectamente (comparable == pila[i])  esto es incorrecto debido a que estoy
		//diciendo si el objeto recibido por parametro el identicamnte igual es decir el mismo objeto esto es incorrecto ya que los 
		//dos objestos se crearon en distintas instacias pero puede que con el mismo valor  al usar == estamos verificando si es el mismo objeto no el valor que contiene
		// es por eso que usamos el metodo comparable.sosIgual(pila[i]) es cual si va a revisar los valores no el objeto
		public static void informar(IColeccionable colecc){
			Console.WriteLine("Informacion sobre:" + colecc);
			Console.WriteLine("Cantidad de Elementos en la Coleccion: "+colecc.cuantos());
			Console.WriteLine("Elemento con el valor Minimo dentro de la Coleccion: "+colecc.minimo());
			Console.WriteLine("Elemento con el valor Maximo dentro de la Coleccion: "+colecc.maximo());
			Console.Write("Ingrese un Valor para buscar en la Coleccion:");
			int valorPorteclado = int.Parse(Console.ReadLine());
			Comparable comparable = new Numero(valorPorteclado);
			if (colecc.contiene(comparable)){// esto retorna true o false
				Console.WriteLine("El Elemento Compable Si se encuentra en la Coleccion que almacena Comparables");
			}
			else
				Console.WriteLine("El Elemento Compable NO se encuentra en la Coleccion que almacena Comparables");
		}
		// sobrecarga para consultar Personas
		public static void informarPersona(IColeccionable colecc){
			Console.WriteLine("Informacion sobre:" + colecc);
			Console.WriteLine("Cantidad de Elementos en la Coleccion: "+colecc.cuantos());
			Console.WriteLine("Elemento con el valor Minimo dentro de la Coleccion: "+colecc.minimo());
			Console.WriteLine("Elemento con el valor Maximo dentro de la Coleccion: "+colecc.maximo());
			Console.Write("Ingrese el Dni :");
			int docu = int.Parse(Console.ReadLine());
			Console.Write("Ingrese Nombre: ");
			string nom = Console.ReadLine();
			Comparable persona = new Persona(nom,docu);
			if (colecc.contiene(persona)){// esto retorna true o false(si es true entra en el IF)
				Console.WriteLine("El Elemento Compable Si se encuentra en la Coleccion que almacena Comparables");
			}
			else
				Console.WriteLine("El Elemento Compable NO se encuentra en la Coleccion que almacena Comparables");
		}
		
		public static void informarAlumnos(IColeccionable colecc){
			Console.WriteLine("Informacion del Coleccionable");
			Console.WriteLine("Cantidad de Elementos en la Coleccion: "+colecc.cuantos());
			Console.WriteLine("Elemento con el valor Minimo dentro de la Coleccion: "+colecc.minimo());
			Console.WriteLine("Elemento con el valor Maximo dentro de la Coleccion: "+colecc.maximo());
			Console.Write("Ingrese el Dni para buscar:");
			int docu = int.Parse(Console.ReadLine());
			Console.Write("Ingrese Nombre: ");
			string nom = Console.ReadLine();
			Console.Write("ingrese Leagajo: ");
			int lej = int.Parse(Console.ReadLine());
			Console.Write("Ingrese Promedio: ");
			double prom = double.Parse(Console.ReadLine());
			Comparable alumno = new Alumno(nom,docu,lej,prom);
			if(colecc.contiene(alumno)){
				Console.WriteLine("El Elemento Compable Si se encuentra en la Coleccion que almacena Comparables");
			}
			else
				Console.WriteLine("El Elemento Compable NO se encuentra en la Coleccion que almacena Comparables");
		}
		
		/*Luego CONTINUAR CON ALUMNOS INFORMAR*/
		
		/*// sobrecarga para consultar Personas
		public static void informar(IColeccionable colecc,int dni){
			Console.WriteLine("Informacion sobre:" + colecc);
			Console.WriteLine("Cantidad de Elementos en la Coleccion: "+colecc.cuantos());
			Console.WriteLine("Elemento con el valor Minimo dentro de la Coleccion: "+colecc.minimo());
			Console.WriteLine("Elemento con el valor Maximo dentro de la Coleccion: "+colecc.maximo());
			Comparable comparable = new Persona("desconocido", dni);
			if (colecc.contiene(comparable)){// esto retorna true o false(si es true entra en el IF)
				Console.WriteLine("El Elemento Compable Si se encuentra en la Coleccion que almacena Comparables");
			}
			else
				Console.WriteLine("El Elemento Compable NO se encuentra en la Coleccion que almacena Comparables");
		}*/
		
		
		
		// Sobrecarga de Metodo mostrarColeccion
		public static void mostrarColeccion(Pila p){
			Console.WriteLine("======= Inicio ====");
			foreach(Comparable c in p.getPila()){
				Console.WriteLine(c);
			}
			Console.WriteLine("======= Fin ====");
		}
		public static void mostrarColeccion(Cola co){
			Console.WriteLine("======= Inicio ====");
			foreach(Comparable c in co.getCola()){
				Console.WriteLine(c);
			}
			Console.WriteLine("======= Fin ====");
		}
		public static void mostrarColeccionPersona(Pila pi){
			Console.WriteLine("======= Inicio ====");
			foreach(Persona p in pi.getPila()){
				Console.Write("Nombre:"+p.getNombre());
				Console.WriteLine(" | Documento: "+p.getDNI());
			}
			Console.WriteLine("======= Fin ====");
		}
		public static void mostrarColeccionPersona(Cola co){
			Console.WriteLine("======= Inicio ====");
			foreach(Persona p in co.getCola()){
				Console.Write("Nombre:"+p.getNombre());
				Console.WriteLine(" | Documento: "+p.getDNI());
			}
			Console.WriteLine("======= Fin ====");
		}
		public static void mostrarColeccionAlumno(Cola co){
			Console.WriteLine("======= Inicio ====");
			foreach(Alumno a in co.getCola()){
				Console.Write("Nombre:"+a.getNombre());
				Console.Write(" | Documento: "+a.getDNI());
				Console.Write(" | Legajo: "+ a.getLegajo());
				Console.WriteLine(" | Promedio: "+ a.getPromedio());
			}
			Console.WriteLine("======= Fin ====");
		}
		public static void mostrarColeccionAlumno(Pila pi){
			Console.WriteLine("======= Inicio ====");
			foreach(Alumno p in pi.getPila()){
				Console.Write("Nombre:"+p.getNombre());
				Console.Write(" | Documento: "+p.getDNI());
				Console.Write(" | Legajo: "+ p.getLegajo());
				Console.WriteLine("| Promedio: "+ p.getPromedio());
			}
			Console.WriteLine("======= Fin ====");
		}
		
		public static void llenarPersonas(IColeccionable colecc, Random r){
			 // uso de la clase Random sintaxis = tipovar nombrvar = r.Next(0,101) generar valores azar del 0 al  100
			string[] nombres = {"Wilson", "Elvis","Juan", "Marcos","Pedro","Lucas","Classwizz","Ana","Julia","Marts"}; // 10 nombres
			for(int i = 0 ; i < 20 ; i++){
				string nombreAleatorio = nombres[r.Next(nombres.Length)]; // (vector)nombre.Length =  (arraylist)nombres.Count
				int docAleatorio = r.Next(20000000,90000000);
				//inicializacion de Pesonas
				Comparable personaComparable= new Persona(nombreAleatorio,docAleatorio);
				colecc.agregar(personaComparable);
			}
		}
		
		public static void llenarAlumnos(IColeccionable colecc,Random r){
			string[] nombresDeAlumno = {"Alumno1","Alumno2","Alumno3","Alumno4","Alumno5","Alumno6","Alumno7","Alumno8","Alumno9","Alumno10"};
			for(int i = 0 ; i < 20 ; i++){
				string nombreAleatorio = nombresDeAlumno[r.Next(nombresDeAlumno.Length)];
				int documentoAleatorio = r.Next(20000000,80000001);
				int legajoAleaotorio = r.Next(1000,10000);
				int promedioAleatorio = r.Next(11); // genera del 0 al 10 sin incluir el 11
				Alumno alumno = new Alumno(nombreAleatorio,documentoAleatorio,legajoAleaotorio,promedioAleatorio);
				colecc.agregar(alumno);
			}
			
		}
	}
}