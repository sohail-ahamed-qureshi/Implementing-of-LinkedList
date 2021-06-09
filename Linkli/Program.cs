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
            list.Insert(70);
            list.Insert(20);
            list.Insert(10);
            list.InsertAt(1, 30);
            Console.WriteLine("List elements");
            list.Show();
            list.Search(56);
            list.Search(30);
            list.Search(16);
        }
    }
}
