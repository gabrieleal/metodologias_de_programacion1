/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 30/04/2021
 * Hora: 05:42 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of IteradorDiccionario.
	/// </summary>
	public class IteradorDiccionario:iterador
	{	List<ClaveValor> lista;
		int pagActual;
		
		public IteradorDiccionario(Diccionario d )
		{
			this.lista=d.getDiccionario();
			Primero();
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
			return this.pagActual.Equals(this.lista.Count);
		}

		public IComparable Actual()
		{
			return (IComparable)this.lista[this.pagActual];
		}

		#endregion
	}
}
