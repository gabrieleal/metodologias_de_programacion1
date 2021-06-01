/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 29/04/2021
 * Hora: 06:45 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto : IColeccionable
	{	
		private List<IComparable> lista = new List<IComparable>();
		
		public Conjunto()
		{
		}
		
		public void Agregar(IComparable elemento){
			if(this.Pertenece(elemento)){
				return;
			}
			this.lista.Add(elemento);
		}
		
		public bool Pertenece(IComparable elemento){
			foreach(IComparable elem in this.lista){
				if(elemento.Equals(elem)){
					return true;
				}
			}
			return false;
		}

		public iterador crearIterador()
		{
			return new IteradorGeneral(this.lista);
		}
		
		
		#region IColeccionable implementation
		public int Cuantos()
		{
			return this.lista.Count;
		}
		public IComparable Minimo()
		{
			IComparable elemento = this.lista[0];
			foreach(IComparable elem in this.lista){
				if(elemento.sosMayor(elem)){
					elemento=elem;
				}
			}
			return elemento;
		}
		public IComparable Maximo()
		{	IComparable elemento = this.lista[0];
			foreach(IComparable elem in this.lista){
				if(elemento.sosMenor(elem)){
					elemento=elem;
				}
			}
			return elemento;
		}
		public bool Contiene(IComparable c)
		{	
			return this.Pertenece(c);
		}
		#endregion
	}
}
