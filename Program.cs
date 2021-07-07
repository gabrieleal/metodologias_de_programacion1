/*
 * Creado por SharpDevelop.
 * Usuario: Usuario
 * Fecha: 15/04/2021
 * Hora: 08:31 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;
using System.Threading;

using proyectoMetodologiasProgramacion1;
using proyectoMetodologiasProgramacion1.Entity;
using proyectoMetodologiasProgramacion1.Interface;
using proyectoMetodologiasProgramacion1.Classes;
namespace proyectoMetodologiasProgramacion1
{
	class Program
	{
		public static void Main(string[] args)
		{
//			Pila p = new Pila();
//			llenar(p,IComparableDeseado.Vendedor);
//			informar(p);
//
//
//
//			probarStrategy();
//			probarIteradorDicc();
			
//			Ejercicio4_Practica4();
			
			Ejercicio10_Practica5();
			
			
			Console.ReadKey(true);
		}
		
		
		static void Ejercicio10_Practica5(){
			
			Pila pila = new Pila();
			
			Aula aula = new Aula();
			
			pila.setOrdenInicio(new OrdenInicio(aula));
			pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
			pila.setOrdenAulaLlena(new OrdenAulaLLena(aula));
			
			llenar(pila,IComparableDeseado.Alumno);
			llenar(pila,IComparableDeseado.AlumnoMuyEstudioso);
			
		}
		
		
		
		
		static void Ejercicio4_Practica4(){
			Teacher prof = new Teacher();
			GenerarDatosAleatorio datos = new GenerarDatosAleatorio();
			Random rand = new Random();
			try{
				for(int i = 0; i<20; i++){
					if(i<10){
						IAlumno alumno = new ProxyAlumno(datos.stringAleatorio(rand.Next(2,10)),datos.numeroAleatorio(rand.Next(9,11)),datos.numeroAleatorio(rand.Next(4,6)),datos.numeroAleatorio(rand.Next(1,10)),IComparableDeseado.Alumno);
						AdapterStudent student = new AdapterStudent(alumno);
						prof.goToClass(student);
					}else{
						//AdapterStudent student = new AdapterStudent(new AlumnoMuyEstudioso(datos.stringAleatorio(rand.Next(2,10)),datos.numeroAleatorio(rand.Next(9,11)),datos.numeroAleatorio(rand.Next(4,6)),Convert.ToDouble(datos.numeroAleatorio(rand.Next(1,10)))));
						IAlumno alumno = new ProxyAlumno(datos.stringAleatorio(rand.Next(2,10)),datos.numeroAleatorio(rand.Next(9,11)),datos.numeroAleatorio(rand.Next(4,6)),datos.numeroAleatorio(rand.Next(1,10)),IComparableDeseado.AlumnoMuyEstudioso);
						AdapterStudent student = new AdapterStudent(alumno);
						
						prof.goToClass(student);
					}
				}
				
				prof.teachingAClass();
			}catch(Exception e)
			{
				Console.WriteLine(e.Data);
				Console.WriteLine(e.Message+"\n"+e.Source+"\n"+e.StackTrace);
			}
		}
		
		static void ejercicio13_practica3(){
			IColeccionable col = new Cola();
			
			llenar(col,IComparableDeseado.Vendedor);
			
			iterador iter = col.crearIterador();
			
			Gerente gerente = new Gerente("Pedro",4227789);
			
			while(!iter.Fin()){
				((Vendedor)iter.Actual()).agregar(gerente);
				iter.Siguiente();
			}
			
			jornadaDeVentas(col);
			
			gerente.cerrar();
			
		}
		
		static void jornadaDeVentas(IColeccionable c){
			Random rand = new Random();
			iterador iter = c.crearIterador();
			while(!iter.Fin()){
				Vendedor actual = (Vendedor)iter.Actual();
				for( int i = 0; i<20; i++ ){
					actual.venta(rand.Next(1,7000));
				}
				iter.Siguiente();
			}
		}
		
		
		static  void probarIteradorDicc(){
			Pila e = new Pila();
			llenarAlumnos(e);
			
			var d =new Diccionario();
			for(int i = 0;i<15;i++){
				String Valor=String.Format("valor{0}",i);
				d.agregar(new Numero(i*7),Valor);
			}
			try{
				imprimirElementos(e);
//				imprimirElementos(d);
				
			}catch(Exception ex){
				Console.WriteLine(ex.Message);
			}
		}
		
		
		static void imprimirElementos(IColeccionable c){
			try{
				iterador iterador = c.crearIterador();
				while(!iterador.Fin()){
					Thread.Sleep(500);
					var actual = iterador.Actual();
					Console.WriteLine(actual.toString());
					iterador.Siguiente();
				}
			}catch(Exception ex){
				Console.WriteLine(ex.StackTrace);
			}
		}
		
		
		static void probarStrategy()
		{
			try{
				Pila p = new Pila();
				Cola c = new Cola();
				Diccionario dq = new Diccionario();
				ColeccionMultiple multiple = new ColeccionMultiple(p,c);
				llenarAlumnos(c);
				llenarAlumnos(p);
				llenarAlumnos(dq);
//			llenarAlumnos(multiple);
				imprimirElementos(c);
				imprimirElementos(dq);
				IComparable pd = new Alumno("pedro",123456789,1234,7.2,new CompararPorPromedio());
				IComparable d = new Alumno("alberto",987654321,4321,6.5,new CompararPorLegajo());
				Console.WriteLine(((Alumno)pd).sosIgual(d));
				Console.WriteLine(((Alumno)pd).sosMayor(d));
				Console.WriteLine(((Alumno)pd).sosMenor(d));
			}catch(Exception ex){
				Console.WriteLine(ex.StackTrace);
			}
		}
		
		static void llenar (IColeccionable v,IComparableDeseado opcion){
			for(int t = 0; t<20; t++){
				IComparable comp=FactoryMethodIComparable.fabricaIComparable(opcion);
				v.Agregar(comp);
			}
		}
		
		static void informar(IColeccionable v){
			try{
				Console.WriteLine(v.Cuantos());
				Console.WriteLine((v.Minimo().toString()));
				Console.WriteLine((v.Maximo().toString()));
				Console.Write("Ingrese valor buscado en la coleccion: ");
				IComparable n = new Numero((new LectordeDatos()).numeroPorTeclado());
				if(v.Contiene(n)){
					Console.WriteLine("el elemento leido está en la coleccion");
				}else{
					Console.WriteLine("el elemento leido no está en la coleccion");
				}
			}catch (Exception e){
				Console.WriteLine(e.Message);
				
			}
		}
		static string[] nombres={"Pedro","Alberto","Matias","Daniel","Jose","Samuel","David","Dario","Manuel"};
		static void llenarAlumnos (IColeccionable v){
			Random e = new Random();
			for(int t = 0; t<20; t++){
				int leg=(int)e.Next(100000,999999);
				double prom=(double)e.Next(0,10);
				int dni=(int)e.Next(49870,8987456);
				string nom = nombres[(int)e.Next(0,8)];
				v.Agregar(new Alumno(nom,dni,leg,prom,new CompararPorLegajo()));
			}
		}
		
		
		
		
		
	}
}