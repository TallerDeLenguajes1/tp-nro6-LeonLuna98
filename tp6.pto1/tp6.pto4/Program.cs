using System;

namespace tp6.pto4
{
  
    class Program
    {
        public int Length { get; }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //El tipo string se pasa por referencia
            //El @"cadena" sirve para que este ignore todos los caracteres especiales dentro de la cadena

            Console.WriteLine("Ingrese una cadena: ");
            string Cadena = Console.ReadLine();

            //Busca una letra en la cadena y muestra cuanta veces aparece
            Console.WriteLine("Ingrese una letra: ");
            char letra1 = char.Parse(Console.ReadLine());
            int cont = 0;
            foreach (char letrabuscada in Cadena)
            {
                if (letra1 == letrabuscada)
                {
                    cont++;

                }
            }
            Console.WriteLine("La letra '{0}' se repite '{1}' veces en la cadena", letra1, cont);
            
            //Concatena dos cadenas
            string cad1 = "La cadenas ";
            string cad2 = " SI se concatenaron ";
            string cad3 = cad1 + cad2;
            Console.WriteLine(cad3); 



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

             //Convertir de mayuscula a minuscula
            Cadena = Cadena.ToUpper();
            Console.WriteLine("Mayuscula:  " + Cadena);
            Cadena = Cadena.ToLower();
            Console.WriteLine("Minuscula:  " + Cadena);
            Console.ReadLine();

            //Operacion simple con string
            Console.WriteLine("Ingrese una operacion matematica con strings");
            string operacion = Console.ReadLine();
            string[] numeros = operacion.Split(new Char[] { '+', '-', '*', '/' });
            int resultado = Convert.ToInt32(numeros[0]) +  Convert.ToInt32(numeros[1]);
            Console.WriteLine("La resultado de de {0} y {1} es {3}: ",numeros[0], numeros[1], resultado);

           
        }
    }
}
