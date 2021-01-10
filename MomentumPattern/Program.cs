using System;

namespace MomentumPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.content = "a";
            history.push(editor.createState());

            editor.content = "b";
            history.push(editor.createState());

            editor.content = "c";

            Console.WriteLine(editor.content);

            editor.restore(history.pop());

            Console.WriteLine(editor.content);

            editor.restore(history.pop());

            Console.WriteLine(editor.content);

            Console.ReadKey();
        }
    }
}
