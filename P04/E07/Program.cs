using System;
using System.Collections;

namespace E07
{
    class Nodo
    {
        private int _valor;
        private Nodo _hi;
        private Nodo _hd;
        public Nodo() {

        }
        public Nodo(int raiz){
            this._valor=raiz;
            this._hi=null;
            this._hd=null;
        }

        public void Insertar(int valor){ // consultar si hay manera mas eficiente
            if (this._valor!=valor) {
                if (valor<this._valor) { //si valor entrante es menor al actual ---> izq
                    if (this._hi==null) { // si no hay nodo a la izq
                        this._hi = new Nodo(valor); //crear nuevo nodo con valor entrante
                    } else {
                        this._hi.Insertar(valor); //insertar ---> izq
                    }  
                } else {
                    if (this._hd==null) { // si no hay nodo a la der
                            this._hd = new Nodo(valor); //crear nuevo nodo con valor entrante
                    } else { //si ya existe el nodo a la derecha
                        this._hd.Insertar(valor); //insertar --> derecha  
                        }
                }
            }
        }
        public ArrayList GetInOrder(){
                //cada nodo hace su propia lista ordenada con los nodos hijos 
                // y retorna dicha lista ordenada a su nodo padre 
            ArrayList aux = new ArrayList(); 
            if (this._hi!=null ) { //si existe hi
                //agregar cada elemento de la lista ordenada que llega de los hijos izq
                aux.AddRange(this._hi.GetInOrder());
            }
            aux.Add(this._valor); //agregar elemento actual
            if (this._hd!=null) { //si existe hd
                //agregar cada elemento de la lista ordenada que llega de los hijos der
                aux.AddRange(this._hd.GetInOrder());
            }
            return aux;
        }
        public int GetCantNodos(){
            // cada nodo cuenta sus hijos, a si mismo y retorna ese valor al nodo padre
            int aux=0; 
            if (this._hi!=null ) { //si existe hi
                //cuenta los nodos de la izquierda y acumula
                aux+=this._hi.GetCantNodos();
            }
            aux++; //acumula 1 nodo
            if (this._hd!=null) { //si existe hd
                //cuenta los nodos de la derecha y acumula
                aux+=this._hd.GetCantNodos();
            }
            return aux;
        }
        public int GetValorMaximo(){
            //segun la estructura de este arbol binario el valor max esta al extremo derecho
            if (this._hd!=null){
                return this._hd.GetValorMaximo();
            }
            else {
                return this._valor;
            }
        }
        public int GetValorMinimo(){
            //segun la estructura de este arbol binario el valor min esta al extremo izquierdo
            if (this._hi!=null){
                return this._hi.GetValorMinimo();
            }
            else {
                return this._valor;
            }
        }
        public int GetAltura() {
            
            if ((this._hi==null)&& (this._hd==null) ) { //si el nodo no tiene hijos
                return 0;
            } else { //entonces tiene algun hijo
                //inicializo alturas de hijos
                int altura_i=0,altura_d=0;
                //controlar de que lado hay hijos,calcular altura en los lados con nodos
                if (this._hi!=null) { altura_i=this._hi.GetAltura(); }
                if (this._hd!=null) { altura_d=this._hd.GetAltura(); }
                //comparar alturas y devolver la altura maxima
                if ( (altura_i.Equals(altura_d)|| (altura_i>altura_d) ) )  {
                    return (1+altura_i); // 1 (nodo actual) + altura izq
                }
                else {
                    return (1+altura_d); //1 (nodo actual) + altura derecha
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Nodo n = new Nodo(7); // 'a' representa la raiz del arbol
            n.Insertar(8);
            n.Insertar(10);
            n.Insertar(3);
            n.Insertar(1);
            n.Insertar(5);
            n.Insertar(14); 
            foreach (int i in n.GetInOrder())
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(n.GetAltura()); //ok
            Console.WriteLine(n.GetCantNodos()); //ok  
            Console.WriteLine(n.GetValorMaximo()); //ok
            Console.WriteLine(n.GetValorMinimo()); //ok
        }
    }
}
