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
		Teacher t;
		
		public OrdenLlegaAlumno()
		{
		}

		#region IOrdenEnAula2 implementation

		public void ejecutar(IComparable c)
		{
			this.t.goToClass(new AdapterStudent(((IAlumno)c)));
		}

		#endregion

		public Teacher T {
			get {
				return t;
			}
			set {
				t = value;
			}
		}
	}
}
