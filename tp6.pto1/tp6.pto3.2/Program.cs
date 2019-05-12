using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace tp6.pto3
{
    class Program
    {
        /* private double num;

            int Max = Math.Max(a, b);
            int Min = Math.Min(a, b);

        double resultado2 = Math.Round(100.496);//Redondea un numero
        //double potencia = Math.Pow(num, 2.0);
        //double raiz = Math.Sqrt(num);
        //double trucado = Math.Truncate(num);
        //double absoluto = Math.Abs(num);
       public double Trucado(){
            double trucado = num;
            return  Math.Truncate(trucado);
        }
        public double Absoluto(){
            double absoluto =num ;
            return Math.Abs(num);
        }
        public double Raizx(){
            double raiz = num;
            return Math.Sqrt(num);
        }
        public double Cosenox(){
            double cosX = num;
            return Math.Round(Math.Asin(cosX), 2);
        }

        public double Senox(){
             double sinX=num;
             return Math.Round(Math.Asin(sinX), 2);
        }*/


        static void Main(string[] args)
        {
            char operador;
            int a, b, c;
            Console.Write("Ingrese un operador + , - , * , /: ");
            operador = char.Parse(Console.ReadLine());

            Console.Write("Ingrese el primer numero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            b = int.Parse(Console.ReadLine());
            switch (operador)
            {
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
            Console.WriteLine("---Estas en el ejercicio 3---");
            double n;
            Console.Write("Ingrese un numero: ");
            n = double.Parse(Console.ReadLine());
            double raiz = Math.Round(Math.Sqrt(n), 2);//Cantidad de decimales
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