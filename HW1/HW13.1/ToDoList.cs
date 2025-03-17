using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW13._1
{
    internal class ToDoList
    {
        private List<string> tasks = new List<string>();
        private List<bool> isCompleted = new List<bool>();

        public void AddTask(string task)
        {
            tasks.Add(task);
            isCompleted.Add(false);
            Console.WriteLine("Task added successfully.");
        }

        public void ShowTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("There are no tasks.");
                return;
            }

            Console.WriteLine("\nTo-Do List:");
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = isCompleted[i] ? "[+]" : "[ ]";
                Console.WriteLine($"{i + 1}. {status} {tasks[i]}");
            }
        }

        public void CompleteTask(int index)
        {
            if (index >= 1 && index <= tasks.Count)
            {
                isCompleted[index - 1] = true;
                Console.WriteLine("Task marked as completed.");
            }
            else Console.WriteLine("Invalid task number.");
        }

        public void RemoveTask(int index)
        {
            if (index >= 1 && index <= tasks.Count)
            {
                tasks.RemoveAt(index - 1);
                isCompleted.RemoveAt(index - 1);
                Console.WriteLine("Task removed successfully.");
            }
            else Console.WriteLine("Invalid task number.");
        }
    }
}
