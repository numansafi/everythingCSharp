namespace TodoApp;

public static class Display
{
  public static void WelcomeMessage()
  {
    Console.WriteLine("Hello There!");
  }

  public static void Options()
  {
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]ixt");
  }

}
 