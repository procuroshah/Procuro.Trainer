using System.ComponentModel.DataAnnotations;

namespace LearningManagementSystem.ApiService.Features.Content.Data;

public class Section : AuditableEntity
{
    public Guid CourseId { get; set; }
    [MaxLength(150)]
    public string Title { get; set; } = null!;
    public int Seq { get; set; }
    public List<Activity>? Activities { get; set; }
    public Course? Course { get; set; }
}