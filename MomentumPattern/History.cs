using System.Collections.Generic;
using System.Linq;

namespace MomentumPattern
{
    public class History
    {
        private List<EditorState> states = new List<EditorState>();

        public void push(EditorState state) => states.Add(state);

        public EditorState pop()
        {
            //var lastIndex = states.Count - 1;
            //var lastState = states[lastIndex];

            var lastState = states.Last();

            states.Remove(lastState);

            return lastState;
        }
    }
}
