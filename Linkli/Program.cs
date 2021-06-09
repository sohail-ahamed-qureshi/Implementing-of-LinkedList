using System;

namespace Linkli
{
    class Program
    {
        /// <summary>
        /// UC5-Ablitity to Search for an element in the list.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Linked list program");
            Linkedli list = new Linkedli();
            list.Insert(56);
            list.Insert(30);
            list.Insert(70);
            Console.WriteLine("List elements");
            list.Show();
            int index = list.Search(30);
            list.InsertAt(index + 1, 40);
            Console.WriteLine("Unordered List elements");
            list.Show();
            list.SortList();
            Console.WriteLine("Ordered List elements");
            list.Show();
        }
    }
}
