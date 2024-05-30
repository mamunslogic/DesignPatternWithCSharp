namespace FactoryDesignPattern
{
    public class NotificationFactory
    {
        public static INotificationSender GetNotificationSender(NotificationSenderType senderType)
        {
            switch (senderType)
            {
                case NotificationSenderType.Email:
                    return new EmailSender();
                case NotificationSenderType.SMS:
                    return new SmsSender();
                case NotificationSenderType.PushNotification:
                    return new PushNotificationSender();
                default:
                    throw new ArgumentException("Invalid notification sender type");
            }
        }
    }

    public enum NotificationSenderType
    {
        Email,
        SMS,
        PushNotification
    }
}
