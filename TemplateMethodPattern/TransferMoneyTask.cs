using System;

namespace TemplateMethodPattern
{
    public class TransferMoneyTask : Task
    {
        protected override void doExecute() => Console.WriteLine("Transfer Money");
    }
}
