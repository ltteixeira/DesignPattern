using System;

namespace TemplateMethodPattern
{
    public class AuditTrail
    {
        public void record() => Console.WriteLine("Audit");
    }
}
