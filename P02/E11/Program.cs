using System;

namespace E11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase: ");
            string frase = Console.ReadLine();
            string[] fraseDividida = frase.Split(" ");
            foreach (var palabra in fraseDividida) {Console.WriteLine(palabra);}
        }
    }
}
