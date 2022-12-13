using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Class
{
    public class Stack
    {
        public List<int> pseudoStack;

        public void Push(int n)
        {
            pseudoStack.Add(n);
        }

        public void Pop()
        {
            pseudoStack.Remove(pseudoStack.Count);
        }

        public void Peek()
        {
            Console.WriteLine(pseudoStack.IndexOf(pseudoStack.Count));
        }
    }
}
