using System;

namespace E09
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = new int[10];
            dynamic dyn = 13;
            Console.WriteLine(obj.Length); //"object" no contiene una definición para "Length" ni un método de extensión accesible "Length" que acepte un primer argumento del tipo "object"
            Console.WriteLine(dyn.Length);
        }
    }
}
