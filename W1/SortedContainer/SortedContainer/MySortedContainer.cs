using System;
using System.Collections.Generic;
using System.Text;

namespace SortedContainer
{
    internal class MySortedContainer
    {
        private int[] array;
        private int size = 0;
        private int capacity;

        public MySortedContainer(int capacity)
        {
            this.capacity = capacity;
            array = new int[capacity];
            Console.WriteLine("Container Created with Capacity {0}. ", capacity);
            PrintArray();
        }

        public Boolean isFull()
        {
            return size == capacity;
        }

        public Boolean isEmpty()
        {
            return size == 0;
        }


        public int Insert(int value)
        {
            if (isFull()){
                return -1;
            }

            int i;
            for (i = size - 1; i >= 0; i--)
            {
                if (array[i] > value)
                {
                    array[i + 1] = array[i]; 
                }
                else
                {
                    break; // found the insert point
                }
            }
            array[i + 1] = value;
            size++;
            return 0;
        }

        // Searches for a value in the sorted array. Returns the index or -1 if not found.
        public int Search(int value)
        {
            for (int i = 0; i < size; i++)
            {
                if (array[i] == value)
                {
                    Console.WriteLine("Value {0} found at index {1}", value, i);
                    return i;
                }
            }
            Console.WriteLine("Value {0} not found in container.", value);
            return -1;
        }

        // Deletes a value from the sorted array.
        public bool Delete(int value)
        {
            int index = Search(value);
            if (index == -1)
            {
                Console.WriteLine("Failed to Delete.");
                return false;
            }

            // Shift elements to the left
            for (int i = index; i < size - 1; i++)
            {
                array[i] = array[i + 1];
            }

            size--;
            return true;
        }

        public void PrintArray()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
