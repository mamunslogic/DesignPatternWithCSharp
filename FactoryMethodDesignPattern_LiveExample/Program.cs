using FactoryMethodDesignPattern_LiveExample.Client;
using FactoryMethodDesignPattern_LiveExample.ConcreteCreator;

var notificationManager = new NotificationManager();
notificationManager.NotifyUser(new EmailNotifierCreator(), "Welcome");
notificationManager.NotifyUser(new SMSNotifierCreator(), "Welcome");
notificationManager.NotifyUser(new PushNotifierCreator(), "Welcome");

//var emailNotifier = new EmailNotifier();
//emailNotifier.SendNotification("Welcome");