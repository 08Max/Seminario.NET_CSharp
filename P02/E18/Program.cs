using System;

namespace E18
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(" Ingrese numero A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ingrese numero B: ");
            int b = int.Parse(Console.ReadLine());
            Swap(ref a,ref b);
            Console.WriteLine("Numero A: "+a);
            Console.WriteLine("Numero B: "+b);
        }
    }
}
