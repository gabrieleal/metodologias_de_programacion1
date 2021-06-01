/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 05/05/2021
 * Hora: 08:35 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Threading;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of GenerarAleatorio.
	/// </summary>
	public class GenerarDatosAleatorio
	{
		public GenerarDatosAleatorio()
		{
		}
		
		public int numeroAleatorio(int cantidadMaxima){
			Random random = new Random();
			int res = random.Next(0,cantidadMaxima);
			return res;
		}
		
		public String stringAleatorio(int cantidadCaracteres){
			string cadena="";
			Random random = new Random();
			const string abecedario = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
			while(cadena.Length<cantidadCaracteres){
				int num=random.Next(0,100);
				cadena+=abecedario[num%27];
				Thread.Sleep(2);
			}
			return cadena.ToUpperInvariant();
		}
	}
}
