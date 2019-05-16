using System;

namespace tp6.pto4
{
  
    class Program
    {
        public int Length { get; }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ingrese una cadena: ");
            string Cadena = Console.ReadLine();

            //Imprime cada elemento de la cadena
            foreach (char letrita in Cadena)
            { Console.WriteLine(letrita); }

            //Cadena separada por caracteres determinados con split()
            string[] Cadenaaux = Cadena.Split(new Char[] { '?', ',', '.', '!' });
            foreach (string palabra in Cadenaaux) {
                Console.WriteLine(palabra); }

            //Longitud de la cadena
            Console.WriteLine(" La longitud de la cadena '{0}' es {1}", Cadena, Cadena.Length);

            //Palabra a buscar
            Console.WriteLine("Ingrese una palabra a buscar");
            string palabraabuscar = Console.ReadLine();
            int letra = Cadena.IndexOf(palabraabuscar);
            string laletra = Cadena.Substring(letra);
            Console.WriteLine(laletra);

            //Operacion simple con string
            string operacion = Console.ReadLine();
            string[] numeros = operacion.Split(new Char[] { '+', '-', '*', '/' });
            int resultado = Convert.ToInt32(numeros[0]) +  Convert.ToInt32(numeros[1]);
            Console.WriteLine("La resultado de de {0} y {1} es {3}: ",numeros[0], numeros[1], resultado);

            //Convertir de mayuscula a minuscula
            Cadena = Cadena.ToUpper();
            Console.WriteLine("Mayuscula:  " + Cadena);
            Cadena = Cadena.ToLower();
            Console.WriteLine("Minuscula:  " + Cadena);
            Console.ReadLine();
        }
    }
}
