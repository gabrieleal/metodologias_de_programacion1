/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 09/05/2021
 * Hora: 07:38 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of FabricaVendedor.
	/// </summary>
	public class FabricaVendedor:FactoryMethodIComparable
	{
		public FabricaVendedor()
		{
		}
		public override IComparable fabricaIComparable(){
			GenerarDatosAleatorio generador = new GenerarDatosAleatorio();
			Random rand = new Random();
			string n = generador.stringAleatorio(rand.Next(2,10));
			int d = generador.numeroAleatorio(rand.Next(10000000,100000000));
			int s = generador.numeroAleatorio(rand.Next(13000,900*1000));
			return new Vendedor(n,d,s);
		}
	}
}
