/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 19/04/2021
 * Hora: 02:06 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class ColeccionMultiple: IColeccionable
	{	
		private Pila pila;
		private Cola cola;
		
		
		public ColeccionMultiple(Pila p, Cola c)
		{
			this.pila=p;
			this.cola=c;
		}

		public iterador crearIterador()
		{
			throw new NotImplementedException();
		}
		#region IColeccionable implementation

		public int Cuantos()
		{
			return (pila.Cuantos()+cola.Cuantos());
		}

		public IComparable Minimo()
		{	
			if((pila.Minimo()).sosMenor((cola.Minimo()))){
				return pila.Minimo();
			}
			return cola.Minimo();
		}

		public IComparable Maximo()
		{
			if((pila.Maximo()).sosMayor((cola.Maximo()))){
				return pila.Maximo();
			}
			return cola.Maximo();
		}

		public void Agregar(IComparable c)
		{	//No Hace Nada
			throw new NotImplementedException();
		}

		public bool Contiene(IComparable c)
		{
			if(pila.Contiene(c) || cola.Contiene(c)){
				return true;
			}
			return false;
		}

		#endregion
	}
}
