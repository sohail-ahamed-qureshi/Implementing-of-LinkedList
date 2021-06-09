using System;

namespace Linkli
{
    class Program
    {
        /// <summary>
        /// UC2-Ablitity to insert between 56 & 70 in the linked list
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Linked list program");
            Linkedli list = new Linkedli();
            list.Insert(56);
            list.Insert(70);
            Console.WriteLine("List elements");
            list.Show();
            list.InsertAt(1, 30);
            Console.WriteLine("List elements after inserting 30");
            list.Show();
        }
    }
}
