using CommandPattern.fx;
using System;

namespace CommandPattern
{
    public class ResizeCommand : ICommand
    {
        public void execute() => Console.WriteLine("Resize");
    }
}
