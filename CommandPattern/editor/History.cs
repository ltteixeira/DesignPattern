using System.Collections.Generic;
using System.Linq;

namespace CommandPattern.editor
{
    public class History
    {
        private List<IUndoableCommand> commands = new List<IUndoableCommand>();  

        public void push(IUndoableCommand command) => commands.Add(command);

        public IUndoableCommand pop()
        {
            var lastCommand = commands.Last();

            commands.Remove(lastCommand);

            return lastCommand;
        }

        public int size() => commands.Count();
    }
}
