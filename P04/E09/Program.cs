using System;

namespace E09
{
    class Auto {
        public double Velocidad;
    }
    class Program1    {
        static Auto a; //omitir esta linea para programa de la derecha
        static void Main() {
            // Auto a; si "a" no es estatico, es necesario instanciar a -> Auto a = new Auto();
            a.Velocidad=10;
            //El objeto "a" se inicializa antes que el programa y su campo Velocidad inicializa en 0 por defecto
        }
    }
}
