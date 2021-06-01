/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 28/04/2021
 * Hora: 10:10 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of CompararPorDni.
	/// </summary>
	public class CompararPorDni:Estrategia
	{
		public CompararPorDni()
		{
		}
		
		#region Estrategia implementation
		public bool sosMenor(IComparable self, IComparable other)
		{
			if(((Persona)self).getDni()<((Persona)other).getDni()){
				return true;
			}
			return false;
		}
		public bool sosMayor(IComparable self, IComparable other)
		{
			if(((Persona)self).getDni()>((Persona)other).getDni()){
				return true;
			}
			return false;
		}
		public bool sosIgual(IComparable self, IComparable other)
		{
			if(((Persona)self).getDni()==((Persona)other).getDni()){
				return true;
			}
			return false;
		}
		#endregion
		
	}
}
