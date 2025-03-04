using System.ComponentModel.DataAnnotations;

namespace LearningManagementSystem.ApiService.Features.Content.Data;

public class QuizOption : AuditableEntity
{
    public Guid QuizQuestionId { get; set; }
    [MaxLength(150)]
    public string OptionText { get; set; } = null!;
    public bool IsCorrect { get; set; }
    public QuizQuestion? QuizQuestion { get; set; }
}