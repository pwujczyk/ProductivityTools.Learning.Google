using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.CodingTasks.e
{
    class Node
    {
        public int Value;
        public Node Left, Right;
        public Node(int value)
        {
            this.Value = value;
        }
    } 
    public static class CommonAncestor
    {
        private static bool Covers(Node parent, Node node)
        { 
            if (parent == node) { return true; }
            if (parent ==null) { return false; }
            bool r1=Covers(parent.Left,node);
            bool r2=Covers(parent.Right, node);
            return r1 || r2;
            
        }

        private static Node FindCommon(Node head, Node a, Node b)
        {
            bool nodeAIsOnLeft = Covers(head.Left,a);
            bool nodeBIsOnLeft = Covers(head.Left,b);
            if(nodeAIsOnLeft!=nodeBIsOnLeft) { return head; }

            if(nodeAIsOnLeft)
            {
                return FindCommon(head.Left, a, b);
            }
            else
            {
                return FindCommon(head.Right, a, b);
            }

        }

        public static void Do()
        {
            var head = new Node(4);
            head.Left = new Node(2);
            head.Right = new Node(6);
            head.Left.Left = new Node(1);
            head.Left.Right = new Node(3);
            head.Right.Left = new Node(5);
            head.Right.Right = new Node(7);

           var x=FindCommon(head, head.Left.Left, head.Right.Right);
        }
    }
}
