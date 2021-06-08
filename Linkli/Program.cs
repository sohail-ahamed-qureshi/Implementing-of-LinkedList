using System;

namespace Linkli
{
    class Program
    {
        /// <summary>
        /// main program.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Linked list program");
            Linkedli list = new Linkedli();
            list.Insert(12);
            list.Insert(20);
            list.Insert(30);
            list.Insert(11);
            list.InsertAtStart(25);
            list.InsertAt(2, 33);
            list.Show();

        }
    }
}
