class TaskManager
{

    public static List<string?> todos = new List<string?>();
    
    public static void AddTodo(string? todo)
    {
        todos.Add(todo);
    }

    public static void PrintTodos()
    {
        foreach (var todo in todos)
        {
            Console.WriteLine(todo);
        }
    }    
}