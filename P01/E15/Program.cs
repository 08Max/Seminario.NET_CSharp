using System;

namespace E15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese numero: ");
            string texto = Console.ReadLine();
            int n=int.Parse(texto);
            if ( ( (n%4==0) & (!(n%100==0) ) ) | (n%400==0) ) { 
                Console.WriteLine("Es bisiesto");
            } else {Console.WriteLine("No es bisiesto");}
        }
    }
}
