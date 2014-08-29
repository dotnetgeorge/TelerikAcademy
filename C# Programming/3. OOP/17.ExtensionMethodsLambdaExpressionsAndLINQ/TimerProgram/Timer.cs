namespace TimerProgram
{
    using System;
    using System.Threading;

    public class Timer
    {
        public delegate void ExecuteMethod();
        public ExecuteMethod method;

        public void Start(int interval, int totalTime)
        {
            DateTime now = DateTime.Now;
            DateTime latter = now.AddSeconds(totalTime);
            while (now <= latter)
            {
                method();
                Thread.Sleep(interval * 1000);
                now = DateTime.Now;
            }
        }
    }
}
