/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 18/04/2021
 * Hora: 09:50 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of Comparable.
	/// </summary>
	public interface IComparable
	{	
		bool sosMenor(IComparable c);
		bool sosIgual(IComparable c);
		bool sosMayor(IComparable c);
		String toString();
		
	}
}
