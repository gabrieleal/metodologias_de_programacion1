/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 28/04/2021
 * Hora: 10:19 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of CompararPorNombre.
	/// </summary>
	public class CompararPorNombre:Estrategia
	{
		public CompararPorNombre()
		{
		}
		public bool sosMenor(IComparable self, IComparable other)
		{
			if(((Persona)self).getNombre().Length<((Persona)other).getNombre().Length){
				return true;
			}
			return false;
		}
		public bool sosMayor(IComparable self, IComparable other)
		{
			if(((Persona)self).getNombre().Length>((Persona)other).getNombre().Length){
				return true;
			}
			return false;
		}
		public bool sosIgual(IComparable self, IComparable other)
		{
			if(((Persona)self).getNombre().Equals(((Persona)other).getNombre())){
				return true;
			}
			return false;
		}
	}
}
