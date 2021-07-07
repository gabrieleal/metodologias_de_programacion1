/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 27/06/2021
 * Hora: 07:29 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1.Classes
{
	/// <summary>
	/// Description of decoratorRecuadro.
	/// </summary>
	public class DecoratorRecuadro: DecoratorAbstract
	{
		public DecoratorRecuadro(ICalificacionDecorator _core)
		{
			this.setCore(_core);
		}
		
		public override string mostrarCalificacion()
		{
			string cal="*******************************************\n**";
			cal+=this.getCore().mostrarCalificacion();
			cal+="**\n*******************************************";
			
			return cal;
		}
	}
}
