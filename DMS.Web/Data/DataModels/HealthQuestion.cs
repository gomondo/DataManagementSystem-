namespace DMS.Web.Data.DataModels
{
    public class HealthQuestion
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int RiskValue { get; set; } // from XML
        public string Rationale { get; set; } // new field
        public bool AnswerYes { get; set; } // user input
    }
}
