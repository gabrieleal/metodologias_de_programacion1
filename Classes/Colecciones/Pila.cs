/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 18/04/2021
 * Hora: 10:08 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Collections.Generic;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of Pila.
	/// </summary>
	public class Pila : IColeccionable, Iterable
	{	
		private List<IComparable> lista;
		IOrdenEnAula2 orden;
		IOrdenEnAula1 orden1,orden2;
		
		public Pila()
		{
			lista=new List<IComparable>();
		}

		public List<IComparable> getConjunto(){
			return this.lista;
		}
		#region Iterable implementation
		public iterador crearIterador()
		{
			return new IteradorGeneral(this.lista);
		}
		#endregion		
		public void push(IComparable elemento){
			lista.Add(elemento);
			
			if(this.lista.Count==1 && this.orden1 != null) 
				this.orden1.ejecutar();
			
			if(this.orden != null) 
				this.orden.ejecutar(elemento);
			
			if(this.lista.Count == 40 && this.orden2 != null) 
				this.orden2.ejecutar();
		
		}
		
		public IComparable pop(){
			IComparable e = lista[lista.Count-1];
			lista.RemoveAt(lista.Count-1);
			return e;
		}
		
		public bool isEmpty(){
			return lista.Count==0;
		}
		
		public IComparable top(){
			return lista[lista.Count-1];
		}
		
		
		#region IColeccionable implementation

		
		public int Cuantos()
		{
			return lista.Count;
		}

		public IComparable Minimo()
		{
			IComparable e= lista[0];
			int r=0;
			if(!this.isEmpty()){
				foreach(IComparable i in lista){
					if(r==0){
						r++;
						continue;
					}else{
						if(e.sosMayor(i)){
							e=i;
						}
					}
					r++;
				}
				return e;
			}else{
				return e;
			}
		}

		public IComparable Maximo()
		{
			IComparable e =lista[0];
			int r=0;
			if(!this.isEmpty()){
				foreach(IComparable i in lista){
					if(r==0){
						r++;
						 
						continue;
					}else{
						if(e.sosMenor(i)){
							e=i;
						}
					}
					r++;
				}
				return e;
			}else{
				return e;
			}
		}

		public void Agregar(IComparable c)
		{
			this.push(c);
		}

		public bool Contiene(IComparable c)
		{
			foreach(IComparable i in this.lista){
				if(i.sosIgual(c)){
					return true;
				}
			}
			return false;
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
