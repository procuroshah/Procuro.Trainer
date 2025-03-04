using LearningManagementSystem.ApiService.Features.Content.Data;

namespace LearningManagementSystem.ApiService.Features.Users.Data;

public class GroupLearningPath : AuditableEntity<int>
{
    public Guid GroupId { get; set; }
    public Guid LearningPathId { get; set; }

    public Group? Group { get; set; }
    public LearningPath? LearningPath { get; set; }
}