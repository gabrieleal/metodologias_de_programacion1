/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 29/04/2021
 * Hora: 02:55 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of CompararPorPromedio.
	/// </summary>
	public class CompararPorPromedio:Estrategia
	{
		public CompararPorPromedio()
		{
		}
		
		public bool sosMenor(IComparable self, IComparable other)
		{
			if(((IAlumno)self).getPromedio()<((IAlumno)other).getPromedio()){
				return true;
			}
			return false;
		}
		public bool sosMayor(IComparable self, IComparable other)
		{
			if(((IAlumno)self).getPromedio()>((IAlumno)other).getPromedio()){
				return true;
			}
			return false;
		}
		public bool sosIgual(IComparable self, IComparable other)
		{
			if(((IAlumno)self).getPromedio().Equals(((IAlumno)other).getPromedio())){
				return true;
			}
			return false;
		}
	}
}
