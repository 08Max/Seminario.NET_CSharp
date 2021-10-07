using System;
using System.Text;

namespace E09
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------- con clase string 
            // Inicia el contador:
            DateTime atiempo1 = DateTime.Now;

            string cadena=""; 
            int i;
            for(i=0;i<1000;i++){
                cadena=cadena+i;
            }
            // detiene el contador de tiempo e imprime el resultado:
            DateTime atiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(atiempo2.Ticks - atiempo1.Ticks);
            Console.Write( "TIEMPO: " + total.ToString() +"\n");
            Console.WriteLine(cadena+"\n");

            // ----------------------------------- con clase StringBuilder
            // Inicia el contador:
            DateTime btiempo1 = DateTime.Now;
            StringBuilder cadena2 = new StringBuilder();
            int j;
            for (j=0;j<1000;j++){
                cadena2.Append(j);
            }
            // detiene el contador de tiempo e imprime el resultado:
            DateTime btiempo2 = DateTime.Now;
            TimeSpan total2 = new TimeSpan(btiempo2.Ticks - btiempo1.Ticks);
            Console.Write( " ---------> TIEMPO: " + total2.ToString() +"\n");
            Console.WriteLine(cadena2);
        }
    }
}
