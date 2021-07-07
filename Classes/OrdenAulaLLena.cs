/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 06/07/2021
 * Hora: 01:03 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1.Classes
{
	/// <summary>
	/// Description of OrdenAulaLLena.
	/// </summary>
	public class OrdenAulaLLena:IOrdenEnAula1
	{	
		Aula t;

		
		public OrdenAulaLLena(Aula a)
		{
			this.t = a;
		}

		#region IOrdenEnAula1 implementation

		public void ejecutar()
		{
			this.t.claseLista();
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
