/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 29/04/2021
 * Hora: 06:55 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of ClaveValor.
	/// </summary>
	public class ClaveValor
	{	
		private Object valor;
		private IComparable clave;		
		public ClaveValor()
		{
		}

	
		public ClaveValor(Object value,IComparable clave)
		{
			this.Clave=clave;
			this.Valor=value;
		}
		
		
		public Object Valor {
			get {
				return valor;
			}
			set {
				valor = value;
			}
		}


		public IComparable Clave {
			get {
				return clave;
			}
			set {
				clave = value;
			}
		}
	}
}
