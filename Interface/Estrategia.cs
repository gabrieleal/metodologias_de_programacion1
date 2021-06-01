/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 28/04/2021
 * Hora: 10:03 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of Estrategia.
	/// </summary>
	public interface Estrategia
	{
		bool sosMenor(IComparable self, IComparable other);
		bool sosMayor(IComparable self, IComparable other);
		bool sosIgual(IComparable self, IComparable other);
	}
}
