/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 30/04/2021
 * Hora: 05:38 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of IDiccionario.
	/// </summary>
	public interface IDiccionario<T>
	{
		List<T> getDiccionario();
	}
}
