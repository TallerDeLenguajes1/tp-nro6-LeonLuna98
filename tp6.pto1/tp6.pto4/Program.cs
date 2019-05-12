using System;

namespace tp6.pto4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string cadena;
            Console.Write("Ingrese una cadena ");
            cadena = (Console.ReadLine());
            //char letra;
            //Console.Write("Ingrese una letra");
            //letra = char.Parse(Console.ReadLine());
            Console.WriteLine("La cadena es: "+ cadena.ToString());
            cadena= cadena.ToUpper();
            Console.WriteLine("La cadena es: " + cadena.ToString());
            cadena = cadena.ToLower();
            Console.WriteLine("La cadena es: " + cadena.ToString());
            Console.ReadLine();
        }
    }
}
