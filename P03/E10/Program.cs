using System;

namespace E10
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 1794.68235;
            string cadena = String.Format("Numero formateado -> {0:C3}",num);
            Console.WriteLine(cadena);
            cadena = $"Numero formateado -> {num:C3}";
            Console.WriteLine(cadena);
            // Conclusion: al formatear una cadena con String.Format formato compuesto y con formato de Cadena interpolada, 
            // en ambos casos el numero se trunca a la cantidad de digitos decimales que se indique 
            // el unico caso en que redondea es aplicando un formato de porcentaje con el formato PX
            
            /* EJEMPLO EXTRAIDO DE LA DOCUMENTACION DE C#
                LINK al documento: https://docs.microsoft.com/es-es/dotnet/api/system.string.format?view=net-5.0#how-do-i-control-the-number-of-digits-after-the-decimal-separator
                
                object[] values = { 1603, 1794.68235, 15436.14 };
                string result;
                foreach (var value in values) {
                result = String.Format("{0,12:C2}   {0,12:E3}   {0,12:F4}   {0,12:N3}  {1,12:P2}\n",
                                        Convert.ToDouble(value), Convert.ToDouble(value) / 10000);
                Console.WriteLine(result);
                }                           
                // The example displays output like the following:
                //       $1,603.00     1.603E+003      1603.0000      1,603.000       16.03 %
                //    
                //       $1,794.68     1.795E+003      1794.6824      1,794.682       17.95 %
                //    
                //      $15,436.14     1.544E+004     15436.1400     15,436.140      154.36 %
            */
        }
    }
}
