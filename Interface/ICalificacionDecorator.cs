/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 21/06/2021
 * Hora: 07:16 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1.Interface
{
	/// <summary>
	/// Description of ICalificacionDecorator.
	/// </summary>
	public interface ICalificacionDecorator
	{
		string mostrarCalificacion();
		int mostrarLegajo();
		double mostrarNota();
	}
}
