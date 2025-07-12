// See https://aka.ms/new-console-template for more information


class TodoApp
{
    static void Main()
    {
        Console.WriteLine("Din TodoList");

        while (true)
        {
            Console.WriteLine("Use command add/list/exit");
            string? command = Console.ReadLine();

            if (command == "add")
            {
                Console.WriteLine("Enter in your new Todo");
                string? todo = Console.ReadLine();
                TaskManager.AddTodo(todo);
               Console.WriteLine("Todo has been added!");
            }
            else if (command == "list")
            {
                TaskManager.PrintTodos();
            }
            else if (command == "exit")
            {
                Console.WriteLine("Closing Todo");
                break;
            } 
            else
            {
                Console.WriteLine("Uknown command.");
            }
        }
    }
}