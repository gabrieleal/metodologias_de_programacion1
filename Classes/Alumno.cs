/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 19/04/2021
 * Hora: 02:58 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Runtime.CompilerServices;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	
	public enum estrategia{Nombre,Legajo,Promedio,Dni};
	
	public class Alumno:Persona,ICalificacionDecorator
	{
		
		private int Legajo;
		private double Promedio;
		private Estrategia Compara;
		double calificacion;
		
		public Alumno(string n, int dni, int legajo,double prom,Estrategia Compara):base(n,dni)
		{
			this.Legajo=legajo;
			this.Promedio=prom;
			this.Compara=Compara;
		}
		
		public int getLegajo(){
			return this.Legajo;
		}
		public double getPromedio(){
			return this.Promedio;
		}
		
		public Estrategia getCompara(){
			return Compara;
		}
		
		public void setCompara(estrategia nuevaEstrategia){
			if(nuevaEstrategia.Equals(estrategia.Legajo)){
				this.Compara=new CompararPorLegajo();
			}
			else{
				if(nuevaEstrategia.Equals(estrategia.Promedio)){
					this.Compara=new CompararPorPromedio();
				}
				if(nuevaEstrategia.Equals(estrategia.Nombre)){
					this.Compara=new CompararPorNombre();
				}
				if(nuevaEstrategia.Equals(estrategia.Dni)){
					this.Compara=new CompararPorDni();
				}
			}
		}
		
		public virtual int responderPregunta(int pregunta){
			return pregunta % new Random().Next(1,3);
		}
		
		#region ICalificacionDecorator implementation
		public string mostrarCalificacion(){
			return String.Format("{0} - Calificacion : {1} ",this.getNombre(),this.calificacion);
		}

		public double mostrarNota()
		{
			return this.Calificacion();
		}
		public int mostrarLegajo()
		{
			return this.getLegajo();
		}
		
		
		#endregion
		public double Calificacion() {
				return calificacion;
		}
		public void Calificacion(double value) {
			calificacion = value;
		}
		
		new public bool sosMenor(IComparable c)
		{
			return Compara.sosMenor(this,c);
		}

		new public string toString()
		{
			return String.Format("nombre:{0} dni:{1} legajo: {2}",this.getNombre(),this.getDni(),this.Legajo);
		}

		new public bool sosIgual(IComparable c)
		{
			return Compara.sosIgual(this,c);
		}
		new public bool sosMayor(IComparable c)
		{
			return Compara.sosMayor(this,c);
		}
	}
}
