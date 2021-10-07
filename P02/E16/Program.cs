/*
16. Escribir una función (método static int Fac(int n)) que calcule el factorial de un
número npasado al programa como parámetro por la línea de comando
a) Definiendo una función no recursiva
b) Definiendo una función recursiva
c) idem a b) pero con expression-bodiedmethods(Tip: utilizar el operador condicional
ternario)

        FUNCIONA. 
*/
using System;

namespace E16
{
    class Program
    {
        // funcion iterativa 
        static int Fac_iterativo(int n){
            
            if (n==1){
                return 1;
            }
            else {
                int resultado=n;
                for (n=n-1;n>0;n--){
                    resultado=resultado*(n);
                }
                return resultado;
            }
        }
        
        // funcion recursiva
        static int Fac_recursivo (int n){
            if (n == 1) {
                return 1; 
            }
            else { 
                return (n*Fac_recursivo(n-1)); }
        }
        
        static int Fac_recursivo2 (int n) => ( (n==1) ? 1 : n * Fac_recursivo2(n-1) ); 
        
        static void Main(string[] args){
            int n;
            if (args.Length!=0) {
                string st = args[0];
                n=int.Parse(st);
                Console.WriteLine(n);
                Console.WriteLine(" iterativo | El factorial de "+n+" es: "+Fac_iterativo(n));
                Console.WriteLine(" recursivo | El factorial de "+n+" es: "+Fac_recursivo(n) );
                // ----> COMPARAR
                Console.WriteLine(" recursivo expression-bodied | El factorial de "+n+" es: "+Fac_recursivo2(n)); 
            }
            else { Console.WriteLine("Sin argumentos"); }
        }
    }
}