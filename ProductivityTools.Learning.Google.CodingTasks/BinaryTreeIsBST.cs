using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProductivityTools.Learning.Google.CodingTasks.d
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


    class BinaryTreeIsBST
    {
        public static bool ValidateTree(Node tree)
        {
            if (tree == null) return true;
            if (tree.Left == null && tree.Right == null) return true;
            if (tree.Left == null ^ tree.Right == null) return false;

            bool leftpart=ValidateTree(tree.Left);
            bool rightpart = ValidateTree(tree.Right);

            if (tree.Left.Value < tree.Value && tree.Value < tree.Right.Value && leftpart && rightpart)
            {
                return true;
            }
            else
            {
                return false;
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
            var r1 = ValidateTree(head);
            head.Right.Right = new Node(7);
            var r2=ValidateTree(head);

        }
    }
}
