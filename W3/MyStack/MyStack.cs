using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class MyStack
    {
        private int head = 0;
        private int[] ints;

        public MyStack(int size)
        {
            this.ints = new int[size];
        }

        public bool IsEmpty()
        {
            return head == 0;
        }

        public bool IsFull()
        {
            return head == ints.Length;
        }

        public int Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("The stack is already full. ");
                return -1;
            }

            ints[head] = value;

            head++;
            PrintStack();
            return 0;
        }
        public int Pop()
        {
            if (this.IsEmpty()){
                Console.WriteLine("The stack is already empty");
                return -1;
            }
            head--;
            PrintStack();
            return ints[head];
        }

        public int Peak()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("The stack is empty");
                return -1;
            }
            return ints[head - 1];
        }
        public int PrintStack()
        {
            if (this.IsEmpty())
            {
                Console.WriteLine("Nothing in the stack to print. ");
                return -1;
            }
            for (int i = head-1; i >=0 ; i--)
            {
                Console.Write(ints[i] + " ");
            }
            Console.WriteLine();
            return 0;
        }
    }
}
