namespace LearningManagementSystem.ApiService.Features.Content.Data;

public class QuizQuestion
{
    public Guid Id { get; set; }
    public Guid QuizId { get; set; }
    public string QuestionText { get; set; } = null!; // HTML content
    public List<QuizOption> Options { get; set; }
    public Quiz? Quiz { get; set; }
}