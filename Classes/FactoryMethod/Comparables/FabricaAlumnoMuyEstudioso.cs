/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 06/07/2021
 * Hora: 12:29 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1.Classes.FactoryMethod.Comparables
{
	/// <summary>
	/// Description of FabricaAlumnoMuyEstudioso.
	/// </summary>
	public class FabricaAlumnoMuyEstudioso:FactoryMethodIComparable
	{
		public FabricaAlumnoMuyEstudioso()
		{
		}
		
		override public IComparable fabricaIComparable(){
			GenerarDatosAleatorio generador = new GenerarDatosAleatorio();
			Random rand = new Random();
			string nombre = generador.stringAleatorio(rand.Next(3,15));
			int dni =generador.numeroAleatorio(rand.Next(10000000,Convert.ToInt32(Math.Pow(10,9))));
			int legajo =generador.numeroAleatorio(rand.Next(4,8));
			double promedio =Convert.ToDouble(generador.numeroAleatorio(rand.Next(1,10)));
			return new AlumnoMuyEstudioso(nombre,dni,legajo,promedio);
		}
		
	}
}
