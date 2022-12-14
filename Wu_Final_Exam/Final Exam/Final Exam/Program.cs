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


        public class Queue
        {
            public List<int> pseudoQueue = new List<int>();

            public void Enqueue(int n)
            {
                pseudoQueue.Insert(pseudoQueue.Count, n);
                Console.WriteLine("Enqueued: " + n);
            }

            public void Dequeue()
            {
                pseudoQueue.Remove(pseudoQueue[0]);
            }

            public void Peek()
            {
                Console.WriteLine(pseudoQueue[0]);
            }

        }

        //Quesstion 3
        static bool[,] mGraph = new bool[,]
        {
                            //Red     Blue     Yellow     Gray     Light Blue     Orange     Purple     Green
            /* Red */       {false    ,true    ,false     ,true    ,false         ,false     ,false     ,false},
            /* Blue */      {false    ,false   ,true      ,false   ,true          ,false     ,false     ,false},
            /* Yellow */    {false    ,false   ,false     ,false   ,false         ,false     ,false     ,true },
            /* Gray */      {false    ,false   ,false     ,false   ,true          ,true      ,false     ,false},
            /* Light Blue */{false    ,true    ,false     ,true    ,false         ,false     ,false     ,false},
            /* Orange */    {false    ,false   ,false     ,false   ,false         ,false     ,true      ,false},
            /* Purple */    {false    ,false   ,true      ,false   ,false         ,false     ,false     ,false},
            /* Green */     {false    ,false   ,false     ,false   ,false         ,false     ,false     ,false},
        };

        static int[][] lGraph = new int[][]
        {
            /* Red */ new int[] {1, 3},
            /* Blue */ new int[] {2, 4},
            /* Yellow */ new int[] {7},
            /* Gray */ new int[] {4, 5},
            /* Light Blue */ new int[] {1, 3},
            /* Orange */ new int[] {6},
            /* Purple */ new int[] {2},
            /* Green */ null,
        };

        static void Main(string[] args)
        {

            //Stack
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.Pop();

            stack.Peek();

            //Queue
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            queue.Dequeue();

            queue.Peek();

        }
    }
}
