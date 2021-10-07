using System;

namespace E08
{
    class Program
    {
        static void Main(string[] args)
        {
            // runtime error en las lineas comentadas
            var a = 3L;
            dynamic b = 32;
            object obj = 3;
            a = a * 2.0; //No se puede convertir implícitamente el tipo 'double' en 'long'
            b = b * 2.0;
            b = "hola";
            obj = b;
            b = b + 11;
            obj = obj + 11; //El operador '+' no se puede aplicar a operandos del tipo 'object' y 'int'
            var c = new { Nombre = "Juan" };
            var d = new { Nombre = "María" };
            var e = new { Nombre = "Maria", Edad = 20 };
            var f = new { Edad = 20, Nombre = "Maria" }; // No se puede asignar a la propiedad o el indizador '<anonymous type: int Edad, string Nombre>.Edad' porque es de solo lectura
            f.Edad = 22;
            d = c; //No se puede convertir implícitamente el tipo '<anonymous type: string Nombre>' en '<anonymous type: string Nombre, int Edad>'
            e = d; //No se puede convertir implícitamente el tipo '<anonymous type: string Nombre, int Edad>' en '<anonymous type: int Edad, string Nombre>'
            f = e;
        }
    }
}
