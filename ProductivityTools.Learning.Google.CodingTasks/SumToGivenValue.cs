using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace ProductivityTools.Learning.Google.CodingTasks.q
{
    public class Node
    {
        public int data;
        public Node left, right;
        public Node(int data)
        {
            this.data = data;
        }
    };

    class SumToGivenValue
    {
        private static void CalculateToGivenSum(Node node, int[] previous, int level, int expectedSum)
        {
            if (node == null) return;
            var sum = node.data;
            for (int i = level; i > 0; i--)
            {
                if (sum == expectedSum)
                {
                    Console.WriteLine("Found");
                }
                sum += previous[i];
            }

            previous[level] = node.data;
            CalculateToGivenSum(node.left, previous, 1 + level, expectedSum);
            CalculateToGivenSum(node.right, previous, 1 + level, expectedSum);

        }

        public static void CalculateSumToGiven(Node root, int value)
        {
            int[] previous = new int[3];
            CalculateToGivenSum(root, previous, 0, value);
        }

        public static void Do()
        {
            Node root = new Node(1);
            root.left = new Node(2);
            root.right = new Node(3);
            root.left.left = new Node(4);
            root.left.right = new Node(5);
            root.right.left = new Node(6);
            root.right.right = new Node(7);

            CalculateSumToGiven(root, 4);
        }
    }
}
