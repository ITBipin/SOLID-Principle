using static SOLID.SinglePrinciple;

SOLID.SinglePrinciple singlePrinciple = new SOLID.SinglePrinciple();
Notification notification = new Notification();
//EmailNotification emailNotification = new EmailNotification();
//emailNotification.Send("Hello via Email");
//SMSNotification sMSNotification = new SMSNotification();
//sMSNotification.Send("Hello via SMS");

NotificatioonCenter notificatioonCenter = new NotificatioonCenter();
notificatioonCenter.Email();
notificatioonCenter.SMS();