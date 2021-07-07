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
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of Conjunto.
	/// </summary>
	public class Conjunto : IColeccionable,IOrdenable
	{	
		private List<IComparable> lista = new List<IComparable>();
		
		
		IOrdenEnAula2 orden;
		IOrdenEnAula1 orden1,orden2;
		
		
		public Conjunto()
		{
		}
		
		public void Agregar(IComparable elemento){
			if(this.Pertenece(elemento)){
				return;
			}
			this.lista.Add(elemento);
			
			if(this.lista.Count==1 && this.orden1 != null) this.orden1.ejecutar();
			
			if(this.orden != null) this.orden.ejecutar(elemento);
			
			if(this.lista.Count == 40 && this.orden2 != null) this.orden2.ejecutar();
			
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
		
		#region IOrdenable implementation

		public void setOrdenInicio(IOrdenEnAula1 o)
		{
			this.orden1 = o;
		}

		public void setOrdenLlegaAlumno(IOrdenEnAula2 o)
		{
			this.orden=o;
		}

		public void setOrdenAulaLlena(IOrdenEnAula1 o)
		{
			this.orden2 = o;
		}

		#endregion
	}
}
