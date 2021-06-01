/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 05/05/2021
 * Hora: 11:40 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of FactoryMethodIColeccionable.
	/// </summary>
	public enum IColeccionableDeseado{Pila,Cola,Diccionario,ColeccionMultiple,Conjunto};
	public abstract  class FactoryMethodIColeccionable
	{
		public static IColeccionable fabricaIColeccionable(IColeccionableDeseado deseado){
			FactoryMethodIColeccionable variable=null;
			if(deseado.Equals(IColeccionableDeseado.ColeccionMultiple)){
				variable= new FabricaColeccionMultiple();
			}
			if(deseado.Equals(IColeccionableDeseado.Cola)){
				variable= new FabricasCola();
			}
			
			if(deseado.Equals(IColeccionableDeseado.Diccionario)){
				variable= new FabricaDiccionario();
			}
			
			if(deseado.Equals(IColeccionableDeseado.Pila)){
				variable= new FabricaPila();
			}
			
			if(deseado.Equals(IColeccionableDeseado.Conjunto)){
				variable= new FabricaConjunto();
			}
			return variable.fabricaIColeccionable();
		}
		
		public abstract IColeccionable fabricaIColeccionable();
	}
}
