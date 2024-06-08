using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace FinalConsoleApp
{
    public class Node
    {
        public string Task { get; set; }
        public bool IsCompleted { get; set; }
        public Node Next { get; set; }

        public Node(string task)
        {
            Task = task;
            IsCompleted = false;
            Next = null;
        }
    }
}
