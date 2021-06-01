/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 19/04/2021
 * Hora: 02:58 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public enum estrategia{Nombre,Legajo,Promedio,Dni};
	public class Alumno:Persona
	{
		
		private int Legajo;
		private double Promedio;
		private Estrategia Compara;
		
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
