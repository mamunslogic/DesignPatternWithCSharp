
    //As per the definition of Factory Design Pattern, 
    //1. the Factory Design Pattern creates an object without exposing the object creation logic to the client, 
    //2. and the client refers to the newly created object using a common interface.


using FactoryDesignPattern;

var emailNotificationSender = NotificationFactory.GetNotificationSender(NotificationSenderType.Email);
emailNotificationSender.SendNotification("This is an email notification.");

var smsNotificationSender = NotificationFactory.GetNotificationSender(NotificationSenderType.SMS);
smsNotificationSender.SendNotification("This is a sms notification.");

var pushNotificationSender = NotificationFactory.GetNotificationSender(NotificationSenderType.PushNotification);
pushNotificationSender.SendNotification("This is a push notification.");

Console.ReadLine();