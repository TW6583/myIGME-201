using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    internal class Program
    {
    public class Stack
        {
            public List<int> pseudoStack = new List<int>();

            public void Push(int n)
            {
                pseudoStack.Add(n);
                Console.WriteLine("Pushed: " + n);
            }

            public void Pop()
            {
                pseudoStack.Remove(pseudoStack.Count);
                Console.WriteLine("Popped");
            }

            public void Peek()
            {
                Console.WriteLine(pseudoStack[pseudoStack.Count - 1]);
            }
        }
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.Pop();

            stack.Peek();

        }
    }
}
