using System;

namespace E09
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena,aux; 
            Console.Write("Ingrese palabra 1, espacio en blanco y palabra2: "); 
            cadena = (aux=Console.ReadLine());
            //metodo 1 -> funciona
            /*
                se lee la cadena de caracteres, se la procesa directamente comparando caracter a caracter
                y comprobando su simetria 
            */
            bool simetrica=true;
            if (cadena.Length%2==1) {
                int i1=0,blanco=cadena.IndexOf(" "),i2=1;
                Console.WriteLine(i1);
                Console.WriteLine(cadena.Length);
                Console.WriteLine(cadena.Length-i2);
                while ( (i1<blanco) && (cadena[i1]==cadena[cadena.Length-i2] ) ) {
                    Console.WriteLine(i1);
                    Console.WriteLine(i2);
                    i1++; i2++;
                }
                if (i1<blanco) { simetrica=false;}
            } else { simetrica=false;}
            Console.WriteLine("¿Simetricas?"+simetrica);
           
        }
    }
}