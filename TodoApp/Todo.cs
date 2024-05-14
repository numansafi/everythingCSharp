namespace TodoApp;

public class Todo
{
    public List<string> TodoItems { get; set; }

    public Todo()
    {
        TodoItems = new List<string>();
    }

    public void AddTodoItem(string todoItem)
    {
        TodoItems.Add(todoItem);
    }

    public void RemoveTodoItem(int index)
    {
        Console.WriteLine($"Todo item removed: {TodoItems[index - 1]}");
        TodoItems.RemoveAt(index - 1);
    }

    public void DisplayTodoItems()
    {
        for (int i = 0; i < TodoItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}: {TodoItems[i]}");
        }
    }

    private bool isIndexValid(string indexFromUser, out int index)
    {
        var isNumber = int.TryParse(indexFromUser, out index);

        if (!isNumber || index <= 0 || index > TodoItems.Count) return false;

        return true;
    }
}
