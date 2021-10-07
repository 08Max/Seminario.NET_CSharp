using System;

namespace E06
{
    class Program
    {
        static void Main(string[] args)
        {
            string st, cadena;
            Console.WriteLine(" - Ingrese una cadena de caracteres - Finaliza cuando no ingresa ningun caracter");
            st = (cadena=Console.ReadLine());
            while (!st.Equals("")){
                Console.WriteLine(" Cantidad de caracteres: "+st.Length);
                Console.WriteLine(" - Ingrese una cadena de caracteres -");
                st = (cadena=Console.ReadLine());
            }
            Console.WriteLine(" - fin -");
        }
    }
}
