using LearningManagementSystem.Web.Shared.Notifications;

namespace LearningManagementSystem.Web.Infrastructure.Notifications;

public record ConnectionStateChanged(ConnectionState State, string? Message) : INotificationMessage;