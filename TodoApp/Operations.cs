namespace TodoApp;

public static class Operations
{
  public static void DisplayWelcomeMessage()
  {
    Console.WriteLine("Hello There!");
  }

  public static void DisplayOptions()
  {
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]ixt");
  }

}
 