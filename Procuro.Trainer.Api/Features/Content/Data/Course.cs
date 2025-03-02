using static System.Collections.Specialized.BitVector32;

namespace Procuro.Trainer.Api.Features.Content.Data;

public class Course
{
    public Guid Id { get; set; }
    public string Title { get; set; } = null!;
    public string? Description { get; set; }
    public List<Section>? Sections { get; set; }
}