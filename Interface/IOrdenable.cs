/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 07/07/2021
 * Hora: 12:23 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1.Interface
{
	/// <summary>
	/// Description of IOrdenable.
	/// </summary>
	public interface IOrdenable
	{
		void setOrdenInicio(IOrdenEnAula1 o);
		void setOrdenLlegaAlumno(IOrdenEnAula2 o);
		void setOrdenAulaLlena(IOrdenEnAula1 o);
		
				
	}
}
