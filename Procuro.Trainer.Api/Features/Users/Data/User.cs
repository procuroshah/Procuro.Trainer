namespace Procuro.Trainer.Api.Features.Users.Data;

public class User
{
    public Guid Id { get; set; }
    public string? Email { get; set; }
    public string? PasswordHash { get; set; }
    public UserTypeEnum Role { get; set; } // "Admin" or "Learner"
    public string? ExternalUserId { get; set; }
    public DateTime CreatedAt { get; set; }
}

public enum UserTypeEnum
{
    Admin = 1,
    Learner = 2
}