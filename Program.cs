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
            Console.WriteLine("Добавьте название проекта: ");
            string task = Console.ReadLine();
            toDoList.AddTask(task);
            Console.WriteLine("Проект добавлен.");
        }

        static void RemoveTask()
        {
            Console.WriteLine("Напишите название задания для удаления: ");
            string task = Console.ReadLine();
            if (toDoList.RemoveTask(task))
            {
                Console.WriteLine("Задание удалено.");
            }
            else
            {
                Console.WriteLine("Задание не найдено.");
            }
        }

        static void PrintAllTasks()
        {
            toDoList.PrintAllTasks();
        }

        static void MarkTaskAsCompleted()
        {
            Console.WriteLine("Напишите название задания для обозначения как выполнено: ");
            string task = Console.ReadLine();
            if (toDoList.MarkTaskAsCompleted(task))
            {
                Console.WriteLine("Задание обозначено выполненным.");
            }
            else
            {
                Console.WriteLine("Задание не найдено.");
            }
        }

        static void EditTaskDescription()
        {
            Console.WriteLine("Напишите название задания для изменения: ");
            string oldTask = Console.ReadLine();
            Console.WriteLine("Напишите новое название задания: ");
            string newTask = Console.ReadLine();
            if (toDoList.EditTaskDescription(oldTask, newTask))
            {
                Console.WriteLine("Задание изменено.");
            }
            else
            {
                Console.WriteLine("Задание не найдено.");
            }
        }

        static void ClearAllTasks()
        {
            toDoList.ClearTasks();
            Console.WriteLine("Лист очищен.");
        }
    }

}
