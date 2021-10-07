using System;

namespace E11
{
    class Program
    {
        static void Main(string[] args)
        {
            // es el ejercicio 10
            int i,repeticiones1,repeticiones2;
            repeticiones1 = 1000/17; repeticiones2=1000/29;
            Console.WriteLine(" ...Multiplos de 17... menores a 1000");
            for (i=1;i<=repeticiones1;i++) {
                Console.WriteLine("17*"+i+" = "+17*i);
            }
            Console.WriteLine("...");
            Console.WriteLine(" ...Multiplos de 29... menores a 1000");
            for (i=1;i<=repeticiones2;i++) {
                Console.WriteLine("29*"+i+" = "+29*i);
            }
            Console.WriteLine("...");
        }             
    }
}
