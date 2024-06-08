using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalConsoleApp
{
    using System;

    class Program
    {
        static LinkedList toDoList = new LinkedList();

        static void Main(string[] args)
        {
            string command = string.Empty;
            while (command != "exit")
            {
                Console.WriteLine("Enter a command (add, remove, print, complete, edit, clear, exit): ");
                command = Console.ReadLine();

                switch (command)
                {
                    case "add":
                        AddTask();
                        break;
                    case "remove":
                        RemoveTask();
                        break;
                    case "print":
                        PrintAllTasks();
                        break;
                    case "complete":
                        MarkTaskAsCompleted();
                        break;
                    case "edit":
                        EditTaskDescription();
                        break;
                    case "clear":
                        ClearAllTasks();
                        break;
                    case "exit":
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Unknown command. Try again.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.WriteLine("Enter the task description: ");
            string task = Console.ReadLine();
            toDoList.AddTask(task);
            Console.WriteLine("Task added.");
        }

        static void RemoveTask()
        {
            Console.WriteLine("Enter the task description to remove: ");
            string task = Console.ReadLine();
            if (toDoList.RemoveTask(task))
            {
                Console.WriteLine("Task removed.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        static void PrintAllTasks()
        {
            toDoList.PrintAllTasks();
        }

        static void MarkTaskAsCompleted()
        {
            Console.WriteLine("Enter the task description to mark as completed: ");
            string task = Console.ReadLine();
            if (toDoList.MarkTaskAsCompleted(task))
            {
                Console.WriteLine("Task marked as completed.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        static void EditTaskDescription()
        {
            Console.WriteLine("Enter the task description to edit: ");
            string oldTask = Console.ReadLine();
            Console.WriteLine("Enter the new task description: ");
            string newTask = Console.ReadLine();
            if (toDoList.EditTaskDescription(oldTask, newTask))
            {
                Console.WriteLine("Task edited.");
            }
            else
            {
                Console.WriteLine("Task not found.");
            }
        }

        static void ClearAllTasks()
        {
            toDoList.ClearTasks();
            Console.WriteLine("All tasks cleared.");
        }
    }

}
