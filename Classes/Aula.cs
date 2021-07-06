/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 06/07/2021
 * Hora: 12:56 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1.Classes
{
	/// <summary>
	/// Description of Aula.
	/// </summary>
	public class Aula
	{	
		Teacher t;
		IOrdenEnAula1 push;
		IOrdenEnAula1 com;
		List<IOrdenEnAula2> pop;
		public Aula()
		{
		}
		
		public void comenzar(){
			Console.WriteLine("Cominzan las clases");
			if(push!=null){
				push.ejecutar();
			}
		}
		
		public void nuevoAlumno(IAlumno a){
			foreach(var i in pop){
				i.ejecutar(a);
			}
		}
		
		public void claseLista(){
			if(com!=null){
				com.ejecutar();
			}
		}
		
		public void addPush(IOrdenEnAula1 o){
			push=(o);
			((OrdenInicio)push).T=this.t;
		}
		public void addCom(IOrdenEnAula1 o){
			Com=(o);
			((OrdenLlegaAlumno)Com).T=this.t;
		}
		public void addPop(IOrdenEnAula2 o){
			((OrdenLlegaAlumno)o).T=this.t;	
			pop.Add(o);
		}
		
		public IOrdenEnAula1 Com {
			get {
				return com;
			}
			set {
				com = value;
			}
		}
	}
}
