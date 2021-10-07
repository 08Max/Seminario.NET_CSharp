using System;

namespace E13
{
    class Program
    {
        static void Main(string[] args)
        {
            string? st,st1=null,st2=null,st3=null,st4=null;
            /*
            if (st1 == null)
            {
                if (st2 == null)
                {
                    st = st3;
                }
                else
                {
                    st = st2;
                }
            }
            else
            {
                st = st1;
            }
            if (st4 == null)
            {
                st4 = "valor por defecto";
            }
            */
            st = st1 ?? st2 ?? st3; 
            Console.WriteLine(st);

            st4 ??= "valor por defecto";
            Console.WriteLine(st4);
        }
    }
}
