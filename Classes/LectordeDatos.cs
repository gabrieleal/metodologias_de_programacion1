/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 05/05/2021
 * Hora: 09:02 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.IO;

namespace proyectoMetodologiasProgramacion1.Entity
{
	/// <summary>
	/// Description of LectordeDatos.
	/// </summary>
	public class LectordeDatos
	{
		public LectordeDatos()
		{
		}
		
		public int numeroPorTeclado(){
			try{
				Console.WriteLine("porfavor ingrese un numero: ");				
				string dato=Console.ReadLine();
				return int.Parse(dato);
			}catch(Exception e){
				Console.WriteLine(e.StackTrace);
				return -1;
			}
		}
		
		public string stringPorTeclado(){
			try{
				Console.WriteLine("porfavor ingrese un dato: ");				
				string dato = Console.ReadLine();
				while(dato.Length<1){
					Console.WriteLine("porfavor ingrese un dato VALIDO: ");
					dato = Console.ReadLine();
				}
				return dato;
			}catch(Exception e){
				Console.WriteLine(e.StackTrace);
				return "";
			}
		}
		
		
	}
}
