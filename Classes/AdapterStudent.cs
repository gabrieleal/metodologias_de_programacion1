/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 08/06/2021
 * Hora: 12:30 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of AdapterStudent.
	/// </summary>
	public class AdapterStudent : Student
	{
		Alumno Alumno;
		
		public AdapterStudent(Alumno a)
		{
			this.Alumno = a;
		}
		
		
		#region Student implementation
		public string getName()
		{
			return this.Alumno.toString();
		}
		public int yourAnswerIs(int question)
		{
			return this.Alumno.responderPregunta(question);
		}
		public void setScore(int score)
		{
			this.Alumno.Calificacion(score);
		}
		public string showResult()
		{
			return this.Alumno.mostrarCalificacion();
		}
		public bool equals(Student student)
		{
			return this.Alumno.sosIgual(((AdapterStudent)student).getAlumno());
		
		}
		public bool lessThan(Student student)
		{
			return this.Alumno.sosMenor(((AdapterStudent)student).getAlumno());
			
		}
		public bool greaterThan(Student student)
		{
			return this.Alumno.sosMayor(((AdapterStudent)student).getAlumno());
			
		}
		#endregion
		
		public Alumno getAlumno(){
			return this.Alumno;
		}
	}
}
