/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 29/04/2021
 * Hora: 11:46 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of Diccionario.
	/// </summary>
	public class Diccionario:IColeccionable,Iterable,IDiccionario<ClaveValor>,IOrdenable
	{	
		List<ClaveValor> dicc = new List<ClaveValor>();	
		IOrdenEnAula2 orden;
		IOrdenEnAula1 orden1,orden2;
		
		public Diccionario()
		{
		}

		#region Iterable implementation
		public iterador crearIterador()
		{
			return new IteradorDiccionario(this);
		}
		#endregion		
		#region IDiccionario implementation


		public List<ClaveValor> getDiccionario()
		{
			return this.dicc;
		}


		#endregion

		public void agregar(IComparable clave, Object valor){
			
			ClaveValor newClaveValor = new ClaveValor(valor,clave);
			
			this.dicc.Add(newClaveValor);
			
			if(this.dicc.Count==1 && this.orden1 != null) this.orden1.ejecutar();
			
			if(this.orden != null) this.orden.ejecutar((IComparable)newClaveValor.Valor);
			
			if(this.dicc.Count == 40 && this.orden2 != null) this.orden2.ejecutar();
		}
		
		public Object valorDe(IComparable clave){
			foreach (ClaveValor i in this.dicc){
				if(i.Clave.sosIgual(clave)){
					return i.Valor;
				}
			}
			return null;
		}
		
		#region IColeccionable implementation
		public int Cuantos()
		{
			return this.dicc.Count;
		}
		public IComparable Minimo()
		{	
			IComparable i=this.dicc[0].Clave;
			int vuelta = -1;
			foreach(ClaveValor elemento in this.dicc){
				vuelta++;
				if(vuelta<1){
					continue;
				}else{
					if(elemento.Clave.sosMenor(i)){
						i=elemento.Clave;
					}
				}	
			}
			return i;
		}
		public IComparable Maximo()
		{
			IComparable i=this.dicc[0].Clave;
			int vuelta = -1;
			foreach(ClaveValor elemento in this.dicc){
				vuelta++;
				if(vuelta<1){
					i=elemento.Clave;
				}else{
					if(elemento.Clave.sosMayor(i)){
						i=elemento.Clave;
					}
				}
			}
			return i;
		}
		public void Agregar(IComparable c)
		{
			this.dicc.Add(new ClaveValor("def",c));
		}
		public bool Contiene(IComparable c)
		{
			foreach(ClaveValor elemento in this.dicc){
				if(elemento.Valor.Equals(c)){
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
