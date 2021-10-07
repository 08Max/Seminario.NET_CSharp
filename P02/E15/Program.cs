using System;

namespace E15
{
    class Program
    {
        static int fib(int n){ //------------> REVISAR: pedir y comparar
            if (n==0) {return 0; }
            else { 
                if (n<=2) { return 1; }
                else { return (fib(n-1) + fib(n-2) ) ; }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el termino de la suc. de Fibonacci que desea saber (diferente a 0): ");
            string numero=Console.ReadLine();
            int n=int.Parse(numero);
            Console.WriteLine("fibonacci de "+n+" es: "+fib(n) );
        }
    }
}
