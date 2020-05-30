using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ProductivityTools.Learning.Google.A1.Structures
{
    class LinkedStackOfStrings
    {
        Node node = null;

        private class Node
        {
            public string Item { get; set; }
            public Node Next { get; set; }
        }

        public void Push(string item)
        {
            Node previousFirst = node;
            node = new Node();
            node.Item = item;
            node.Next = previousFirst;
        }

        public string Pop()
        {
            string r = node.Item;
            node = node.Next;
            return r;
        }

        public bool Empty()
        {
            return node == null;
        }

    }
}
