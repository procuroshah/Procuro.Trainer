namespace LearningManagementSystem.ApiService.Features.Content.Data;

public class ActivityQuizOptions : AuditableEntity<int>
{
    public Guid ActivityId { get; set; }
    public Guid? QuizId { get; set; }
    public bool AllowRetakes { get; set; }
    public int RetakeAmount { get; set; }
    public bool RetakeUnlimited { get; set; }
    public bool HideCorrectAnswers { get; set; }
    public int TimeLimitMinutes { get; set; }
    public Quiz? Quiz { get; set; }
    public Activity? Activity { get; set; }
}