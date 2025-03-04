namespace LearningManagementSystem.ApiService.Features.Users.Data;

public class UserGroup : AuditableEntity<int>
{
    public Guid UserId { get; set; }
    public Guid GroupId { get; set; }

    public User? User { get; set; }
    public Group? Group { get; set; }
}