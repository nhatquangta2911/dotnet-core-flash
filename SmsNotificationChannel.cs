namespace VeryFirstNamespace
{
   public class SmsNotificationChannel : INotificationChannel
   {
      public void Send(Message message)
      {
          System.Console.WriteLine("Sending SMS...");
      }
   }
}