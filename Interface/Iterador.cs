/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 30/04/2021
 * Hora: 03:27 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of IteradorDePaginas.
	/// </summary>
	public interface iterador
	{
		void Primero();
		void Siguiente();
		bool Fin();
		IComparable Actual();
	}
}
