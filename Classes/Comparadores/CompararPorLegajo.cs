/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 27/04/2021
 * Hora: 07:00 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of CompararPorLegajo.
	/// </summary>
	public class CompararPorLegajo : Estrategia
	{
		public CompararPorLegajo()
		{
		}

		
		#region Estrategia implementation
		public bool sosMenor(IComparable self, IComparable other)
		{
			if(((Alumno)self).getLegajo()<((Alumno)other).getLegajo()){
				return true;
			}
			return false;
		}
		public bool sosMayor(IComparable self, IComparable other)
		{
			if(((Alumno)self).getLegajo()>((Alumno)other).getLegajo()){
				return true;
			}
			return false;
		}
		public bool sosIgual(IComparable self, IComparable other)
		{
			if(((Alumno)self).getLegajo()==((Alumno)other).getLegajo()){
				return true;
			}
			return false;
		}
		#endregion
	}
}
