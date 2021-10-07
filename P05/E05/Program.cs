using System;

namespace E05
{
    class A
    {
        char c;
        static string st;
        void metodo1()
        {
            st = "string";
            c = 'A';
        }
        static void metodo2()
        {
            new ClaseA().c = 'a';
            st = "st2";
            c = 'B';
            new A().st = "otro string";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
