using System;

namespace E02
{
    class Program
    {
        static void Main(string[] args) {
            object o1="A";
            object o2 = o1;
            o2 = "Z"; //asignacion de un Char a un Object -> boxing -> 
                      //en heap: "Z"
                      //en pila: referencia nueva que apunta a "Z" (diferente a O1)
            Console.WriteLine(o1 + " " + o2);
        }
    }
}
