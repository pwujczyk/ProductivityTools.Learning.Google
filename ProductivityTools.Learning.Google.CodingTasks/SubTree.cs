using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.CodingTasks.S
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

    static class SubTree
    {
        static char MARKER = '$';

        // This function returns empty string if tree 
        // contains a duplicate subtree of size 2 or more. 
        public static String dupSubUtil(Node root,
                        HashSet<String> subtrees)
        {
            String s = "";

            // If current node is NULL, return marker 
            if (root == null)
                return s + MARKER;

            // If left subtree has a duplicate subtree. 
            String lStr = dupSubUtil(root.left, subtrees);
            if (lStr.Equals(s))
                return s;

            // Do same for right subtree 
            String rStr = dupSubUtil(root.right, subtrees);
            if (rStr.Equals(s))
                return s;

            // Serialize current subtree 
            s = s + root.data + lStr + rStr;

            // If current subtree already exists in hash 
            // table. [Note that size of a serialized tree 
            // with single node is 3 as it has two marker 
            // nodes. 
            if (s.Length > 3 && subtrees.Contains(s))
                return "";

            subtrees.Add(s);
            return s;
        }

        // Function to find if the Binary Tree contains 
        // duplicate subtrees of size 2 or more 
        public static String dupSub(Node root)
        {
            HashSet<String> subtrees = new HashSet<String>();
            return dupSubUtil(root, subtrees);
        }

        // Driver code 
        public static void Do()
        {
            Node root = new Node('A');
            root.left = new Node('B');
            root.right = new Node('C');
            root.left.left = new Node('D');
            root.left.right = new Node('E');
            root.right.right = new Node('B');
            root.right.right.right = new Node('E');
            root.right.right.left = new Node('D');
            String str = dupSub(root);
            if (str.Equals(""))
                Console.Write(" Yes ");
            else
                Console.Write(" No ");
        }
    }


}
