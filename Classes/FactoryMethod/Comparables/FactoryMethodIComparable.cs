/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 05/05/2021
 * Hora: 09:30 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
namespace proyectoMetodologiasProgramacion1
{	public enum IComparableDeseado{Numero, Alumno, Vendedor};
	public abstract class FactoryMethodIComparable
	{	
		public static IComparable fabricaIComparable(IComparableDeseado deseado){
			FactoryMethodIComparable variable=null;
			if(deseado.Equals(IComparableDeseado.Alumno)){
				variable= new FabricaAlumno();
			}
			if(deseado.Equals(IComparableDeseado.Numero)){
				variable= new FabricaNumeros();
			}
			if(deseado.Equals(IComparableDeseado.Vendedor)){
				variable= new FabricaVendedor();
			}
			return variable.fabricaIComparable();
		}
		
		public abstract IComparable fabricaIComparable();
	
	}
}
