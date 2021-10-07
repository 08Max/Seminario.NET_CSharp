/* 
Implementar un programa que muestre todos los números primos entre 1 y un número natural
dado (pasado al programa como argumento por la línea de comandos). Definir el método
static bool esPrimo(int n) que devuelve true sólo si 'n' es primo. Esta función debe
comprobar si 'n' es divisible por algún número entero entre 2 y la raíz cuadrada de n. (Nota:
Math.sqrt(d) devuelve la raíz cuadrada de d)
*/
using System;
namespace E14
{
    class Program
    {

        static bool esPrimo(int n){ 
            double raizcuadrada= Math.Sqrt(n);
            bool continuar=true;
            int i=2;
            while ( (i<=raizcuadrada)&(continuar)) {
                continuar=!(n%i==0);
                i++;
            }
            return continuar;
        }
        static void mostrarPrimos(int n){
            for (int i=2;i<=n;i++){
                if (esPrimo(i)) { Console.WriteLine(i);}
            }
        }        
        static void Main(string[] args)
        {
            if (args.Length!=0) {
                int n=int.Parse(args[0]);
                // imprimir numeros primos entre 1 y num_ingresado (incluido)
                Console.WriteLine("Numeros primos entre 1 y el numero ingresado: ");
                mostrarPrimos(n);
                // el num_ingresado es primo?
                Console.WriteLine(n+" es primo? : "+esPrimo(n) );
            }
            else {
                Console.WriteLine("Programa sin argumentos");
            }         
        }
    }
}
