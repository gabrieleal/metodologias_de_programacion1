/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 09/05/2021
 * Hora: 09:12 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of Observable.
	/// </summary>
	public interface Observable
	{
		void agregar(Observador v);
		void notificar();
		void quitar(Observador v);
	}
}
