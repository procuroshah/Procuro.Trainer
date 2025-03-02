namespace Procuro.Trainer.Api.Features.Content.Data;

public class Section
{
    public Guid Id { get; set; }
    public Guid CourseId { get; set; }
    public string Title { get; set; } = null!;
    public int Seq { get; set; }
    public List<Activity>? Activities { get; set; }
    public Course? Course { get; set; }
}