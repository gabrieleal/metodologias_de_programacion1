/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 23/06/2021
 * Hora: 12:56 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1.Classes
{
	/// <summary>
	/// Description of DecoratorAbstract.
	/// </summary>
	public abstract class DecoratorAbstract : ICalificacionDecorator
	{
		ICalificacionDecorator core;

		#region ICalificacionDecorator implementation

		public virtual string mostrarCalificacion()
		{
			return core.mostrarCalificacion();
		}

		public int mostrarLegajo()
		{
			return core.mostrarLegajo();
		}
		
		public double mostrarNota()
		{
			return this.core.mostrarNota();
		}
		#endregion
		public void setCore(ICalificacionDecorator _core){
			this.core=_core;
		}
		public ICalificacionDecorator getCore(){
			return this.core;
		}
		
	}
}