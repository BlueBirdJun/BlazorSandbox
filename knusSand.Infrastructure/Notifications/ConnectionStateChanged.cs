using KnusSandbox.Shared.Notifications;

namespace knusSand.Infrastructure.Notifications;

public record ConnectionStateChanged(ConnectionState State, string? Message) : INotificationMessage;