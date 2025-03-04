namespace LearningManagementSystem.ApiService.Features.Content.Data;

public class Quiz : AuditableEntity
{
    public Guid ActivityId { get; set; }
    public List<QuizQuestion>? Questions { get; set; }
    public Activity? Activity { get; set; }
}