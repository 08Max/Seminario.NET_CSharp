using System;

namespace E03
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while (i <= 10){
                sum += i++;
            }
            Console.WriteLine(sum);
        }
        //quitando el ";" de linea 11 funciona correctamente
    }
}
