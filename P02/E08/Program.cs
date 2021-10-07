using System;

namespace E08
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] saludos = new string [args.Length];
            int i;
            //crear un vector de saludos predeterminados para cada argumento
            for (i=0;i<args.Length;i++){
                saludos[i]="Hola "+(args[i]);
            }

            Console.WriteLine(" Saludo con for \n ");
            for (i=0;i<args.Length;i++){
                Console.WriteLine("Saludo para "+args[i]+" : "+saludos[i]);
            }

            Console.WriteLine(" --------------- \n \n Saludo con foreach \n ");
            i=0;
            foreach (string st in saludos) { 
                Console.WriteLine("Saludo para "+args[i]+" : "+st);
                i++;
            }
        }
    }
}
