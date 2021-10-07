using System;

namespace E08
{
    class Matriz {
        private int _filas;
        private int _columnas;
        private double [,] _m; 
        public Matriz(int filas,int columnas){
            this._filas=filas;
            this._columnas=columnas;
        }
        public Matriz(double[,] matriz){
            this._m=matriz;
        }
        public void SetElemento(int fila, int columna, double elemento){
            //sobreescribe lo que haya en esa ubicacion
            this.m[fila,columna]=elemento;
            //deberia controlarlo de otra manera?
        }
        public double GetElemento(int fila, int columna){
            return this._m[fila,columna];
            // puede que devuelva el valor de un double por defecto
        }
        public void Imprimir() {

        }
        public void Imprimir(string formatString) {

        }
        public double[] GetFila(int fila) {
            double [] aux = new double [this._columnas];
            for (int columna = 0; columna < this._columnas; columna++)
            {
                aux[columna]=this._m[fila,columna];
            }
            return aux;
        }
        public double[] GetColumna(int columna){
            
        }
        public double[] GetDiagonalPrincipal(){

        }
        public double[] GetDiagonalSecundaria(){

        }
        public double[][] GetArregloDeArreglo() {

        }
        public void Sumarle(Matriz m){

        }
        public void Restarle(Matriz m){

        }
        public void MultiplicarPor(Matriz m){

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
