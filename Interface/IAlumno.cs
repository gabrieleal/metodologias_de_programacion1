/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 06/07/2021
 * Hora: 12:10 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using proyectoMetodologiasProgramacion1;
namespace proyectoMetodologiasProgramacion1.Interface
{
	/// <summary>
	/// Description of IAlumno.
	/// </summary>
	public interface IAlumno:IComparable,ICalificacionDecorator
	{
		int getLegajo();
		double getPromedio();
		Estrategia getCompara();
		void setCompara(estrategia nuevaEstrategia);
		int responderPregunta(int pregunta);
		double Calificacion();
		void Calificacion(double value);
		
		
	}
}
