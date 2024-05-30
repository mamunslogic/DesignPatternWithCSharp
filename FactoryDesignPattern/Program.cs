using FactoryDesignPattern;

var emailNotificationSender = NotificationFactory.GetNotificationSender(NotificationSenderType.Email);
emailNotificationSender.SendNotification("This is an email notification.");

var smsNotificationSender = NotificationFactory.GetNotificationSender(NotificationSenderType.SMS);
smsNotificationSender.SendNotification("This is a sms notification.");

var pushNotificationSender = NotificationFactory.GetNotificationSender(NotificationSenderType.PushNotification);
pushNotificationSender.SendNotification("This is a push notification.");

Console.ReadLine();