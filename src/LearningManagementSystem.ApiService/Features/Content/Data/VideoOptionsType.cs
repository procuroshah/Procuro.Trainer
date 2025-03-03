namespace LearningManagementSystem.ApiService.Features.Content.Data;

public class VideoOptionsType
{
    public Guid ActivityId { get; set; }
    public Guid? MediaId { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public bool AutoPlay { get; set; }
    public bool MaximizeContent { get; set; }
    public bool AllowFullscreen { get; set; }
    public Media? Media { get; set; }
}