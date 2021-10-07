using System;
using System.IO;
namespace E01
{
    class Program
    {
        class Persona {
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
            public bool EsMayorQue( Persona p){ return (this._edad>p._edad); }
        }
        static void Main(string[] args)
        {
            Console.SetIn(new StreamReader("C:\\Users\\ideas\\Documents\\MEGAsync\\Seminario .NET\\Practica\\P04\\E01\\Archivo.txt"));
            string linea;
            Persona Pmayor = new Persona("X","0","11111111");
            while ((linea = Console.ReadLine() ) != null) { //se ejecuta tantas veces como lineas de texto hay
                string [] palabrass=linea.Split(',');
                Persona p2 = new Persona(palabrass[0],palabrass[1],palabrass[2]);
                if (p2.EsMayorQue(Pmayor)) { Pmayor=p2; }
            }
            Pmayor.Imprimir();
        }
    }
}
