using System;

namespace E04
{
    class Hora {
        private int _hh;
        private int _mm;
        private int _ss;
        public Hora(){

        }
        public Hora(double x) {
            
        }
        public Hora(int hh,int mm,int ss) {
            this._hh=hh;
            this._mm=mm;
            this._ss=ss;
        }

        public void Imprimir(){
            Console.WriteLine($"{this._hh} horas, {this._mm} minutos y {this._ss} segundos");
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            new Hora(23,30,15).Imprimir(); //es valido: no necesito usar la instancia despues
            // Hora h = new Hora(23,30,15).Imprimir();  //si necesito usar la instancia despues guardar en variable 
        }
    }
}
