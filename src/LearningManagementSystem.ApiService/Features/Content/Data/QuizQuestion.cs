using System.ComponentModel.DataAnnotations;

namespace LearningManagementSystem.ApiService.Features.Content.Data;

public class QuizQuestion : AuditableEntity
{
    public Guid QuizId { get; set; }
    [MaxLength(250)]
    public string QuestionText { get; set; } = null!; // HTML content
    public List<QuizOption>? Options { get; set; }
    public Quiz? Quiz { get; set; }
}