using System;

namespace E11
{
    class Program
    {
        static void Main()  {
            object o = 5;
            Procesar(o, o);
            Procesar((dynamic)o, o);
            Procesar((dynamic)o, (dynamic)o);
            Procesar(o, (dynamic)o);
            Procesar(5, 5);
        }
        static void Procesar(int i, object o)  {
            Console.WriteLine($"entero: {i}   objeto:{o}");
        }
        static void Procesar(dynamic d1, dynamic d2) {
            Console.WriteLine($"dynamic d1: {d1}   dynamic d2:{d2}");
        }

        /*
        SALIDA POR CONSOLA
            dynamic d1: 5   dynamic d2:5
            entero: 5   objeto:5
            entero: 5   objeto:5
            dynamic d1: 5   dynamic d2:5
            entero: 5   objeto:5    
        */
    }
}
