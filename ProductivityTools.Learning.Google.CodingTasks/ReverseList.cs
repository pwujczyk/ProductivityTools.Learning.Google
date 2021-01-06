using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;

namespace ProductivityTools.Learning.Google.CodingTasks.b
{
    class Node
    {
        public int value;
        public Node Next;

        public Node(int a)
        {
            this.value = a;
        }
    }

    class ReverseList
    {
        public static void Do()
        {
            Node node = new Node(1);
            node.Next = new Node(2);
            node.Next.Next = new Node(3);
            Print(node);

            Node head = node;
            var newHead=Reverse(node,node.Next);
            head.Next = null;

            Print(newHead);

        }
        
        private static Node Reverse(Node left, Node right)
        {
            if (right == null) return left;
            var nextRight = right.Next;
            var nextLeft = right;
            right.Next = left;
            return Reverse(nextLeft, nextRight);

        }

        private static void Print(Node node)
        {
            Node iterator = node;
            while (iterator != null)
            {
                Console.WriteLine(iterator.value);
                iterator = iterator.Next;
            }
        }
    }
}
