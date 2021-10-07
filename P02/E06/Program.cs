using System;

namespace E06
{
    class Program
    {
        static void Main(string[] args)
        {
                //al ejecutar de linea de comandos:
            //sin argumentos -> runtime error: indice fuera de rango al invocar "args[0]"       
            Console.WriteLine("Hola[0]",args[0]); // con argumentos -> salida: "Hola[0]"
            Console.WriteLine("Hola[0]"+args[0]); // con argumentos -> salida: "Hola[0]" + primer argumento
        }
    }
}
