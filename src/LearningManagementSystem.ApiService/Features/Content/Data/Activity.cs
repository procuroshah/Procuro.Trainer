using System.ComponentModel.DataAnnotations;

namespace LearningManagementSystem.ApiService.Features.Content.Data;

public class Activity : AuditableEntity
{
    public Guid SectionId { get; set; }
    [MaxLength(150)]
    public string Title { get; set; } = null!;
    [MaxLength(250)]
    public string? Description { get; set; } // HTML content
    public bool DescriptionEnabled { get; set; }
    public string? AdditionalInfo { get; set; } // HTML content
    public bool AdditionalInfoEnabled { get; set; }
    public ActivityTypeEnum Type { get; set; } // "Video", "Quiz", "Milestone"
    public Guid? MilestoneId { get; set; }
    public int Order { get; set; }
    public bool Enabled { get; set; }
    public ActivityVideoOptions? VideoOptions { get; set; }
    public ActivityQuizOptions? QuizOptions { get; set; }
    public ActivityMilestoneRequirements? MilestoneRequirements { get; set; }
    public Section? Section { get; set; }
    
}

public enum RequirementTypeEnum
{
    Video = 1,
    Quiz = 2
}

public enum ActivityTypeEnum
{
    Video = 1,
    Quiz = 2,
    Milestone = 3
}