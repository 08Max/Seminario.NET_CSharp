using System;
using System.IO;
namespace E01
{
    class Program
    {
        class Persona {
            public string nombre;
            public int edad;
            public long DNI;
            
        }
        static void Main(string[] args)
        {
            // Leyendo desde consola
            Console.Write("Ingresar datos: ");
            string cadena = Console.ReadLine();
            string [] palabras = cadena.Split(',');
            Persona p = new Persona();
            p.nombre=palabras[0];
            p.DNI=long.Parse(palabras[1]);
            p.edad=int.Parse(palabras[2]);
            Console.WriteLine("Nro) Nombre      Edad    DNI.");
            Console.WriteLine($"{p.nombre,10}{p.edad,10}{p.DNI,10}");
            
            // Leyendo desde archivo con Console.SetIn(new System.IO.StreamReader(nombreDeArchivo));
            try {
                Console.SetIn(new StreamReader("C:\\Users\\ideas\\Documents\\MEGAsync\\Seminario .NET\\Practica\\P04\\E01\\Archivo.txt"));
                string linea;
                while ((linea = Console.ReadLine() ) != null) { //se ejecuta tantas veces como lineas de texto hay
                    string [] palabrass=linea.Split(',');
                    p2.nombre=palabrass[0];
                    p2.edad=int.Parse(palabrass[1]);
                    p2.DNI=long.Parse(palabrass[2]);
                }
                Console.WriteLine("Nro) Nombre      Edad    DNI.");
                Console.WriteLine($"{p2.nombre,10}{p2.edad,10}{p2.DNI,10}");
            }
            catch (Exception e){
                Console.WriteLine(" El archivo no puede leerse");
                Console.WriteLine(e);
            }
        }
    }
}
