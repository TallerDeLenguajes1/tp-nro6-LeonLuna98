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
            double n;
            Console.Write("Ingrese un numero: ");
            n = double.Parse(Console.ReadLine());
            double raiz = Math.Round(Math.Sqrt(n),2);//Cantidad de decimales
            Console.WriteLine("La raiz es: " + raiz.ToString());
            double coseno = Math.Round(Math.Cos(n), 2);
            Console.WriteLine("El coseno es: " + coseno.ToString());
            double seno = Math.Round(Math.Sin(n), 2);
            Console.WriteLine("El seno es: " + seno.ToString());
            double max = Math.Max(a, b);
            Console.WriteLine("El maximo entre " + a + " y " + b + " es " + max.ToString());
            double min = Math.Min(a, b);
            Console.WriteLine("El minimo entre " + a + " y " + b + " es " + min.ToString());
            double potencia = Math.Pow(n, 2.0);
            Console.WriteLine("La potencia cuadrada de " + n + " es " + potencia.ToString());

            Console.ReadLine();
            
        }
    }
}
