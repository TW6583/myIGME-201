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
        static int[,] mGraph = new int[,]
        {
                            //Red     Blue     Yellow     Gray     Light Blue     Orange     Purple     Green
            /* Red */       {-1       ,1       ,-1        ,5       ,-1            ,-1        ,-1        ,-1},
            /* Blue */      {-1       ,-1      ,8         ,-1      ,1             ,-1        ,-1        ,-1},
            /* Yellow */    {-1       ,-1      ,-1        ,-1      ,-1            ,-1        ,-1        ,6 },
            /* Gray */      {-1       ,-1      ,-1        ,-1      ,0             ,1         ,-1        ,-1},
            /* Light Blue */{-1       ,1       ,-1        ,0       ,-1            ,-1        ,-1        ,-1},
            /* Orange */    {-1       ,-1      ,-1        ,-1      ,-1            ,-1        ,1         ,-1},
            /* Purple */    {-1       ,-1      , 1        ,0       ,-1            ,-1        ,-1        ,-1},
            /* Green */     {-1       ,-1      ,-1        ,-1      ,-1            ,-1        ,-1        ,-1},
        };

        static int[][] lGraph = new int[][]
        {
            /* Red */ new int[] {1, 5},
            /* Blue */ new int[] {8, 1},
            /* Yellow */ new int[] {6},
            /* Gray */ new int[] {0, 1},
            /* Light Blue */ new int[] {1, 0},
            /* Orange */ new int[] {1},
            /* Purple */ new int[] {1},
            /* Green */ null,
        };
    
        //Question 4

        static bool bWaitingForMove = false;
        static Object lockObject = new Object();
        static int nState = 0;
        static string sState;
        static string sUserState;

        static int SState2NState(string sState)
        {
            int nState = 0;

            for (int i = 0; i < 6; ++i)
            {
                if (sState[i] == 'R')
                {
                    nState += (1 << (2 - i));
                }
            }
            
            return nState;
        }

        static string NState2SState(int nState)
        {
            string r = null;

            for (int i = 0; i < 3; ++i)
            {
                if ((nState & (1 << (2 - i))) != 0)
                {
                    r += "Red";
                }
                else if ((nState & (1 << (2 - i))) != 1 && (nState & (1 << (2 - i))) != 0)
                {
                    r += "Blue";
                }
                else
                {
                    r += "Gray";
                }
            }

            return (r);
        }
        static void DFS()
        {
            bool[] visited = new bool[lGraph.Length];

            DFSUtil(nState, visited);
        }

        static void DFSUtil(int v, bool[] visited)
        {
            while (!bWaitingForMove) ;

            visited[v] = true;

            sUserState = NState2SState(v);

            lock (lockObject)
            {
                bWaitingForMove = false;
            }

            int[] thisStateList = lGraph[v];
            if (thisStateList != null)
            {
                foreach (int n in thisStateList)
                {
                    if (!visited[n])
                    {
                        DFSUtil(n, visited);
                    }
                }
            }
        }

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
