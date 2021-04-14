using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_L2_T4_Series
{
    class Program
    {
        public delegate void Delegate(int n);
        static void Main(string[] args)
        {
            Console.Write("Enter the precision: ");
            int n = int.Parse(Console.ReadLine());
            Delegate d1 = new Delegate(Type1);
            d1.Invoke(n);
            Delegate d2 = new Delegate(Type2);
            d2.Invoke(n);
            Delegate d3 = new Delegate(Type3);
            d3.Invoke(n);
            Console.ReadKey();
        }
        public static void Type1(int n)
        {
            double output = 0;
            int bottom = 1;
            for (int i = 1; i <= n; i++)
            {
                output += 1.0 / bottom;
                bottom *= 2;
            }
            Console.WriteLine("Series #1: " + output);

        }

        public static void Type2(int n)
        {
            double output = 0;
            for (int i = 1; i <= n; i++)
            {
                output += 1.0 / Factorial(i);
            }
            Console.WriteLine("Series #2: " + output);
        }
        public static void Type3(int n)
        {
            double output = 1;
            int bottom = 1;
            if (n % 2 == 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    bottom *= 2;
                    output += 1.0 / bottom;
                    bottom *= 2;
                    output -= 1.0 / bottom;
                }
            }
            else
            {
                for (int i = 1; i <= n - 1; i++)
                {
                    bottom *= 2;
                    output += 1.0 / bottom;
                    bottom *= 2;
                    output -= 1.0 / bottom;
                }
                output += 1.0 / bottom;
            }
            Console.WriteLine("Series #3: " + output);
        }
        public static int Factorial(int b)
        {
            int res = 1;
            for (int i = 1; i <= b; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}
