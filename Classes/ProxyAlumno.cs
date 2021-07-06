/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 06/07/2021
 * Hora: 12:23 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1.Classes
{
	/// <summary>
	/// Description of ProxyAlumno.
	/// </summary>
	public class ProxyAlumno:IAlumno
	{	
		string nombre;
		int Legajo,dni;
		double Promedio;
		Estrategia Compara;
		double calificacion;
		IAlumno alumno;
		IComparableDeseado deseado;
		
		public ProxyAlumno(string n, int dni, int legajo,double prom,IComparableDeseado com)
		{
			this.nombre=n;
			this.dni=dni;
			this.Legajo=legajo;
			this.Promedio=prom;
			this.deseado=com;
			this.Compara=new CompararPorPromedio();
		}

		#region IAlumno implementation

		public int getLegajo()
		{
			return this.Legajo;
		}

		public double getPromedio()
		{
			return this.Promedio;
		}

		
		public Estrategia getCompara()
		{
			return this.Compara;
		}
		

		public void setCompara(estrategia nuevaEstrategia)
		{
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

		public int responderPregunta(int pregunta)
		{
			if(this.alumno==(null)){
				alumno=(IAlumno)FactoryMethodIComparable.fabricaIComparable(this.deseado);
			}
			return  alumno.responderPregunta(pregunta);
		}

		public double Calificacion()
		{
			return calificacion;
		}

		public void Calificacion(double value)
		{
			this.calificacion = value;
		}
		public string getNombre(){
			return this.nombre;
		}
		public int getDni(){
			return this.dni;
		}

		#endregion

		#region ICalificacionDecorator implementation

		public string mostrarCalificacion()
		{
			return calificacion.ToString();
		}

		public int mostrarLegajo()
		{
			return getLegajo();
		}

		public double mostrarNota()
		{
			return Calificacion();
		}

		#endregion

		#region IComparable implementation

		new public bool sosMenor(IComparable c)
		{
			return Compara.sosMenor(this,c);
		}

		new public string toString()
		{
			return String.Format("nombre:{0} dni:{1} legajo: {2}",this.nombre,this.dni,this.Legajo);
		}

		new public bool sosIgual(IComparable c)
		{
			return Compara.sosIgual(this,c);
		}
		new public bool sosMayor(IComparable c)
		{
			return Compara.sosMayor(this,c);
		}

		#endregion
	}
}
