using System;

namespace E19
{
    class Program
    {

        static void Imprimir(params object[] vector)
        {
            foreach (object item in vector)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static void Main(String[] args)
        {
        Imprimir(1, "casa", 'A', 3.4, DayOfWeek.Saturday);
        Imprimir(1, 2, "tres");
        Imprimir();
        Imprimir("-------------");
        }
    }
}
