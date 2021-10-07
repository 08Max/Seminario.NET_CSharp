using System;
using System.Collections;
namespace E08
{
    class Persona {
        private string _nombre;
        private char _sexo;
        private int _dni;
        private DateTime _FechaNacimiento;
        private int _edad;
        public Persona () {

        }
        public Persona (string nombre, char sexo, int dni, DateTime FechaNacimiento){
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
                    //deberia contemplar que si llega algo mayor a 4?
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
    class ListaDePersonas
    {

        private Hashtable ht = new Hashtable();
        public void Agregar(Persona p)
        {
            ht[p.Dni] = p;
        }
        public void mostrarLista(){
            ICollection keys= ht.Keys;
            foreach ( int x in keys)
            {
                Console.WriteLine("Clave: "+x);
            }
        }
        // funcion que devuelve true si encuentra el dni en la tabla hash, sino false
        public bool buscarDni(int dni){ 
            bool encontrado=false;
            ICollection claves = ht.Keys;
            foreach ( int clave in ht.Keys) {
                if (clave==dni){encontrado=true;};
            }
            return encontrado;
        }
        public Persona this [int dni]{
            get {
                if (buscarDni(dni)) { 
                    Console.WriteLine("ENCONTRADO");
                    return (Persona)ht[dni];
                    }
                else {
                    Console.WriteLine("NO ENCONTRADO");
                    return null;
                }
            }
        }
        /*
        public string [] this [char c]{
            string aux;
            get {return aux;}  
        }
        */
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese fecha de nacimiento. Formato: aaaa-mm-dd");
            string [] aux_fecha = new string[3]; //arreglo que tiene aa, mm y dd. (EN ESE ORDEN)
            aux_fecha=Console.ReadLine().Split("-");
                //DateTime dateFromString = DateTime.Parse(dateString, System.Globalization.CultureInfo.InvariantCulture);
            DateTime fecha = new DateTime(int.Parse(aux_fecha[0]),int.Parse(aux_fecha[1]),int.Parse(aux_fecha[2]));
            Persona p = new Persona("Juan Carlos",'M',45321444,fecha);
            ListaDePersonas lista = new ListaDePersonas();
            lista.Agregar(p);
            //p=lista[45321444];
            Console.WriteLine(p==null); //muestra TRUE. o sea que no devuelve el objeto persona
            lista.mostrarLista();
            /*
                PROBLEMAS: el indizador del dni devuelve NULL, o no agrega la persona a la tabla o no hice bien el buscarDNI... 
            */ 
            /*COSAS PARA MEJORAR
                Como trabajar con la fecha de manera mas automatica, debe haber manera de evitar
                hacer el split, buscar sobre formatos de fecha
            */
        }
    }
}
