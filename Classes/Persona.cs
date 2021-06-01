/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 19/04/2021
 * Hora: 02:24 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona : IComparable
	{	
		private String nombre;
		private int dni;
		
		public Persona(string nombre, int dni)
		{
			this.nombre=nombre;
			this.dni=dni;
			
		}
		
		public string getNombre(){
			return this.nombre;
		}
		
		public int getDni(){
			return this.dni;
		}
		
		#region IComparable implementation
		public bool sosMenor(IComparable c)
		{
			if(this.dni<((Persona)c).getDni()){
				return true;
			}
			return false;
		}

		public string toString()
		{
			return String.Format("nombre:{0} dni:{1}",this.nombre,this.dni);
		}

		public bool sosIgual(IComparable c)
		{
			if(this.dni.Equals(((Persona)c).getDni())){
				return true;
			}
			return false;
		}
		public bool sosMayor(IComparable c)
		{
			if(this.dni>((Persona)c).getDni()){
				return true;
			}
			return false;
		}
		#endregion
	}
}
