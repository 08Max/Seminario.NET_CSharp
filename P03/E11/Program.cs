using System;
using System.Collections;
namespace E11
{
    class Program
    {
        static void Main(string[] args)
        {
        ArrayList a = new ArrayList() {1,2,3,4}; 
        // (si no se usa System.Collections) El nombre del tipo o del espacio de nombres 'ArrayList' no se encontró 
        a.Remove(5);
        a.RemoveAt(5);
        
        }
    }
}
