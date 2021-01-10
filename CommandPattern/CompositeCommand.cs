using CommandPattern.fx;
using System.Collections.Generic;

namespace CommandPattern
{
    public class CompositeCommand : ICommand
    {
        private List<ICommand> _commands { get; set; } = new List<ICommand>();

        public void add(ICommand command) => _commands.Add(command);

        public void execute()
        {
            foreach (var command in _commands)
                command.execute();
        }
    }
}
