using System;

namespace E20
{
    class Program
    {
        static void Main(string[] args)
        {
            // muestra de 1 a 10, PERO parece que la intencion es mostrar del 2 al 11.
            int i=0;
            for (i=1;i<=10;){
                Console.WriteLine(i++);
            }
            // Codigo para que muestre de 2 a 11 solo cambiando el parametro del writeline
            /* 
            i=0;
            for (i=1;i<=10;){
                Console.WriteLine(i+1);
                i++;
            }
            */            
        }
    }
}
