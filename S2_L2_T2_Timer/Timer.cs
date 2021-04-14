using System;
using System.Threading;
using static S2_L2_T2_Timer.Program;

namespace S2_L2_T2_Timer
{
    class Timer
    {
        public void Start(int sec)
        {
            Methods[] mts = new Methods[]
            {
                Task1, Task2, Task3
            };
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(sec * 1000);
                mts[i]();
            }
        }
        private static void Task1()
        {
            Random rnd = new Random();
            int num = rnd.Next(0, 100);
            Console.WriteLine("Task #1 - Random number: {0}", num);
        }
        private static void Task2()
        {
            Console.WriteLine("Task #2 - Time of the day: {0}", DateTime.Now.TimeOfDay);
        }
        private static void Task3()
        {
            Console.WriteLine("Task #3 - Day of the month: {0}", DateTime.Now.Day);
        }
    }
}