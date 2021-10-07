using System;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" INGRESE NOMBRE: ");
            string nombre = Console.ReadLine();
            if (nombre.Equals("") ){
                Console.WriteLine("Hello world");
            } else {
            Console.WriteLine(" Hello "+nombre);
            }
        }
    }
}