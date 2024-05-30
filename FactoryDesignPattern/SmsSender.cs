namespace FactoryDesignPattern
{
    public class SmsSender : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"SMS: {message}");
        }
    }
}
