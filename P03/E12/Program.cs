using System;
using System.Collections;
using System.Text;
namespace E12
{
    class Program
    {
        static void cargarTablas(ref Hashtable tabla_cifrado,ref Hashtable tabla_descifrado){
            // TABLA DE CIFRADO
            // CLAVES: Chars de 'A'..'Z' y ' '       VALORES: Numeros del 1 al 28
                for (int numero=1,numAscii=65;(numero<=14)&&(numAscii<=78);numero++,numAscii++) {
                    tabla_cifrado.Add((char)numAscii,numero);
                }
                for (int numero=16,numAscii=79;(numero<=27)&&(numAscii<=90);numero++,numAscii++)
                {
                    tabla_cifrado.Add((char)numAscii,numero);
                }
                tabla_cifrado.Add((char)'Ñ',15);
                tabla_cifrado.Add(' ',28);  

            // TABLA DE DESCIFRADO
            // CLAVES: Numeros del 1 al 28       VALORES: Caracteres de 'A'..'Z' y ' ' 
                for (int numero=1,numAscii=65;(numero<=15)&&(numAscii<=78);numero++,numAscii++) {
                    tabla_descifrado.Add(numero,(char)numAscii);
                }
                for (int numero=16,numAscii=79;(numero<=27)&&(numAscii<=90);numero++,numAscii++)
                {
                    tabla_descifrado.Add(numero,(char)numAscii);
                }
                tabla_descifrado.Add(15,'Ñ');
                tabla_descifrado.Add(28,' ');               
        }
        static void mostrarTabla(Hashtable tabla){
            ICollection keys= tabla.Keys;
            foreach ( object x in keys)
            {
                Console.WriteLine("Clave: "+x+" -> Valor: "+tabla[x]);
            }
        }

        static void prepararQueue(ref Queue cola,string [] digitos){
            for (int i = 0; i < digitos.GetLength(0); i++)
            {
                cola.Enqueue(digitos[i]);
            }            
        }
        static string cifrar (string texto,string [] digitos,Hashtable tabla_cifrado, Hashtable tabla_descifrado){
            Queue cola = new Queue();
            prepararQueue(ref cola,digitos);
            //int [] codigoCifrado = new int [texto.Length]; // Implementado en un principio, pero no vi la necesidad de almacenar esta info.
            string mensajeCifrado="";
            for (int i = 0; i < texto.Length; i++)
            {   
                int digitoDeClave = int.Parse( cola.Dequeue().ToString() ); // se desencola un digito de la clave  
                int suma = digitoDeClave+(int)tabla_cifrado[texto[i]]; // sumar digito desencolado al VALOR de la CLAVE del caractér actual que se esta cifrando 
                // controlo que el numero suma no se salga del rango de las CLAVES (que no supere 28 ) de la tabla
                // utilizo la suma como numero CLAVE para obtener su respectivo VALOR (el caractér cifrado final)
                // ese caracter cifrado se concatena con la cadena del cifrado final
                mensajeCifrado+= suma<=28 ? tabla_descifrado[suma] : tabla_descifrado[suma%28]; // 
                cola.Enqueue(digitoDeClave); //encolo el digito de la clave 
            }
            cola.Clear(); //libero la Queue... es necesario si solo tiene alcance en esta rutina?
            return mensajeCifrado;            
        }
        static string descifrar(string texto,string [] digitos,Hashtable tabla_cifrado, Hashtable tabla_descifrado){
            Queue cola = new Queue();
            prepararQueue(ref cola,digitos); //encolo la clave para empezar a comparar el caracter con la clave
            string mensajeDescifrado="";
            for (int i = 0; i < texto.Length; i++)
            {   
                int digitoDeClave = int.Parse( cola.Dequeue().ToString() ); // se desencola un digito de la clave  
                // guarde en A y en B para que sea más legible
                // A En este caso puede pasar que B > A (el resultado de la resta es negativo ) 
                int A = (int)tabla_cifrado[texto[i]]; 
                int B = digitoDeClave; 
                // controlo que la resta resulte en un numero positivo en el rango de CLAVES de la tabla descifrado 
                // (SI B>A -> resultado negativo -> error al acceder a la tabla con una CLAVE negativa )
                int resta = B >= A ? 28 - (B - A ) : A - B;   
                mensajeDescifrado+= tabla_descifrado[resta]; //accedo a la tabla de descifrado con el valor que resultó de la resta 
                cola.Enqueue(digitoDeClave); //encolo el digito
            }
            cola.Clear(); // libero la Queue... es necesario si solo tiene alcance en esta rutina?
            return mensajeDescifrado;
        }
        static void Main(string[] args)
        {   
            // ------------------ COMPARAR CON OTROS PROGRAMAS ----------------------
            
            // 2 TABLAS HASH > 1 para CIFRADO Y 1 para DESCIFRADO
            // tabla _ cifrado : es la tabla que guarda CLAVES 'A','B','C'... 'Z',' ' ; y guarda VALORES 1,2,3,...28 respectivamente
            Hashtable tabla_cifrado = new Hashtable (); 
            // tabla_descifrado : en esta tabla las CLAVES son los numeros y los VALORES son los caracteres (al reves )
            Hashtable tabla_descifrado = new Hashtable();
            // Cargar ambas tablas con sus respectivas claves-valores
            cargarTablas(ref tabla_cifrado,ref tabla_descifrado);
            // Muestro ambas tablas para comprobar que se carguen correctamente
            Console.WriteLine("Tabla de cifrado: ");  mostrarTabla(tabla_cifrado);
            Console.WriteLine("Tabla de descifrado: "); mostrarTabla(tabla_descifrado);
            // Ingreso de clave por teclado
            Console.WriteLine("INGRESAR CLAVE CON LOS DIGITOS SEPARADOS POR una ',' : ");
            string clave = Console.ReadLine(); // string clave="5,3,9,7";
            // Separo cada digito de la clave y los guardo en una posicion del arreglo para manipularlos por separado
            string [] digitos = clave.Split(","); //Console.WriteLine(" INGRESAR TEXTO A CIFRAR : ");
            // Ingreso de la palabra que hay que cifrar por teclado
            string texto = Console.ReadLine(); //string texto = "";
            // guardo lo cifrado en una variable para poder enviarla como parametro al momento de descifrar
            string algoCifrado=cifrar(texto,digitos,tabla_cifrado,tabla_descifrado);
            Console.WriteLine(algoCifrado);
            //en este caso descifra lo mismo que cifró, pero la rutina está preparada para recibir cualquier texto y descifrarlo
            Console.WriteLine(descifrar(algoCifrado,digitos,tabla_cifrado,tabla_descifrado));
        }
    }
}
