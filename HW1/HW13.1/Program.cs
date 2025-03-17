namespace HW13._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToDoList toDoList = new ToDoList();
            while (true)
            {
                Console.WriteLine("To-Do List Menu:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Show Tasks");
                Console.WriteLine("3. Complete Task");
                Console.WriteLine("4. Remove Task");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter task: ");
                        string task = Console.ReadLine();
                        toDoList.AddTask(task);
                        break;
                    case 2:
                        toDoList.ShowTasks();
                        break;
                    case 3:
                        Console.Write("Enter task number: ");
                        if (int.TryParse(Console.ReadLine(), out int completeIndex))
                        {
                            toDoList.CompleteTask(completeIndex);
                        }
                        else Console.WriteLine("Please enter valid number.");
                        break;
                    case 4:
                        Console.Write("Enter task number: ");
                        if (int.TryParse(Console.ReadLine(), out int removeIndex))
                        {
                            toDoList.RemoveTask(removeIndex);
                        }
                        else Console.WriteLine("Please enter valid number.");
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Please choose number between 1 and 5.");
                        break;
                }
            }
        }
    }
}
