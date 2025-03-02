namespace Procuro.Trainer.Api.Features.Content.Data;

public class LearningPathCourse
{
    public Guid LearningPathId { get; set; }
    public Guid CourseId { get; set; }
    public int Seq { get; set; }
    public LearningPath? LearningPath { get; set; }
    public Course? Course { get; set; }
}