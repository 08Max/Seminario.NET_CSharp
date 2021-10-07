using System;

namespace E05
{
    class Program
    {
        static double [,] crearMatriz(int rows, int cols){
            double [,] matriz = new double [rows,cols];
            int row,col;
            for (row=0;row<rows;row++) {
                for (col=0;col<cols;col++) {
                    matriz[row,col]=row;
                }
            }
            printMatriz(matriz);
            return matriz;
        }
        static void printMatriz(double [,] matriz){
            Console.WriteLine(" Matriz: ");
            int row,col;
            for (row=0;row<matriz.GetLength(0);row++) {
                for (col=0;col<matriz.GetLength(1);col++) {
                    Console.WriteLine(matriz[row,col]);
                }
            }
        }
        static void printArreglo(double [][] arreglo){
            int row,col;
            for (row=0;row<arreglo.GetLength(0);row++){
                for (col=0;col<arreglo[row].GetLength(0);col++) {
                    Console.Write($"{arreglo[row][col],5}");
                }
                Console.WriteLine('\n');
            }            
        }
        static double [][] GetArregloDeArreglo(double [,] matriz){
            double [][] vector = new double [matriz.GetLength(0)][];
            int i;
            for (i=0;i<vector.GetLength(0);i++){
                vector[i]=new double [matriz.GetLength(1)];
            }
            int row,col;
            for (row=0;row<matriz.GetLength(0);row++) {
                for (col=0;col<matriz.GetLength(1);col++) {
                    vector[row][col]=matriz[row,col];
                }
            }
            printArreglo(vector);
            return vector;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("- Ingresar dimensiones de la matriz - ");
            Console.WriteLine("... Filas: "); int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("... Columnas: "); int cols = int.Parse(Console.ReadLine());
            double [][] arreglo = GetArregloDeArreglo(crearMatriz(rows,cols));
            Console.WriteLine("Arreglo de arreglos: \n");
            printArreglo(arreglo);
        }
    }
}
