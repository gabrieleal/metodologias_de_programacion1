/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 05/05/2021
 * Hora: 11:31 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of FabricasCola.
	/// </summary>
	public class FabricasCola: FactoryMethodIColeccionable
	{
		public FabricasCola()
		{
		}
		
		override public IColeccionable fabricaIColeccionable(){
			return new Cola();
		}
	}
}
