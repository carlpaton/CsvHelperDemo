using CsvHelper.Configuration;

namespace CsvHelperDemo
{
    public class CsvContentModel
    {
        public string User { get; set; }
        public string InternalId { get; set; }
        public string Activity { get; set; }
        public string ProjectName { get; set; }
        public string Date { get; set; }
        public string TimeSpentInHours { get; set; }
    }

    sealed class CsvContentModelDefinitionMap : CsvClassMap<CsvContentModel>
    {
        public CsvContentModelDefinitionMap()
        {
            Map(m => m.TimeSpentInHours).Name("Time Spent In Hours");
            Map(m => m.User).Name("User");
            Map(m => m.InternalId).Name("Internal Id");
            Map(m => m.ProjectName).Name("Project Name");
            Map(m => m.Date).Name("Date");
            Map(m => m.Activity).Name("Activity");
        }
    }
}
