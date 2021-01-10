using System;

namespace StateAbusePattern
{
    public class StoppedState : IState
    {
        public Stopwatch stopwatch; // private

        public StoppedState(Stopwatch stopwatch)
        {
            this.stopwatch = stopwatch;
        }

        public void click()
        {
            stopwatch.currentState = new RunningState(stopwatch);
            Console.WriteLine("Running");
        }
    }
}
