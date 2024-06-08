using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinalConsoleApp
{
    public class LinkedList
    {
        private Node head;

        public LinkedList()
        {
            head = null;
        }

        public void AddTask(string task)
        {
            Node newNode = new Node(task);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public bool RemoveTask(string task)
        {
            if (head == null)
            {
                return false;
            }

            if (head.Task == task)
            {
                head = head.Next;
                return true;
            }

            Node current = head;
            while (current.Next != null && current.Next.Task != task)
            {
                current = current.Next;
            }

            if (current.Next == null)
            {
                return false;
            }

            current.Next = current.Next.Next;
            return true;
        }

        public void ClearTasks()
        {
            head = null;
        }

        public void PrintAllTasks()
        {
            Node current = head;
            while (current != null)
            {
                string status = current.IsCompleted ? "[Completed]" : "[Pending]";
                Console.WriteLine($"{current.Task} {status}");
                current = current.Next;
            }
        }

        public bool MarkTaskAsCompleted(string task)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Task == task)
                {
                    current.IsCompleted = true;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public bool EditTaskDescription(string oldTask, string newTask)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Task == oldTask)
                {
                    current.Task = newTask;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
    }

}
