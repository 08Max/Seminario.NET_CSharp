/* 
Idem al anterior pero ahora con un parámetro más que representa la plantilla de formato que
debe aplicarse a los números al imprimirse. La plantilla de formato es un string de acuerdo a las
convenciones de formato compuesto, por ejemplo “0.0” implica escribir los valores reales con
un dígito para la parte decimal. Observar que no hay inconveniente para implementar dos
métodos con el mismo nombre siempre que NO lleven la misma cantidad de parámetros con los
mismos tipos y en el mismo orden (sobrecarga de métodos).
*/
using System;

namespace E03
{
    class Program
    {
        static void imprimir_matriz(double [,] matriz,string formato){
            //2 formas de hacerlo
            //con variable_numerica.ToString(variable_de_formato);
            int f,c;
            //string cadena;
            for (f=0;f<matriz.GetLength(0);f++){
                for (c=0;c<matriz.GetLength(1);c++){
                    //#1: con variable_numerica.ToString(variable_de_formato);
                    Console.WriteLine(matriz[f,c].ToString(formato)+" ");
                    //#2: con String.Format()   --> no funciona. solucionar, consultar.
                        //Console.WriteLine(String.Format("{0:1}",matriz[f,c],formato));  
                }
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
            matriz[0,0]=5.5;
            matriz[1,0]=0;
            matriz[0,1]=001.3; //muestra "1" 
            matriz[1,1]=10.6;
            string formato = "00.00";
            imprimir_matriz(matriz,formato);
        }
    }
}
