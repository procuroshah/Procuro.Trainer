using System.ComponentModel.DataAnnotations;

namespace LearningManagementSystem.ApiService.Features.Content.Data;

public class Course : AuditableEntity
{
    [MaxLength(150)]
    public string Title { get; set; } = null!;
    [MaxLength(250)]
    public string? Description { get; set; }
    [MaxLength(4000)]
    public string? FullDescription { get; set; }
    public ICollection<Section>? Sections { get; set; }
    public ICollection<LearningPathCourse>? LearningPathCourses { get; set; }
}