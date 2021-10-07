using System;

namespace E02
{
    class Program
    {
        static void imprimir_matriz(double [,] matriz){
            int f,c;
            for (f=0;f<matriz.GetLength(0);f++){
                for (c=0;c<matriz.GetLength(1);c++){
                    Console.Write($"{matriz[f,c],3}");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
                //Para que usuario indique cantidad de filas y columnas de la matriz
            //Console.WriteLine(" Ingresar cantidad de filas: "); int filas=int.Parse(Console.ReadLine());
            //Console.WriteLine(" Ingresar cantidad de columnas: "); int columnas=int.Parse(Console.ReadLine());
            double [,] matriz = new double [2,2];
                //para saber el tamaño de la dim 0
            // Console.WriteLine(matriz.GetLength(0));
                //para saber el tamaño de la dim 1
            // Console.WriteLine(matriz.GetLength(1));
            matriz[0,0]=5;
            matriz[1,0]=0;
            matriz[0,1]=001; //muestra "1" 
            matriz[1,1]=10;
            imprimir_matriz(matriz);
        }
    }
}
