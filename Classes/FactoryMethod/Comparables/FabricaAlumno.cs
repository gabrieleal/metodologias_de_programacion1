/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 05/05/2021
 * Hora: 10:34 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using proyectoMetodologiasProgramacion1.Entity;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of FabricaAlumno.
	/// </summary>
	public class FabricaAlumno : FactoryMethodIComparable
	{
		public FabricaAlumno()
		{
		}
		
		override public IComparable fabricaIComparable(){
			GenerarDatosAleatorio generador = new GenerarDatosAleatorio();
			Random rand = new Random();
			string nombre = generador.stringAleatorio(rand.Next(3,15));
			int dni =generador.numeroAleatorio(rand.Next(10000000,Convert.ToInt32(Math.Pow(10,9))));
			int legajo =generador.numeroAleatorio(rand.Next(4,8));
			double promedio =Convert.ToDouble(generador.numeroAleatorio(rand.Next(1,10)));
			return new Alumno(nombre,dni,legajo,promedio,new CompararPorDni());
		}
//		override public IComparable fabricaIComparable(IComparableDeseado deseado){
//			LectordeDatos lector = new LectordeDatos();
//			string nombre = lector.stringPorTeclado();
//			int dni =lector.numeroPorTeclado();
//			int legajo = lector.numeroPorTeclado();
//			double promedio =Convert.ToDouble(lector.numeroPorTeclado());
//			return new Alumno(nombre,dni,legajo,promedio);
//		}
	}
}
