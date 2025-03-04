namespace LearningManagementSystem.ApiService.Features.Content.Data;

public class LearningPathCourse : AuditableEntity<int>
{
    public Guid LearningPathId { get; set; }
    public Guid CourseId { get; set; }
    public int Seq { get; set; }
    public LearningPath? LearningPath { get; set; }
    public Course? Course { get; set; }
}