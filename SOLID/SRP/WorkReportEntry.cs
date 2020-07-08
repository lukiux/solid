using System;
namespace SOLID.SRP
{
    public class WorkReportEntry
    {
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }
        public int SpentHours { get; set; }

        public WorkReportEntry()
        {
        }
    }
}
