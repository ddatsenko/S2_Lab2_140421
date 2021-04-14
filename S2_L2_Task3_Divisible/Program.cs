using System;

namespace S2_L2_Task3_Divisible
{
    class Program
    {
        public delegate void DivisibleBy(int[] mas);
        static void Main(string[] args)
        {
            int[] arr = {-50, -49, -48, -47, -46, -45, -44, -43, -42, -41, -40, -39, -38, -37, -36, -35, -34, -33, -32, -31, -30, -29, -28, -27, -26, -25, -24, -23, -22, -21, -20, -19, -18, -17,
                         -16, -15, -14, -13, -12, -11, -10, -9, -8, -7, -6, -5, -4, -3, -2, -1,
                         0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
                         20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50};
            DivisibleBy d3 = new DivisibleBy(IfDivisibleBy3);
            DivisibleBy d7 = new DivisibleBy(IfDivisibleBy7);
            d3(arr);
            d7.Invoke(arr);
            Console.ReadKey();
        }
        public static void IfDivisibleBy3(int[] arr)
        {
            Console.WriteLine("Numbers, divisible by 3: ");
            foreach (int a in arr)
            {
                if (a % 3 == 0)
                {
                    Console.Write(a + ", ");
                }
            }
            Console.WriteLine();
        }
        public static void IfDivisibleBy7(int[] arr)
        {
            Console.WriteLine("Numbers, divisible by 7: ");
            foreach (int a in arr)
            {
                if (a % 7 == 0)
                {
                    Console.Write(a + ", ");
                }
            }
            Console.WriteLine();
        }
    }
}