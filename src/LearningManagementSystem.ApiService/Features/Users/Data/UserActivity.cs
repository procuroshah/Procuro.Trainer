using LearningManagementSystem.ApiService.Features.Content.Data;

namespace LearningManagementSystem.ApiService.Features.Users.Data;

public class UserActivity : AuditableEntity<int>
{
    public Guid UserId { get; set; }
    public Guid LearningPathId { get; set; }
    public Guid ActivityId { get; set; }
    public UserActivityStatusEnum Status { get; set; }
    public LearningPath? LearningPath { get; set; }
    public Activity? Activity { get; set; }
}

public enum UserActivityStatusEnum
{
    NotStarted = 0,
    InProgress = 1,
    Completed = 2
}