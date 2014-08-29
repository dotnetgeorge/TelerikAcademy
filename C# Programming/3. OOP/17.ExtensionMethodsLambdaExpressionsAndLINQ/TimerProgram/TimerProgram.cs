/*
 * Using delegates write a class Timer that has
 * can execute certain method at each t seconds.
 */
using System;
using System.Threading.Tasks;

namespace TimerProgram
{
    class TimerProgram
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.method = DateNow;
            timer.Start(1, 10);
        }

        public static void DateNow()
        {
            Console.WriteLine(DateTime.Now);
        }
    }
}
