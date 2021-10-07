using System;

namespace E13
{
    class Program
    {
        enum Meses {
            Enero,Febrero,Marzo,Abril,Mayo,Junio,Julio,Agosto,Septiembre,Octubre,Noviembre,Diciembre
        }
        static void Main(string[] args)
        {  
            //Meses m = Meses.Enero;
            // String mes = "Enero";
            //Console.WriteLine(mes==m.ToString()); //forma correcta de comparar un campo de un enumerativo con un string
            // /*
            for (Meses m=Meses.Diciembre;m>=Meses.Enero;m--) {
                Console.WriteLine(m);
            }
            Console.WriteLine("Ingrese un mes: "); String mes = Console.ReadLine();
            bool flag=false;
            for (Meses m =Meses.Enero;((m<=Meses.Diciembre)&(!flag));m++) { 
                flag=mes==m.ToString();  //ver linea 14
            }
            Console.WriteLine("¿Mes valido? : "+flag);
            // /*
        }
    }
}

