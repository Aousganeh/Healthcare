using Healthcare.Domain.Entities.Common;
using Healthcare.Domain.Enums;

namespace Healthcare.Domain.Entities;

public class Allergy : BaseEntity
{
    public string Name { get; set; }
    public string Substances { get; set; }
    public string Notes { get; set; }
    
    public Symptom ReactionSymptoms { get; set; }
    
    public AllergyType Type { get; set; }
    public AllergySeverity Severity { get; set; }
    public RiskLevel RiskLevel { get; set; }
}