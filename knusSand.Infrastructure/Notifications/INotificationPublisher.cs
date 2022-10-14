
using KnusSandbox.Shared.Notifications;

namespace knusSand.Infrastructure.Notifications;

public interface INotificationPublisher
{
    Task PublishAsync(INotificationMessage notification);
}