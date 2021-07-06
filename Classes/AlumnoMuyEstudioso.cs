/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 03/06/2021
 * Hora: 02:28 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of AlumnoMuyEstudioso.
	/// </summary>
	public class AlumnoMuyEstudioso : Alumno,IAlumno
	{
		public AlumnoMuyEstudioso(string nombre, int dni, int legajo,double prom) :base(nombre,dni,legajo,prom,new CompararPorDni())
		{
		}
		
		public override int responderPregunta(int pregunta){
			return pregunta%3;
		} 
	}
}
