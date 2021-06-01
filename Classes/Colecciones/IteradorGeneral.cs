/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 30/04/2021
 * Hora: 05:00 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of IteradorGeneral.
	/// </summary>
	public class IteradorGeneral:iterador
	{	
		List<IComparable> lista;
		int pagActual;
		
		public IteradorGeneral(List<IComparable> doc)
		{
			this.lista=doc;
			this.Primero();
		}

		#region iterador implementation

		public void Primero()
		{
			this.pagActual=0;
		}

		public void Siguiente()
		{
			this.pagActual++;
		}

		public bool Fin()
		{
			return pagActual.Equals(this.lista.Count);
		}

		public IComparable Actual()
		{
			return (IComparable)this.lista[pagActual];
		}

		#endregion
	}
}
