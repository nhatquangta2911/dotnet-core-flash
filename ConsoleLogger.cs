namespace VeryFirstNamespace
{
   public class ConsoleLogger : ILogger
   {
      public void LogError(string message)
      {
          System.Console.ForegroundColor = System.ConsoleColor.Magenta;
          System.Console.WriteLine(message);
      }

      public void LogInfo(string message)
      {
          System.Console.ForegroundColor = System.ConsoleColor.Cyan;
          System.Console.WriteLine(message);
      }
   }
}