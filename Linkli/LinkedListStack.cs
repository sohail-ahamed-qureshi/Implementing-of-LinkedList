using System;
using System.Collections.Generic;
using System.Text;

namespace Linkli
{
    /// <summary>
    /// Stack node Object.
    /// </summary>
    class StNode 
    {
        public int data;
        public StNode next;
    }
    /// <summary>
    /// implementing stack operations using linked list.
    /// </summary>
    class LinkedListStack
    {
        //intializing top node.
        StNode top;

        //Stack operations - push(), pop(), peek(), isEmpty(), isFull();

        internal void push(int data)
        {
            StNode stnode = new StNode();
            stnode.data = data;
            stnode.next = null;

        }
    }
}
