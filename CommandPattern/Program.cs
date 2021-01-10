using CommandPattern.editor;
using CommandPattern.fx;
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //var service = new CustomerService();
            //var command = new AddCustomerCommand(service);
            //var button = new Button(command);

            //button.click();


            // COMPOSITE

            //var composite = new CompositeCommand();
            //composite.add(new ResizeCommand());
            //composite.add(new BlackAndWhiteCommand());
            //composite.execute();


            // UNDO MECHANISM

            var history = new History();
            var document = new HtmlDocument();
            document.content = "Hello World";

            var boldCommand = new BoldCommand(document, history);
            boldCommand.execute();

            Console.WriteLine(document.content);

            var undoCommand = new UndoCommand(history);
            undoCommand.execute();

            Console.WriteLine(document.content);

            Console.ReadKey();
        }
    }
}
