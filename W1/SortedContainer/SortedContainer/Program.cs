using System;

namespace SortedContainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MySortedContainer container = new MySortedContainer(5);
            container.Insert(1);
            container.Insert(15);
            container.Insert(4);
            container.Insert(9);
            container.PrintArray();
            container.Search(4);
            container.Search(5);
            container.Delete(4);
            container.Delete(22);
            container.PrintArray();
            container.Delete(15);
            container.Delete(1);
            container.PrintArray();

        }
    }
}
