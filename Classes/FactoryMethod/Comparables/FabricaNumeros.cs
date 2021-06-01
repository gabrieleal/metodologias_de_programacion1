/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 05/05/2021
 * Hora: 10:29 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using proyectoMetodologiasProgramacion1;
using proyectoMetodologiasProgramacion1.Entity;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of FabricaNumeros.
	/// </summary>
	public class FabricaNumeros : FactoryMethodIComparable
	{
		public FabricaNumeros()
		{
		}
		
		override public IComparable fabricaIComparable(){
			GenerarDatosAleatorio generador = new GenerarDatosAleatorio();
			Random rand = new Random();
			return new Numero(rand.Next(1,15));
		}
//		override public IComparable fabricaIComparable(IComparableDeseado deseo){
//			LectordeDatos lector = new LectordeDatos();
//			int numero=lector.numeroPorTeclado();
//			return new Numero(numero);
//		}
	}
}
