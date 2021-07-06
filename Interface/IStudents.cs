/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 03/06/2021
 * Hora: 02:59 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Collections.Generic;

namespace proyectoMetodologiasProgramacion1.Interface
{
	/// <summary>
	/// Description of IStudents.
	/// </summary>
	public interface Student
	{
		string getName();
		int yourAnswerIs(int question);
		void setScore(int score);
		string showResult();
		bool equals(Student student);
		bool lessThan(Student student);
		bool greaterThan(Student student);
	}
	
	public interface Collection
	{
		IteratorOfStudent getIterator();
		void addStudent(Student student);
		void sort();
	}
	
	public interface IteratorOfStudent
	{
		void beginning();
		bool end();
		Student current();
		void next();
	}
	
	internal class ListOfStudent : Collection
	{
		private List<Student> list = new List<Student>();
		
		public IteratorOfStudent getIterator()
		{
			return new ListOfStudentIterator(list);
		}
		
		public void addStudent(Student student)
		{
			list.Add(student);
		}
		
		public void sort()
		{
			list.Sort(new StudentComparer());
		}
	}
	
	internal class ListOfStudentIterator : IteratorOfStudent
	{
		private List<Student> list;
		private int index;
		
		public ListOfStudentIterator(List<Student> _list)
		{
			list = _list;
		}
		
		public void beginning()
		{
			index = 0;	
		}
		
		public bool end()
		{
			return index >= list.Count;
		}
		
		public Student current()
		{
			return list[index];
		}
		
		public void next()
		{
			index++;
		}
	}
	
	internal class StudentComparer : IComparer<Student>
	{
		public int Compare(Student s1, Student s2)
		{
			if(s1.equals(s2))
				return 0;
			else
			if(s1.lessThan(s2))
				return 1;
			else
				return -1;
		}
	}
	
}
