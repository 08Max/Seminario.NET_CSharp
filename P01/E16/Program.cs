using System;

namespace E16
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=12,b=3;
            //if ((b != 0) & (a/b > 5)) Console.WriteLine(a/b);
            //runtime error, no se puede dividir por cero -> solucion:
            if (b != 0) {
                if (a/b > 5) { 
                    Console.WriteLine(a/b);
                }
            } else { Console.WriteLine("Cant divide by zero"); }
        }
    }
}
