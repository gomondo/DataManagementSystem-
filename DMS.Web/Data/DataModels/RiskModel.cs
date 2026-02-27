namespace DMS.Web.Data.DataModels
{
    public class RiskModel
    {
        public long TotalRiskScore { get; set; }
        public string RiskStatus { get; set; }
        public List<HealthQuestion> Questions { get; set; }
        public List<ScoringRange> ScoringRanges { get; set; }      
    }
}
