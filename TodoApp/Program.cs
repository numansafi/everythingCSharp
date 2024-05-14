using TodoApp;

public class Program
{
  public static void Main(string[] args)
  {
    var todo = new Todo();

    Display.WelcomeMessage();

    var options = new[] { "S", "A", "R", "E" };
    string userInput;
    bool isOptionValid;

    do
    {
      Display.Options();
      userInput = Console.ReadLine()!.ToUpper();
      isOptionValid = options.Contains(userInput);

      if (!isOptionValid) continue;

      if (userInput == "S")
      {
        todo.DisplayTodoItems();
      }

      if (userInput == "A")
      {
        Console.WriteLine("Enter a TODO description:");
        var userTodoDescription = Console.ReadLine();

        if (userTodoDescription == string.Empty)
        {
          Console.WriteLine("Description cannot be empty");
          continue;
        }

        if (todo.TodoItems.Contains(userTodoDescription!))
        {
          Console.WriteLine("Description must be unique");
          continue;
        }

        todo.TodoItems.Add(userTodoDescription!);

      }

      if (userInput == "R")
      {
        Console.WriteLine("Select the index of the TODO item you want to remove");
        todo.DisplayTodoItems();
        var userIndex = Console.ReadLine();

        if (userIndex == string.Empty)
        {
          Console.WriteLine("index cannot be empty");
          continue;
        }

        if (!isIndexValid(todo, userIndex!, out int index))
        {
          Console.WriteLine("The given index is invalid");
          continue;
        }
        
        todo.RemoveTodoItem(index!);
      }

    } while (userInput != "E");
  }

  private static bool isIndexValid(Todo todo, string indexFromUser, out int index)
  {
    var isNumber = int.TryParse(indexFromUser, out index);

    if (!isNumber || index <= 0 || index > todo.TodoItems.Count) return false;

    return true;
  }
}