﻿using System;
using System.Text;
class Program
{
    private static void Main(string[] args)
    {
        object[] v = new object[10];
        v[0] = new StringBuilder("Net");
        for (int i = 1; i < 10; i++)
        {
            v[i] = v[i - 1];
        }
        foreach (StringBuilder s in v)
            Console.WriteLine(s);
        (v[5] as StringBuilder).Insert(0, "Framework .");
        foreach (StringBuilder s in v)
            Console.WriteLine(s);
        //dibujar el estado de la pila y la mem. heap 
        //en este punto de la ejecución
        // /*
        v[5] = new StringBuilder("CSharp");
        foreach (StringBuilder s in v)
            Console.WriteLine(s);
        // */
        //dibujar el estado de la pila y la mem. heap 
        //en este punto de la ejecución
    }
}