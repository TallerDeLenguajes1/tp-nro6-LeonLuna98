using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp6.pto2
{
    class Program
    {
        static void Main(string[] args)
        {
            char operador;
            int a, b,c;
            Console.Write("Ingrese un operador + , - , * , /: ");
            operador = char.Parse(Console.ReadLine());

            Console.Write("Ingrese el primer numero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            b =int.Parse(Console.ReadLine());
                switch (operador){
                    case '*':
                        c = a * b;
                        Console.WriteLine("La multiplicacion de " + a + " por " + b + " es " + c);
                        break;
                    
                    case '-':                
                        c = a - b;
                        Console.WriteLine("La resta de " + a + " menos " + b + " es " + c);
                        break;
                    
                    case '+':
                        c = a + b;
                        Console.WriteLine("La suma de " + a + " mas " + b + " es " + c);
                        break;
                    
                    case '/':
                        c = a / b;
                        Console.WriteLine("La division entera de " + a + " sobre " + b + " es " + c);
                        break;
                    
                }
            Console.ReadLine();
            
        }
    }
}
