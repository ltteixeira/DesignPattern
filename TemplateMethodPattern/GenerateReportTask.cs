using System;

namespace TemplateMethodPattern
{
    public class GenerateReportTask
    {
        private AuditTrail auditTrail;

        public GenerateReportTask(AuditTrail auditTrail)
        {
            this.auditTrail = auditTrail;
        }

        public void execute()
        {
            auditTrail.record();

            Console.WriteLine("Generate Report");
        }
    }
}
