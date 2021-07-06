/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 07/05/2021
 * Hora: 11:06 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of Vendedor.
	/// </summary>
	public class Vendedor : Persona, Observable
	{	
		private int sueldoBase,ultimaVenta; 
		private double bonus=1;
		
		private List<Observador> observadores;
		
		public Vendedor(string n, int d, int s):base(n,d)
		{
			this.sueldoBase = s;
			this.observadores=new List<Observador>();
		}
		
		public void venta(int monto){
			Console.WriteLine("venta: "+monto);
			this.ultimaVenta=monto;
			this.notificar();
			
		}
		
		public void aumentaBonus(){
			this.bonus+=0.1;
		}

		public double Bonus {
			get {
				return bonus;
			}
		}

		public int UltimaVenta {
			get {
				return ultimaVenta;
			}
		}
		public int SueldoBase {
			get {
				return sueldoBase;
			}
		}

		
		#region Observable implementation
		public void agregar(Observador v)
		{	
			observadores.Add(v);
		}
		public void notificar()
		{
			foreach(Observador e in observadores){
				e.actualizar(this);
			}
		}
		public void quitar(Observador v)
		{
			observadores.Remove(v);
		}
		#endregion
	}
}
