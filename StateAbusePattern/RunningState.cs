using System;

namespace StateAbusePattern
{
    public class RunningState : IState
    {
        public Stopwatch stopwatch; // private

        public RunningState(Stopwatch stopwatch)
        {
            this.stopwatch = stopwatch;
        }

        public void click()
        {
            stopwatch.currentState = new StoppedState(stopwatch);
            Console.WriteLine("Stopped");
        }
    }
}
