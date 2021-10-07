using System;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux,cadena;
            // con if            
            Console.WriteLine("________ con estructura IF");
            Console.Write("Ingrese nombre: "); aux = System.Console.ReadLine();
            if (aux.Equals("Juan")){ System.Console.WriteLine("Hola amigo"); 
            } 
            else { 
                if(aux.Equals("Maria")) { System.Console.WriteLine("Buen dia vieja");}
                else {
                    if (aux.Equals("Alberto")) { System.Console.WriteLine();}
                    else { 
                        if(aux.Equals("")) {System.Console.WriteLine("Buen dia mundo!");}
                        else { System.Console.WriteLine("Buen dia "+aux);}
                    }
                }
            }

            //con switch
            Console.WriteLine(" _______ para probar SWITCH"); 
            Console.Write("Ingrese nombre: "); aux = Console.ReadLine();
            switch (aux) {
                case "Juan" :
                Console.WriteLine("Hola amigo!");
                break;
                case "Maria":
                Console.WriteLine("Buen día señora");
                break;
                case "Alberto" :
                Console.WriteLine("Hola Alberto");
                break;
                default:
                Console.WriteLine("Buen día mundo");
                break;
            }
        }
    }
}