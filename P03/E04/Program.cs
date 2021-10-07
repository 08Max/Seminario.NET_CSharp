/*
    4. Implementar los métodos GetDiagonalPrincipal y GetDiagonalSecundaria que
    devuelven un vector con la diagonal correspondiente de la matriz pasada como parámetro. Si la
    matriz no es cuadrada generar una excepción ArgumentException con un mensaje
    explicativo.
    static double[] GetDiagonalPrincipal(double[,] matriz)
    static double[] GetDiagonalSecundaria(double[,] matriz)
*/
using System;
using System.Collections;
namespace E04
{

    class Program
    {
        static double [,] crearMatriz(int rows, int cols){
            double [,] matriz = new double [rows,cols];
            int x=0;
            for (int i=0;i<rows;i++) {
                for (int c=0;c<cols;c++) {
                    matriz[i,c]=x++;
                }
            }
            return matriz;
        }
        static void checkMatriz(double [,] matriz){
            if (matriz.GetLength(0)!=matriz.GetLength(1) ){
                throw new ArgumentException("La matriz no es cuadrada");
            }
        }
        static double[] GetDiagonalPrincipal(double[,]matriz) {
            double [] diago = new double [matriz.GetLength(0)];
            for (int x=0;x<matriz.GetLength(0);x++) {
                diago[x]=matriz[x,x];
            }
            return diago;
        }
        static double[] GetDiagonalSecundaria(double[,]matriz) {
            double [] diago = new double [matriz.GetLength(0)];
            int col=0;
            for (int row=(matriz.GetLength(0))-1;row>=0;row--) {
                diago[col]=matriz[row,col];
                col++;
            }
            return diago;
        }
        static void printMatriz(double [,] matriz){
            for (int row=0;row<matriz.GetLength(0);row++) {
                for (int col=0;col<matriz.GetLength(1);col++) {
                    Console.Write(matriz[row,col]+" ");
                }
                Console.WriteLine('\n');
            }
        }  
        static void printDiagonales(double [,]matriz){
            double [] diago = GetDiagonalPrincipal(matriz);
            Console.Write("Diagonal principal: ");
            for (int i=0;i<diago.GetLength(0);i++){
                Console.Write($"{diago[i],5}");
            }
            Console.WriteLine("");
            diago = GetDiagonalSecundaria(matriz);
            Console.Write("Diagonal secundaria: ");
            for (int i=0;i<diago.GetLength(0);i++){
                Console.Write($"{diago[i],5}");
            } 
        }
        
        static void Main(string[] args)
        {   
            Console.WriteLine("- Ingresar dimensiones de la matriz - ");
            Console.WriteLine("... Filas: "); int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("... Columnas: "); int cols = int.Parse(Console.ReadLine());
            try {
                double [,] matriz = crearMatriz(rows,cols);
                checkMatriz(matriz);
                printMatriz(matriz);
                printDiagonales(matriz);
            }
            catch (ArgumentException e){
                Console.WriteLine(e);
            }
        }
    }
}