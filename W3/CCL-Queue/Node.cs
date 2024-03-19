using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCL_Queue
{
    internal class Node
    {
        private Object data;
        private Node next;

        public Node(Object obj)
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

        public Node Next
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
    }
}
