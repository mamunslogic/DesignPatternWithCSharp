namespace FactoryDesignPattern
{
    public class EmailSender : INotificationSender
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }
}
