
using TodoApp;

var todo = new Todo();

Operations.DisplayWelcomeMessage();

var optionsList = new[] { "S", "A", "R", "E" };

bool isOptionInList;
do
{
  Operations.DisplayOptions();
  var userInput = Console.ReadLine();

  isOptionInList = optionsList.Contains(userInput!.ToUpper());

  if (userInput.ToUpper() == "S")
  {
    todo.DisplayTodoItems();
  }

  if (userInput.ToUpper() == "A")
  {
    bool canItemBeAdded;
    do
    {
      System.Console.WriteLine("Enter a TODO description: ");
      var userTodoItem = Console.ReadLine();

      if (string.IsNullOrEmpty(userTodoItem))
      {
        Console.WriteLine("Description cannot be empty");
        break;
      }

      if (todo.TodoItems.Contains(userTodoItem))
      {
        System.Console.WriteLine("Todo description must be unique");
        break;
      }

      todo.AddTodoItem(userTodoItem);
      canItemBeAdded = true;

    } while (canItemBeAdded);
  }

  Console.WriteLine("Invalid choice");
} while (!isOptionInList);

System.Console.WriteLine("finish");