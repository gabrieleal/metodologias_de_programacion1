/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 06/07/2021
 * Hora: 01:02 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1.Classes
{
	/// <summary>
	/// Description of OrdenInicio.
	/// </summary>
	public class OrdenInicio:IOrdenEnAula1
	{	
		Aula t;

		
		
		public OrdenInicio()
		{
		}

		#region IOrdenEnAula1 implementation

		public void ejecutar()
		{
			this.t.comenzar();
		}

		#endregion
		
		
		
		public Aula T {
			get {
				return t;
			}
			set {
				t = value;
			}
		}
	}
}
