namespace LearningManagementSystem.ApiService.Features.Content.Data;

public class QuizOption
{
    public Guid Id { get; set; }
    public Guid QuizQuestionId { get; set; }
    public string OptionText { get; set; } = null!;
    public bool IsCorrect { get; set; }
    public QuizQuestion? QuizQuestion { get; set; }
}