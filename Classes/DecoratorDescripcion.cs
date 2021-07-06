/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 27/06/2021
 * Hora: 07:07 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1.Classes
{
	/// <summary>
	/// Description of DecoratorDescripcion.
	/// </summary>
	public class DecoratorDescripcion: DecoratorAbstract
	{
		public DecoratorDescripcion(ICalificacionDecorator _core)
		{
			setCore(_core);
		}
		
		public override string mostrarCalificacion()
		{
			string calificacion = this.getCore().mostrarCalificacion();
			
			double nota = base.mostrarNota();
			
			if(nota<7){
				calificacion+= " (DESAPROBADO) ";
			}else{
				calificacion+= " (APROBADO) ";
			}
			return calificacion;
		}
		
		
	}
}
