/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 18/04/2021
 * Hora: 10:02 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of IColeccionable.
	/// </summary>
	public interface IColeccionable:Iterable
	{
		int Cuantos();
		IComparable Minimo();
		IComparable Maximo();
		void Agregar(IComparable c);
		bool Contiene(IComparable c);
		
		
	}
}
