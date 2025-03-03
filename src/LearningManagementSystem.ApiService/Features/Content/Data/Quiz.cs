namespace LearningManagementSystem.ApiService.Features.Content.Data;

public class Quiz
{
    public Guid Id { get; set; }
    public Guid ActivityId { get; set; }
    public Activity? Activity { get; set; }
    public List<QuizQuestion>? Questions { get; set; }
}