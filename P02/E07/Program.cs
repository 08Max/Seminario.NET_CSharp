using System;

namespace E07
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            char? c2;
            string st;
            c = ""; //compile error: no se puede convertir implicitamente un string en un char 
            c = ''; // char es una estructura de solo lectura
            c = null; //compile error: deberia ser un char nullable
            c2 = null;
            c2 = 65 as char?; //compile error: en lugar de un int deberia asignarse un char,:
            // ejemplo correcto -> c2 = 'F' as char?; 
            st = "";
            st = ''; //compile error: usar "" para asignar un string
            st = null;
            st = (char)65; //compile error: 65 tiene dos digitos -> no puede convertirse a char. 
                            //Usar metodo ToString
            st = (string)65; //Usar metodo ToString para convertir un int a String 
            st = 47.89.ToString();
        }
    }
}
