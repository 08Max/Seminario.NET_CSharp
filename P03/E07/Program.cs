using System;

namespace E07
{
    class Program
    {
        static void Main(string[] args)
        {
        int i = 10;
        var x = i * 1.0;
        var y = 1f;
        var z = i * y;
        Console.WriteLine(x.GetType()); 
        // x es tipo double 
        Console.WriteLine(z.GetType());
        // z ahora es de tipo float single precision
        }
    }
}
