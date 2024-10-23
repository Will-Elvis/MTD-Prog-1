/*
 * Creado por SharpDevelop.
 * Usuario: Estudiante
 * Fecha: 12/10/2024
 * Hora: 22:59
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Wilson_Metodologias
{
	/// <summary>
	/// Description of IColeccionable.
	/// </summary>
	public interface IColeccionable
	{
		// ---- Ejercicio 3 ----
		int cuantos();
		Comparable minimo();
		Comparable maximo();
		void agregar(Comparable comparable);
		bool contiene(Comparable comparable);
	}
}
