using System;

namespace E10
{
    class A{
    public void Metodo(short n)
        {
        Console.Write("short {0} - ", n);
        }
    public void Metodo(int n)
        {
        Console.Write("int {0} - ", n);
        }
    /*
    public int Metodo(int n)  // ya existe metodo con = nombre, = tipo de parametro, imposible distinguir para el compilador
        {
        return n + 10;
        }
    */    
    }
    class Program {
        static void Main(string[] args)
        {
            A a = new A();
            a.Metodo(15);
            a.Metodo((short)35); // si no casteo reconoce el Metodo que tiene argumento int 
        }
    }
}
