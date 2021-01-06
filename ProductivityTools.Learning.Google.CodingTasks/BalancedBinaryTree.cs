using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace ProductivityTools.Learning.Google.CodingTasks.c
{
    class Node
    {
        public Node Left, Right;
    }

    class BalancedBinaryTree
    {
        private static int GetHeight(Node node)
        {
            if (node == null)
            {
                return 1;
            }
            else
            {
                int leftHeight = 1 + GetHeight(node.Left);
                int rightHeight = 1 + GetHeight(node.Right);
                if (leftHeight!=rightHeight)
                {
                    return -1;
                }
                return leftHeight;
            }
        }

        private static bool Validate(Node head)
        {

            var height=GetHeight(head);
            if (height==-1)
            {
                return false;
            }

            return true; ;
        }

        public static void Do()
        {
            var head = new Node();
            head.Left = new Node();
            head.Right = new Node();
            head.Left.Left = new Node();
            head.Left.Right = new Node();
            head.Right.Left = new Node();

            Validate(head);

            head.Right.Right = new Node();
            Validate(head);
        }
    }
}
