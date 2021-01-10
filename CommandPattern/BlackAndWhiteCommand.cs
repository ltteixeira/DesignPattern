using CommandPattern.fx;
using System;

namespace CommandPattern
{
    public class BlackAndWhiteCommand : ICommand
    {
        public void execute() => Console.WriteLine("Black and White");
    }
}
