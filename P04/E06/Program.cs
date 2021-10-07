using System;

namespace E06
{
    class Ecuacion2 {
        private double _a;
        private double _b;
        private double _c;

        public Ecuacion2(double a,double b, double c) {
            this._a=a;
            this._b=b;
            this._c=c;
        }

        public double GetDiscriminante(){
            return ( Math.Sqrt( (this._b*this._b)-(4*this._a*this._c)) );
        }
        
        public int GetCantidadDeRaices() {
            double d=this.GetDiscriminante();
            /*
            if (d<0) { return 0;}
            else {
                if (d==0) {return 1;}
                else {return 2;}
            }
            */
            int r;
            r= d<0 ? 0 : d==0 ? 1 : 2 ;
            return r;
        }
        
        public void ImprimirRaices(){
            int n=GetCantidadDeRaices();
            string message="";
            switch (n)
            {
                case 0 :
                    message="sin raices reales";
                break;
                case 1 :
                    message=" Unica raiz: "+( ( (-1*this._b)+ GetDiscriminante() ) / (2*this._a) ).ToString();
                break;
                case 2 :
                    message+=" Raiz positiva: "+ ( ( (-1*this._b)+ GetDiscriminante() ) / (2*this._a) ).ToString()+"\n"; 
                    message+=" Raiz negativa: "+ ( ( (-1*this._b)-GetDiscriminante() ) / (2*this._a) ).ToString()+".";
                break;
            }
            Console.WriteLine(message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ecuacion2 e = new Ecuacion2(1,2,1);
            e.ImprimirRaices();
        }
    }
}
