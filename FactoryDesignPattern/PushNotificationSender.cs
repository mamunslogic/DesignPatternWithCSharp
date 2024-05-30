namespace FactoryDesignPattern
{
    public class PushNotificationSender : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Push Notification: {message}");
        }
    }
}
