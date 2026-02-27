using DMS.Web.Data.DataModels;
using System.Xml.Linq;
using System.Xml.XPath;

namespace DMS.Web.Data
{
    public class RiskMatrixData
    {

        public List<HealthQuestion> Questions { get; private set; }
        public List<ScoringRange> ScoringRanges { get; private set; }

        public RiskMatrixData(string xmlPath)
        {
            XDocument doc = XDocument.Load(xmlPath);

            Questions = doc.XPathSelectElements("//Question")
                           .Select(q => new HealthQuestion
                           {
                               Id = (int)q.Attribute("id"),
                               Text = (string)q.Element("Text"),
                               RiskValue = (int)q.Element("RiskValue"),
                               Rationale = (string)q.Element("Rationale"),
                               AnswerYes = false
                           })
                           .ToList();

            ScoringRanges = doc.XPathSelectElements("//Range")
                               .Select(r => new ScoringRange
                               {
                                   Min = (int)r.Attribute("min"),
                                   Max = (int)r.Attribute("max"),
                                   Result = (string)r.Attribute("result"),
                                   BackgroundColor = (string)r.Attribute("backgroundColor"),
                                   ForegroundColor = (string)r.Attribute("foregroundColor")
                               })
                               .ToList();

        }
    }
}