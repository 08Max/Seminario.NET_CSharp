using System;

namespace E04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args==null); //imprime "False"
            Console.WriteLine(args.Length); // imprime "0" cero.
            //si no se pasan argumentos al ejecutar este programa por consola eso es lo que se muestra
        }
    }
}
