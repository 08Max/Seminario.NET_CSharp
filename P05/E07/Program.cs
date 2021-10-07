/*
7) Definir la clase Persona con las siguientes propiedades de lectura y escritura: Nombre de tipo
string, Sexo de tipo char, DNI de tipo int, y FechaNacimiento de tipo DateTime. Además
definir una propiedad de sólo lectura (calculada) Edad de tipo int. Definir un indizador de
lectura/escritura que permita acceder a las propiedades a través de un índice entero. Así, si p es un
objeto Persona, con p[0] se accede al nombre, p[1] al sexo p[2] al DNI, p[3] a la fecha de
nacimiento y p[4] a la edad. En caso de asignar p[4] simplemente el valor es descartado. Observar
que el tipo del indizador debe ser capaz almacenar valores de tipo int, char, DateTime y string.
*/
using System;
namespace E07
{
    class Persona {
        private string _nombre;
        private char _sexo;
        private int _dni;
        private DateTime _FechaNacimiento;
        private int _edad;
        public Persona () {

        }
        public Persona (string nombre, char sexo, int dni, DateTime FechaNacimiento, int edad){
        }
        public string Nombre {
            get { return _nombre;}
            set {_nombre=value;}
        }
        public char Sexo {
            get { return _sexo;}
            set {_sexo=value;}
        }
        public int Dni {
            get { return _dni;}
            set {_dni=value;}
        }
        private int calcular_edad(DateTime fecha_nacimiento){
            int aux = DateTime.Now.Year - fecha_nacimiento.Year;
            // para hacerlo más preciso deberia agregar las condiciones para comparar
            // HH, MM y SS, y así calcular si cumplió años o no.
            // pero me pareció innecesario en este caso
            // ya que no es algo usual comparar HH,MM y SS para una edad
            if ( (DateTime.Now.Month<fecha_nacimiento.Month) | (DateTime.Now.Month==fecha_nacimiento.Month && DateTime.Now.Day<fecha_nacimiento.Day) ) {
                aux--;
            }
            return aux;
        }
        public int Edad {
            get { return this._edad;}
            set { this._edad=value;} 
        }
        public DateTime FechaNacimiento {
            get { return _FechaNacimiento;}
            set {_FechaNacimiento=value;}
        }
        public object this [int i]{
            get {
                switch(i) {
                    case 0: return (object)Nombre; break;
                    case 1: return (object)Sexo; break;
                    case 2: return (object)Dni; break;
                    case 3: return (object)FechaNacimiento; break;
                    case 4: return (object)Edad; break;
                    default: return null;
                }
            }
            set {
                switch(i) {
                    case 0: Nombre=(string)value; break;
                    case 1: Sexo=(char)value; break;
                    case 2: Dni=(int)value; break;
                    case 3: 
                        FechaNacimiento=(DateTime)value;
                        Edad=calcular_edad(FechaNacimiento);
                    break;
                    case 4: break;
                }
            }
        }
        public void Imprimir (){
            Console.WriteLine("Datos");
            Console.WriteLine($"\t Nombre: {this[0].ToString()} ");
            Console.WriteLine($"\t Sexo: {this[1].ToString()} ");
            Console.WriteLine($"\t DNI: {this[2].ToString()} ");
            Console.WriteLine($"\t Fecha de nacimiento: {this[3].ToString()} ");
            Console.WriteLine($"\t Edad: {this[4].ToString()} ");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese fecha de nacimiento. Formato: aaaa-mm-dd");
            string [] aux_fecha = new string[3]; //arreglo que tiene aa, mm y dd. (EN ESE ORDEN)
            aux_fecha=Console.ReadLine().Split("-");
                //DateTime dateFromString = DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);
            //crear indizador
            Persona p = new Persona();
            //asignar las propiedades a traves del indizador
            p[0]="Juan Carlos";
            p[1]='M';
            p[2]=38135123;
            p[3]=new DateTime(int.Parse(aux_fecha[0]),int.Parse(aux_fecha[1]),int.Parse(aux_fecha[2]));;
            //obtener info a traves del indizador
            p.Imprimir();
        }
    }
}
