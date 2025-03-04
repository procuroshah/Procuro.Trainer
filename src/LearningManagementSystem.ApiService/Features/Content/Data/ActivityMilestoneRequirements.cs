namespace LearningManagementSystem.ApiService.Features.Content.Data;

public class ActivityMilestoneRequirements : AuditableEntity<int>
{
    public Guid ActivityId { get; set; }
    public RequirementTypeEnum RequirementType { get; set; }
    public ICollection<MilestoneProp>? MilestoneProps { get; set; }

    public class MilestoneProp
    {
        public int MinimumPct { get; set; }
        public Guid? MediaId { get; set; }
        public Media? Media { get; set; }
    }
}