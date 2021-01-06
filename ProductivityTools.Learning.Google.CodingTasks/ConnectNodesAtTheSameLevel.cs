using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.CodingTasks.f
{
    class Node
    {
        public int data;
        public Node left, right, nextRight;

        public Node(int item)
        {
            data = item;
            left = right = nextRight = null;
        }
    }


    public class ConnectNodesAtTheSameLevel
    {
        Node root;
        void connect(Node p)
        {
            // initialize queue to hold nodes at same level  
            Queue<Node> q = new Queue<Node>();

            q.Enqueue(root); // adding nodes to tehe queue  

            Node temp = null; // initializing prev to null  
            while (q.Count > 0)
            {
                int n = q.Count;
                for (int i = 0; i < n; i++)
                {
                    Node prev = temp;
                    temp = q.Dequeue();

                    // i > 0 because when i is 0 prev points  
                    // the last node of previous level,  
                    // so we skip it  
                    if (i > 0)
                        prev.nextRight = temp;

                    if (temp.left != null)
                        q.Enqueue(temp.left);

                    if (temp.right != null)
                        q.Enqueue(temp.right);
                }

                // pointing last node of the nth level to null  
                temp.nextRight = null;
            }
        }

        public static void Do()
        {
            ConnectNodesAtTheSameLevel tree = new ConnectNodesAtTheSameLevel();

            /* Constructed binary tree is  
                10  
                / \  
            8     2  
            /  
            3  
            */
            tree.root = new Node(10);
            tree.root.left = new Node(8);
            tree.root.right = new Node(2);
            tree.root.left.left = new Node(3);
            tree.root.right.left = new Node(11);

            // Populates nextRight pointer in all nodes  
            tree.connect(tree.root);

            // Let us check the values of nextRight pointers  
            Console.WriteLine("Following are populated nextRight pointers in "
                            + "the tree"
                            + "(-1 is printed if there is no nextRight)");
            int a = tree.root.nextRight != null ? tree.root.nextRight.data : -1;
            Console.WriteLine("nextRight of " + tree.root.data + " is "
                            + a);
            int b = tree.root.left.nextRight != null ? tree.root.left.nextRight.data : -1;
            Console.WriteLine("nextRight of " + tree.root.left.data + " is "
                            + b);
            int c = tree.root.right.nextRight != null ? tree.root.right.nextRight.data : -1;
            Console.WriteLine("nextRight of " + tree.root.right.data + " is "
                            + c);
            int d = tree.root.left.left.nextRight != null ? tree.root.left.left.nextRight.data : -1;
            Console.WriteLine("nextRight of " + tree.root.left.left.data + " is "
                            + d);

            Console.ReadKey();
        }
    }
}
