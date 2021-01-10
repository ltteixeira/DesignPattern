namespace StateAbusePattern
{
    public class Stopwatch
    {

        #region << SIMPLE METHOD >>

        //private bool isRunning;

        //public void click()
        //{
        //    if (isRunning)
        //    {
        //        isRunning = false;
        //        Console.WriteLine("Stopped");
        //    }
        //    else
        //    {
        //        isRunning = true;
        //        Console.WriteLine("Running");
        //    }
        //}

        #endregion


        #region << ABUSING PATTERN >>

        public IState currentState { get; set; } // private

        public Stopwatch()
        {
            currentState = new StoppedState(this);
        }

        public void click()
        {
            currentState.click();
        }


        #endregion

    }
}
