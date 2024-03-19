using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCL_Queue
{
    internal class CircularLinkedList:IQueue
    {
        private int capacity = Int32.MaxValue;
        private int count = 0;
        private Node tail = null;

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsEmpty()
        {
            return count == 0;
        }


        public bool IsFull()
        {
            return count == capacity;
        }

        public void Enqueue(Object item)
        {
            // check the pre-condition
            if (!IsFull())
            {
                Node aNode = new Node(item);
                if (count == 0) //special case: the queue is empty
                {
                    tail = aNode;
                    tail.Next = tail;
                }
                else //general case
                {
                    aNode.Next = tail.Next;
                    tail.Next = aNode;
                    tail = aNode;
                }
                count++;
            }
        }

        public Object Dequeue()
        {
            // check the pre-condition
            if (!IsEmpty())
            {
                Object data;
                if (count == 1) //special case: the queue has only 1 item
                {
                    data = tail.Data;
                    tail = null;
                }
                else //general case
                {
                    data = tail.Next.Data;
                    tail.Next = tail.Next.Next;
                }
                count--;
                return data;
            }
            else
                return null;
        }

        public Object Head()
        {
            // check the pre-condition
            if (!IsEmpty())
            {
                Object data = tail.Next.Data;
                return data;
            }
            else
                return null;
        }

        public void Clear()
        {
            tail = null;
            count = 0;
        }
    }
}
