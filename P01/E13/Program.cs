using System;

namespace E13
{
    class Program
    {
        static void Main(string[] args)
        {
            string st1,st2; double n1,n2,suma;
            Console.Write(" Ingrese numero 1: "); n1 = double.Parse(st1 = Console.ReadLine());  
            Console.Write(" Ingrese numero 2: "); n2 = double.Parse(st2 = Console.ReadLine());
            suma=n1+n2;
            Console.WriteLine(n1+"+"+n2+"="+suma);
        }
    }
}
