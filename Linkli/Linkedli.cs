using System;
using System.Collections.Generic;
using System.Text;

namespace Linkli
{
    class Linkedli
    {
        Node head;
        /// <summary>
        /// indert data at the end
        /// </summary>
        /// <param name="data"></param>
        internal void Insert(int data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while (n.next != null)
                {
                    n = n.next;
                }
                n.next = node;
            }
        }
        /// <summary>
        /// Insert node at start.
        /// </summary>
        /// <param name="data"></param>
        internal void InsertAtStart(int data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;

            node.next = head;
            head = node;
        }
        /// <summary>
        /// Insert elements at particular index
        /// </summary>
        /// <param name="index">memory location at which data to be inserted</param>
        /// <param name="data">actual data to be inserted</param>
        internal void InsertAt(int index, int data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;

            Node n = head;
            for (int i = 0; i < index - 1; i++)
            {
                n = n.next;
            }
            node.next = n.next;
            n.next = node;
        }
        /// <summary>
        /// print the list of elements
        /// </summary>
        internal void Show()
        {
            Node node = head;
            while (node.next != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
            Console.WriteLine(node.data);
        }
        /// <summary>
        /// delete the first element only
        /// </summary>
        internal void Pop()
        {
            head = head.next;
        }
        /// <summary>
        /// delete function at particular index
        /// </summary>
        /// <param name="index">memory location at which data has to be deleted</param>
        internal void DeleteAt(int index)
        {
            if (index == 0)
            {
                head = head.next;
            }
            else
            {
                Node n = head;
                // Node n1 = null;
                for (int i = 0; i < index - 1; i++)
                {
                    n = n.next;
                }
                // n1 = n.next;
                //n.next = n1.next;
                n.next = n.next.next;
            }
        }
        /// <summary>
        /// Ablitity to delete last item of list.
        /// </summary>
        internal void PopLast()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("No elements to delete");
            }
            if (head.next == null)
            {
                head = null;
            }
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
            }
        }
        /// <summary>
        /// check whether the list is empty and returns boolean value.
        /// </summary>
        /// <returns></returns>
        internal bool isEmpty()
        {
            if (head == null)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Ability to search for an element in the list
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        internal int Search(int data)
        {
            Node temp = head;
            int count = 0;
            while (temp != null) //check for middle elements in list
            {
                if (temp.data == data)
                {
                    Console.WriteLine($"{data} is present at {count} in list.");
                    return count;
                }
                count++;
                temp = temp.next;
            }
            Console.WriteLine($"{data} is not present in list.");
            return 0;
        }
        /// <summary>
        /// ability to find the length of the list.
        /// </summary>
        internal void Size()
        {
            Node temp = head;
            int count = 0;
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine($"size of list is {count}");
        }
        /// <summary>
        /// Ability to remove an element from the node 
        /// </summary>
        /// <param name="data"></param>
        internal void Remove(int data)
        {
            int index = Search(data);
            DeleteAt(index);
        }
    }
}

