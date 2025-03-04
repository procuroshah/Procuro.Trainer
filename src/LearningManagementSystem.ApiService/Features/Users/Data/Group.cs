namespace LearningManagementSystem.ApiService.Features.Users.Data;

public class Group : AuditableEntity
{
    public string Name { get; set; } = null!;
    public ICollection<UserGroup>? UserGroups { get; set; }
    public ICollection<GroupLearningPath>? GroupLearningPaths { get; set; }
}