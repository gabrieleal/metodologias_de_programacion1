/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 21/06/2021
 * Hora: 08:44 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1.Classes
{
	/// <summary>
	/// Description of LegajoDecorator.
	/// </summary>
	public  class LegajoDecorator:DecoratorAbstract
	{	
		public LegajoDecorator (ICalificacionDecorator _core) {
			base.setCore(_core);
		}
		public override string mostrarCalificacion(){
			string cal = this.getCore().mostrarCalificacion();
			cal +=this.mostrarLegajo().ToString();
			return cal ;
		}
		
	}
}
