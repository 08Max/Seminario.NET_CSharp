using System;

namespace E05
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] vector = new int[0];
            Console.WriteLine(vector); // porque muestra "System.Int32[]" y no el valor de var "vector"
            //Console.WriteLine(vector[0]); // runtime error, indice fuera de rango (vector dimension=0)
            Console.WriteLine(vector.Length); //salida: 0
            Console.WriteLine(vector==null); // salida: false
        }
    }
}
