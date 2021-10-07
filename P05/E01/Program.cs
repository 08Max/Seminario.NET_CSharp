using System;

namespace E01
{
    class Cuenta {
        private int _saldo;
        private static int s_id=0;
        private static int s_cantidad_depositos; 
        private static int s_cantidad_extracciones;
        private static int s_cantidad_extracciones_denegadas;
        private static int s_total_depositado;
        private static int s_total_extraido;

        private int _id;

        public Cuenta () {
            this._id=s_id+1;
            s_id++;
            Console.WriteLine($"Se creo la cuenta ID={this._id}");
        }
        public Cuenta Depositar(int monto){
            this._saldo+=monto;
            Console.WriteLine($"Se depositó {monto} en la cuenta {this._id} (Saldo={this._saldo})");
            s_cantidad_depositos++;
            s_total_depositado+=monto;
            return this;
        }
        public Cuenta Extraer (int monto) {
            if (monto<=this._saldo){
                this._saldo=this._saldo-monto;
                Console.WriteLine($" Se extrajo {monto} de la cuenta {this._id} (Saldo: {this._saldo})");
                s_cantidad_extracciones++;
                s_total_extraido+=monto;
            } else {
                Console.WriteLine($" Operación denegada, saldo insuficiente ");
                s_cantidad_extracciones_denegadas++;
            }
            return this;
        }

        public static void ImprimirDetalle() {
            
            Console.WriteLine($"CUENTAS CREADAS: {s_id}"); 
            Console.WriteLine($"DEPOSITOS: \t {s_cantidad_depositos} - Total depositado: {s_total_depositado}");
            Console.WriteLine($"EXTRACCIONES: \t {s_cantidad_extracciones} - Total extraido: {s_total_extraido}");
            Console.WriteLine($"Saldo: {s_total_depositado - s_total_extraido}");
            Console.WriteLine($"* Se denegaron {s_cantidad_extracciones_denegadas} por falta de fondos");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta c1 = new Cuenta();
            c1.Depositar(100).Depositar(50).Extraer(120).Extraer(50);
            Cuenta c2 = new Cuenta();
            c2.Depositar(200).Depositar(800);
            new Cuenta().Depositar(20).Extraer(20);
            c2.Extraer(1000).Extraer(1);
            Console.WriteLine("\n DETALLE");
            Cuenta.ImprimirDetalle(); 
            //FUNCIONA OK 
            //COSAS PARA CORREGIR : TABULACION CON QUE SE MUESTRAN LOS DATOS. BUSCAR EN documentacion de cadena interpolada
        }
    }
}
