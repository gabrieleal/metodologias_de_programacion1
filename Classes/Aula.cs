/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 06/07/2021
 * Hora: 12:56 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1.Classes
{
	/// <summary>
	/// Description of Aula.
	/// </summary>
	public class Aula
	{	
		Teacher t;
		
		public Aula()
		{
		}
		
		public void comenzar(){
			Console.WriteLine("Cominzan las clases");
			this.t=new Teacher();
		}
		
		public void nuevoAlumno(IAlumno a){
			Student newStudent = new AdapterStudent(a);
			t.goToClass(newStudent);
		}
		
		public void claseLista(){
			t.teachingAClass();
		}
	}
}
