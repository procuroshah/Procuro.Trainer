using System.ComponentModel.DataAnnotations;

namespace LearningManagementSystem.ApiService.Common
{
    public interface ISoftDelete
    {
        DateTime? DeletedOnUtc { get; set; }
        [MaxLength(50)]
        string? DeletedBy { get; set; }
    }
}