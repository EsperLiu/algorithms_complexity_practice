//CAB301 - Workshop 3
//Maolin Tang
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class ListNode
    {
        private Object data;
        private ListNode next;

        public ListNode(Object obj)
        {
            data = obj;
            next = null;
        }

        public Object Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        public ListNode Next
        {
            get
            {
                return next;
            }
            set
            {
                next = value;
            }
        }
    }  // enf of ListNode

    public class CircularQueue : IQueue
    {
        private int capacity = Int32.MaxValue;
        private int count = 0;
        private ListNode tail = null;

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
                ListNode aNode = new ListNode(item);
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
