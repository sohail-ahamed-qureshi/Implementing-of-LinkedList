using System;

namespace Linkli
{
    class Program
    {
        /// <summary>
        /// UC3-Ablitity to delete first element from the list.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Linked list program");
            Linkedli list = new Linkedli();
            list.Insert(56);
            list.Insert(70);
            list.InsertAt(1, 30);
            Console.WriteLine("List elements");
            list.Show();
            list.PopLast();
            Console.WriteLine("List elements after popLast()");
            list.Show();

        }
    }
}
