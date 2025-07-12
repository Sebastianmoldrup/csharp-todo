// See https://aka.ms/new-console-template for more information

// Version 1
// class TodoApp
// {
//     static void Main()
//     {
//         Console.WriteLine("Din TodoList");

//         while (true)
//         {
//             Console.WriteLine("Use command add/list/exit");
//             string? command = Console.ReadLine();

//             if (command == "add")
//             {
//                 Console.WriteLine("Enter in your new Todo");
//                 string? todo = Console.ReadLine();
//                 TaskManager.AddTodo(todo);
//                Console.WriteLine("Todo has been added!");
//             }
//             else if (command == "list")
//             {
//                 TaskManager.PrintTodos();
//             }
//             else if (command == "exit")
//             {
//                 Console.WriteLine("Closing Todo");
//                 break;
//             } 
//             else
//             {
//                 Console.WriteLine("Uknown command.");
//             }
//         }
//     }
// }

// Version 2
class TodoApp
{
    static void Main()
    {
        Console.WriteLine("Initialized Todo App");
        Console.WriteLine("type 'help' for commands"); 

        while (true)
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input)) return;
            string[] parts = input.Split(' ', 2); // Split command + argument
            string cmd = parts[0];
            string arg = parts.Length > 1 ? parts[1] : "";

            if (cmd == "help")
            {
                Console.WriteLine("Use these commands add/list/exit");
            }
            else if (cmd == "add")
            {
                if (string.IsNullOrWhiteSpace(arg))
                {
                    Console.WriteLine("Provide a todo after the add cmd");
                    continue;
                }

                TaskManager.AddTodo(arg);
                Console.WriteLine($"added {arg}");
            }
            else if (cmd == "list")
            {
                Console.WriteLine("Your todos:");
                TaskManager.PrintTodos();
            }
            else if (cmd == "exit")
            {
                Console.WriteLine("Exiting Todo");
                break;
            }
            else
            {
                Console.WriteLine($"Uknown cmd: {cmd}");
            }
        }
    }
}