using System;

namespace E17
{
    class Program
    {
        // funcion iterativa 
        static void i_Fac(int n,out int f){
            int aux=n;
            if (aux==1){
                f=1;
            }
            else {
                int resultado=n;
                aux=resultado;
                for (aux=resultado-1;aux>0;aux--){
                    resultado=resultado*(aux);
                }
                f=resultado;
            }
        }
        
        // funcion recursiva 
        
        static void r_Fac (int n, out int f){
            if (n == 1) {
                f=1; 
            }
            else { 
                int f2;
                r_Fac(n - 1, out f2);
                f = n * f2;                
            }
        }

        static void Main(string[] args)
        {
            int n;
            if (args.Length!=0) {
                string st = args[0];
                n=int.Parse(st);
                Console.WriteLine(n);
                int f; 
                i_Fac(n,out f);
                Console.WriteLine(" iterativo | El factorial de "+n+" es: "+f);
                r_Fac(n, out f);
                Console.WriteLine(" recursivo | El factorial de "+n+" es: "+f );
            }
            else { Console.WriteLine("Sin argumentos");}
        }
    }
}

