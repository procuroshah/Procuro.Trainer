using System.ComponentModel.DataAnnotations;

namespace LearningManagementSystem.ApiService.Features.Content.Data;

public class LearningPath : AuditableEntity
{
    [MaxLength(150)]
    public string Title { get; set; } = null!;
    public List<LearningPathCourse>? LearningPathCourses { get; set; }
}