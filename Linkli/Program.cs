using System;

namespace Linkli
{
    class Program
    {
        /// <summary>
        /// main program.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.WriteLine("Linked list program");
            Linkedli list = new Linkedli();
            list.Insert(12);
            list.Insert(20);
            list.Insert(30);
            list.Insert(11);
            list.InsertAtStart(25);
            list.InsertAt(2, 33);
            Console.WriteLine("List elements");
            list.Show();
            list.DeleteAt(2);
            Console.WriteLine("After delete List elements");
            list.Show();
        }
    }
}
