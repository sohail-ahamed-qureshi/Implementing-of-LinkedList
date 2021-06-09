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
        public void Insert(int data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;
            if(head == null)
            {
                head = node; 
            }
            else
            {
                Node n = head;
                while(n.next != null)
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
        public void InsertAtStart(int data)
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
        public void InsertAt(int index, int data)
        {
            Node node = new Node();
            node.data = data;
            node.next = null;

            Node n = head;
            for(int i=0; i < index-1; i++)
            {
                n = n.next;
            }
            node.next = n.next;
            n.next = node;
        }
        /// <summary>
        /// print the list of elements
        /// </summary>
        public void Show()
        {
            Node node = head;
            while(node.next != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
            Console.WriteLine(node.data);
        }
        /// <summary>
        /// delete the first element only
        /// </summary>
        public void Pop()
        {
            head = head.next;
        }
        /// <summary>
        /// delete function at particular index
        /// </summary>
        /// <param name="index">memory location at which data has to be deleted</param>
        public void DeleteAt(int index)
        {
            if(index == 0)
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
    }
}
