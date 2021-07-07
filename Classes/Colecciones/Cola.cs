/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 18/04/2021
 * Hora: 10:08 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	public class Cola:IColeccionable,Iterable,IOrdenable
	{
		private List<IComparable> cola;
		
		IOrdenEnAula2 orden;
		IOrdenEnAula1 orden1,orden2;
		
		public Cola()
		{
			this.cola=new List<IComparable>();
		}

		#region Iterable implementation
		public iterador crearIterador()
		{
			return new IteradorGeneral(this.cola);
		}
		#endregion		
		public void push(IComparable elemento){
			cola.Add(elemento);
		}
		
		public IComparable pop(){
			IComparable e = cola[0];
			cola.RemoveAt(0);
			return e;
		}
		
		public bool isEmpty(){
			return cola.Count==0;
		}
		
		public IComparable top(){
			IComparable e = cola[0];
			return e;
		}
		
		
		#region IColeccionable implementation

		public int Cuantos()
		{
			return cola.Count;
		}

		public IComparable Minimo()
		{
			IComparable e =cola[0];
			int r=0;
			if(!this.isEmpty()){
				foreach(IComparable i in cola){
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
			IComparable e =cola[0];
			int r=0;
			if(!this.isEmpty()){
				foreach(IComparable i in cola){
					r++;
					if(r==0){
						continue;
					}else{
						if(e.sosMenor(i)){
							e=i;
						}
					}
				}
				return e;
			}else{
				return e;
			}
		}

		public void Agregar(IComparable c)
		{ 
			
			this.push(c);
			
			if(cola.Count==1) this.orden1.ejecutar();
			
			this.orden.ejecutar(c);
			
			if(cola.Count == 40) this.orden2.ejecutar();
			
		}

		public bool Contiene(IComparable c)
		{
			foreach(IComparable i in this.cola){
				if((i).sosIgual(c)){
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

