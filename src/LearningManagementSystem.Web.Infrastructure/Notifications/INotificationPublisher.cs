using LearningManagementSystem.Web.Shared.Notifications;

namespace LearningManagementSystem.Web.Infrastructure.Notifications;

public interface INotificationPublisher
{
    Task PublishAsync(INotificationMessage notification);
}