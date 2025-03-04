using LearningManagementSystem.ApiService.Features.Users.Data;
using System.ComponentModel.DataAnnotations;

namespace LearningManagementSystem.ApiService.Features.Content.Data;

public class Media : AuditableEntity
{
    [MaxLength(150)]
    public string Title { get; set; } = null!;
    [MaxLength(150)]
    public string FileName { get; set; } = null!;
    public FileTypeEnum FileType { get; set; } // "Video" or "Document"
    [MaxLength(250)]
    public string Url { get; set; } = null!;
    public Guid UploadedById { get; set; }
    public User? UploadedBy { get; set; }
}

public enum FileTypeEnum
{
    Video = 1,
    Document = 2
}