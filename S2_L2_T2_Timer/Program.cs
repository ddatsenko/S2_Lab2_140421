using System;

namespace S2_L2_T2_Timer
{
    class Program
    {
        delegate void Delegate(int s);
        public delegate void Methods();
        static void Main(string[] args)
        {
            Console.Write("Enter the number of seconds: ");
            int s = int.Parse(Console.ReadLine());
            Timer timer = new Timer();
            Delegate dlgt = timer.Start;
            dlgt.Invoke(s);
            Console.ReadKey();
        }
    }
}
