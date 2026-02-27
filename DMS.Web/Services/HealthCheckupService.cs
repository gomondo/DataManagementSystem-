using DMS.Web.Data.DataModels;

namespace DMS.Web.Services
{
    public class HealthCheckupService
    {
        
        public async Task<RiskModel> CalculateHealthMatrix(IList<HealthQuestion> questions)
        { 
                // Extract data
                var extractor = new ("HealthRiskMatrix.xml");

                // Simulate user answers
                extractor.Questions.First(q => q.Id == 1).AnswerYes = true; // Over 45
                extractor.Questions.First(q => q.Id == 4).AnswerYes = true; // Sleep < 6h
                extractor.Questions.First(q => q.Id == 7).AnswerYes = true; // Family history

                // Calculate
                var calculator = new HealthRiskCalculator(extractor.Questions, extractor.ScoringRanges);
                int totalRisk = calculator.CalculateTotalRisk();
                string status = calculator.DetermineHealthStatus();

                // Output
                Console.WriteLine($"Total Risk Score: {totalRisk}");
                Console.WriteLine($"Health Status: {status}");
            }
        }
    }
}
