/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 06/07/2021
 * Hora: 01:05 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1.Classes
{
	/// <summary>
	/// Description of OrdenLlegaAlumno.
	/// </summary>
	public class OrdenLlegaAlumno:IOrdenEnAula2
	{	
		Aula t;
		
		public OrdenLlegaAlumno()
		{
		}

		#region IOrdenEnAula2 implementation

		public void ejecutar(IComparable c)
		{
			this.t.nuevoAlumno((IAlumno)c);
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
