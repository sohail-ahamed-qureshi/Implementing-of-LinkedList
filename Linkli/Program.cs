using System;

namespace Linkli
{
    class Program
    {
        /// <summary>
        /// UC1- Linked list with 56,30,70
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
            list.Show();;
        }
    }
}
