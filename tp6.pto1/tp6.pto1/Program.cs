using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp6.pto1
{
    class Program
    {
        static void Main(string[] args)

        {
            int N;
            N = int.Parse(Console.ReadLine());
   
            int aux=0;
            int aux2 = 0;
            if (N > 0)
            {
                while (N != 0) { 
                aux2 = N % 10;
                aux = aux * 10 + aux2;
                N = N / 10;
               
                }
                Console.WriteLine("Numero invertido:" + aux);
            }
            else
            {

                Console.WriteLine(0);
            }
            Console.ReadLine();
        }
    }
}
