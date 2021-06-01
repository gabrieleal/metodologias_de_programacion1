/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 06/05/2021
 * Hora: 12:12 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Reflection;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of FabricaConjunto.
	/// </summary>
	public class FabricaConjunto: FactoryMethodIColeccionable
	{
		public FabricaConjunto()
		{
		}
		override public IColeccionable fabricaIColeccionable(){
			return new Conjunto();
		}
	}
}
