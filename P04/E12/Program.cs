using System;

namespace E12
{
    class Cuenta {
        private int _dni;
        private string _name="No especificado";
        private int _monto;
        
        public Cuenta () {

        }
        public Cuenta (int dni){
            this._dni=dni;
        }
        public Cuenta (string name){
            this._name=name;
        }
        public Cuenta (string name, int dni):this(name) {
            this._dni=dni;
        }
        public string validarDni(){
            if (this._dni==0){ return "No especificado"; }
            else {return this._dni.ToString();}
        }
        public void Imprimir() {
            Console.WriteLine($" Nombre : {this._name} , DNI: {this.validarDni()} , MONTO: {this._monto}");
        }
        public void Depositar(int monto) {
            this._monto=monto;
        }
        public void Extraer(int monto){
            //validar que no extraiga mas de lo que hay
        
            if (monto<=this._monto){ this._monto-=monto; }
            else { Console.WriteLine(" Operación cancelada, monto insuficiente");}

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta();
            cuenta.Imprimir();
            cuenta = new Cuenta(30222111);
            cuenta.Imprimir();
            cuenta = new Cuenta("José Perez");
            cuenta.Imprimir();
            cuenta = new Cuenta("Maria Diaz", 20287544);
            cuenta.Imprimir();
            cuenta.Depositar(200);
            cuenta.Imprimir();
            cuenta.Extraer(150);
            cuenta.Imprimir();
            cuenta.Extraer(1500);
        }
    }
}
