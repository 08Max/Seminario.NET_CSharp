using System;
using System.Collections;
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

        private static ArrayList s_cuentas = new ArrayList();
        private int _id;

        public Cuenta () {
            s_id++; // incremento la cantidad de id usado
            this._id=s_id; //asigno a la cuenta de INSTANCIA actual, el id siguiente al ultimo id usado
            s_cuentas.Add(this);
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
        public static ArrayList GetCuentas() {
            return (ArrayList)s_cuentas.Clone();
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
            new Cuenta();
            new Cuenta();

            ArrayList cuentas = Cuenta.GetCuentas();
            // se recuperó la lista de cuentas creadas
            (cuentas[0] as Cuenta).Depositar(50);
            // se depositó 50 en la primera cuenta de la lista devuelta
            cuentas.RemoveAt(0);
            Console.WriteLine(cuentas.Count);
            // se borró un elemento de la lista devuelta
            // pero la clase Cuenta sigue manteniendo todos
            // los datos "La cuenta id: 1 tiene 50 de saldo"
            cuentas = Cuenta.GetCuentas();
            Console.WriteLine(cuentas.Count);
            // se recupera nuevamente la lista de cuentas
            (cuentas[0] as Cuenta).Extraer(30);
            //se extrae 25 de la cuenta id: 1 que tenía 50 de sald
        }
    }
}
