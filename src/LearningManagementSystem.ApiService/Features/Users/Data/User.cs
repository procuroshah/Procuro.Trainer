namespace LearningManagementSystem.ApiService.Features.Users.Data;

public class User : AuditableEntity
{
    public string? Email { get; set; }
    public string? PasswordHash { get; set; }
    public UserTypeEnum Role { get; set; } // "Admin" or "Learner"
    public string? ExternalUserId { get; set; }
    public bool IsActive { get; set; }
    public ICollection<UserGroup>? UserGroups { get; set; }
    public ICollection<UserActivity>? Activities { get; set; }
}

public enum UserTypeEnum
{
    Admin = 1,
    Learner = 2
}