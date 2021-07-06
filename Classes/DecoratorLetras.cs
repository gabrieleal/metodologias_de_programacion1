/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 23/06/2021
 * Hora: 12:53 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using proyectoMetodologiasProgramacion1.Interface;

namespace proyectoMetodologiasProgramacion1.Classes
{
	/// <summary>
	/// Description of DecoratorLetras.
	/// </summary>
	public class DecoratorLetras : DecoratorAbstract
	{
		
		
		public DecoratorLetras(ICalificacionDecorator _core)
		{
			setCore(_core);
		}
		
		#region ICalificacionDecorator implementation

		public override string mostrarCalificacion()
		{
			String var =this.getCore().mostrarCalificacion();
			int nota =(int)this.getCore().mostrarNota();
			
			if (nota<2 && nota >= 1){ var += " (uno)";}
			if(nota<3 && nota >= 2){ var += " (dos)";}
			if( nota<4 && nota >= 3){ var+= " (tres)";}
			if( nota<5 && nota >= 4) {var += " (cuatro)";}
			if( nota<6 && nota >= 5) {var += " (cinco)";}
			if( nota<7 && nota >= 6) {var += " (seis)";}
			if( nota<8 && nota >= 7) {var += " (siete)";}
			if( nota<9 && nota >= 8) {var += " (ocho)";}
			if( nota<10 && nota >= 9){ var += " (nueve)";}
			if( nota.Equals(10)){ var+= " (Diez)";}
			
			return var;
			
		}

		#endregion

		public int mostrarLegajo()
		{
			return this.getCore().mostrarLegajo();
		}
		
	}
}
