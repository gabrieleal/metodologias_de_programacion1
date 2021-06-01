/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 18/04/2021
 * Hora: 09:51 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace proyectoMetodologiasProgramacion1
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class Numero:IComparable
	{	
		private int valor;
		
		public Numero(int v){
			this.valor=v;
		}
		
		public int getValor(){
			return valor;
		}
		
		#region IComparable implementation
		public bool sosMenor(IComparable c)
		{
			if(((Numero)c).getValor()<this.valor){
				return false;
			}
			return true;
		}
		
		public bool sosIgual(IComparable c)
		{
			if( (((Numero)c).getValor()).Equals(this.valor)){
				return true;
			}
			return false;
		}
		public bool sosMayor(IComparable c)
		{
			if(((Numero)c).getValor()<this.valor){
				return true;
			}
			return false;
		}
		#endregion

		public string toString()
		{
			return string.Format("numero:{0}", this.getValor());
		}
	}
}
