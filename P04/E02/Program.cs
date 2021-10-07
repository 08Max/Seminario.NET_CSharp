using System;
using System.IO;
namespace E01
{
    class Program
    {
        class Persona {
                //los campos son private por defecto, es decir puede obviarse el "private" antes de el <tipo>
            private string _nombre; 
            private int _edad;
            private long _DNI;
            public Persona (){ //constructor nulo
            }
            public Persona (string nombre,string edad,string DNI ) {
                this._nombre=nombre;
                this._edad=int.Parse(edad);
                this._DNI=long.Parse(DNI);
            }
            public void Imprimir() {
                Console.WriteLine("Nro) Nombre      Edad    DNI.");
                Console.WriteLine($"{this._nombre,10}{this._edad,10}{this._DNI,10}");
            }
        }
        static void Main(string[] args)
        {
            // Leyendo desde consola
/*
            Console.Write("Ingresar datos: ");
            string cadena = Console.ReadLine();
            string [] palabras = cadena.Split(',');
            Persona p = new Persona(palabras[0],palabras[1],palabras[2]); //aunque sea por parametro se debe hacer la conversion explicita
            p.Imprimir();
*/
            // Leyendo desde archivo con Console.SetIn(new System.IO.StreamReader(nombreDeArchivo));
            try {
                Console.SetIn(new StreamReader("C:\\Users\\ideas\\Documents\\MEGAsync\\Seminario .NET\\Practica\\P04\\E01\\Archivo.txt"));
                string linea;
                Persona p2;
                linea = Console.ReadLine();
                string [] palabrass=linea.Split(',');
                p2 = new Persona(palabrass[0],palabrass[1],palabrass[2]);
                p2.Imprimir();
            }
            catch (Exception e){
                Console.WriteLine(" El archivo no puede leerse");
                Console.WriteLine(e);
            }
            
        }
    }
}
