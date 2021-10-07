using System;

namespace E12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingreasar num: ");
            string st = Console.ReadLine();
            int i,n = int.Parse(st);
            for (i=1;i<=n;i++){
                if (n%i==0){ Console.WriteLine(i+" es divisor.");} 
            }
        }
    }
}
