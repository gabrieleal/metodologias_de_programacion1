/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 09/05/2021
 * Hora: 08:52 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of Gerente.
	/// </summary>
	public class Gerente: Persona, Observador
	{	
		IColeccionable mejores;
		
		public Gerente(string n, int d):base(n, d)
		{
			mejores=new Pila();
		}
		
		public void cerrar(){
			iterador iter = mejores.crearIterador();
			while(!iter.Fin()){
				Vendedor actual = (Vendedor)iter.Actual();
				Console.WriteLine(String.Format("el empleado {0} con un bonus acumulado de {1} ",actual.getNombre(),actual.Bonus));
				iter.Siguiente();
			}
		}
		
		public void venta(double monto, Vendedor vendedor){
			if(monto>5000){
				if(!mejores.Contiene(vendedor)){
					this.mejores.Agregar(vendedor);
				}
				vendedor.aumentaBonus();
			}
		}

		
		#region Observador implementation
		public void actualizar(Observable o)
		{	
			this.venta(((Vendedor)o).UltimaVenta,((Vendedor)o));
		}
		#endregion
	}
}
