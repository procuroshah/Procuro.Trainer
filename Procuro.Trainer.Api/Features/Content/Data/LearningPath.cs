namespace Procuro.Trainer.Api.Features.Content.Data;

public class LearningPath
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public List<LearningPathCourse>? LearningPathCourses { get; set; }
}