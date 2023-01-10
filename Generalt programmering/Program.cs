using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generalt_programmering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IsResultTheSame(1*1, 1+1);
            AddAndMultiply(1, 2, 3);
            CtoF(-271.15);
            ElementaryOperations(1, 2);
            ModuloOperations(1, 2, 3);
            TheCubeOf(2);
            SwapTwoNumbers(1, 2);

        }

        private static int AddAndMultiply(int c, int a, int b)
        {
            Console.WriteLine(c + a * b);
            return c + a * b;
        }

        private static void CtoF(double tempC)
        {
            if (tempC <= -271.15)
            {
                Console.WriteLine("Temperature below absolute zero!");
                return;
            }else
            {
                Console.WriteLine(tempC * 33.8);
                return;
            }
        }

        private static void ElementaryOperations(double a, double b)
        {
            Console.WriteLine(addition(a, b).ToString() + "," + substraction(a, b).ToString() + "," + multiplication(a, b).ToString() + "," + division(a, b).ToString());
        }

        private static double addition(double a, double b)
        {
            return a + b;
        }

        private static double substraction(double a, double b)
        {
            return a - b;
        }

        private static double multiplication(double a, double b)
        {
            return a * b;
        }

        private static double division(double a, double b)
        {
            if ((double)a == 0 | (double)b == 0)
            {
                return a;
            }
            return a / b;
        }

        private static bool IsResultTheSame(int a, int b)
        {
            Console.WriteLine(a == b);
            return (a == b);

        }

        private static int ModuloOperations(int a, int b, int c)
        {
            Console.WriteLine(a % b % c);
            return a % b % c;
        }

        private static double TheCubeOf(double a)
        {
            a = a * a * a;
            Console.WriteLine(a);
            return a;
        }

        private static void SwapTwoNumbers(int a, int b)
        {
            string tempA = b + "," + a;
            Console.WriteLine(tempA);
        }
    }
}
