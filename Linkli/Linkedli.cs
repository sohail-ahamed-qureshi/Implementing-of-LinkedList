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
        /// Insert at particular index
        /// </summary>
        /// <param name="index"></param>
        /// <param name="data"></param>
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
        /// display list
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
    }
}
