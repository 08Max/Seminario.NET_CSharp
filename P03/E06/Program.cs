using System;

namespace E06
{
    class Program
    {
        static double [,] Suma(double [,] A,double [,] B) {
            if (A.GetLength(0)!=B.GetLength(1) ) { return null; }
            else { //sumar
                double [,] aux = new double [A.GetLength(0),A.GetLength(1)];
                for (int row=0;row<A.GetLength(0);row++) {
                    for (int col=0;col<A.GetLength(1);col++) {
                        aux[row,col]=A[row,col]+B[row,col];
                    }
                }
                return aux;
            }
        }
        static double [,] Resta(double [,] A, double [,] B) {
            if (A.GetLength(0)!=B.GetLength(1) ) { return null; }
            else { //restar
                double [,] aux = new double [A.GetLength(0),A.GetLength(1)];
                for (int row=0;row<A.GetLength(0);row++) {
                    for (int col=0;col<A.GetLength(1);col++) {
                        aux[row,col]=A[row,col]-B[row,col]; //matriz A - matriz B
                    }
                }
                return aux;
            }    
        }
        static double [,] Multiplicacion (double [,] A, double [,] B) {
            // /*
            if (A.GetLength(1)!=B.GetLength(0)) {
                throw new ArgumentException("matriz invalida");
            }
            else { //multiplicar matrices
                double [,] aux = new double [A.GetLength(0),B.GetLength(1)];
                for (int i=0;i<A.GetLength(0);i++) {
                    for (int j=0;j<B.GetLength(1);j++) {
                        double total=0;
                        for (int k=0; k < A.GetLength(1); k++)
                        {
                            total+=A[i,k]*B[k,j];
                        }
                        aux[i,j]=total;
                    }
                }
                return aux;
            }
            // /*
        }        
        static void imprimir (double [,] A){
            for (int row=0;row<A.GetLength(0);row++) {
                for (int col=0;col<A.GetLength(1);col++) {
                    Console.Write($"{A[row,col],1} ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            double [,] A = new double [3,3] {
                {2,0,1},
                {3,0,0},
                {5,1,1}
            };
            double [,] B = new double [3,3] {
                {1,0,1},
                {1,2,1},
                {1,1,0}
            };
            Console.WriteLine(" MATRIZ A: ");
            imprimir(A);
            Console.WriteLine(" MATRIZ B: ");
            imprimir(B);
            Console.WriteLine(" SUMA (A+B) ");
            imprimir(Suma(A,B));
            Console.WriteLine(" MULTIPLICAR (A+B) ");
            imprimir(Multiplicacion(A,B));
        }
    }
}