/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 05/05/2021
 * Hora: 11:31 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
namespace proyectoMetodologiasProgramacion1{
	/// <summary>
	/// Description of FabricaColeccionMultiple.
	/// </summary>
	public class FabricaColeccionMultiple: FactoryMethodIColeccionable
	{
		public FabricaColeccionMultiple()
		{
		}
		override public IColeccionable fabricaIColeccionable(){
			Pila pila = (Pila)FactoryMethodIColeccionable.fabricaIColeccionable(IColeccionableDeseado.Pila);
			Cola Cola = (Cola)FactoryMethodIColeccionable.fabricaIColeccionable(IColeccionableDeseado.Cola);
			return new ColeccionMultiple(pila,Cola);
		}
	}
}
