using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProductivityTools.Learning.Google.CodingTasks
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int val)
        {
            data = val;
            next = null;
        }
    }

    public static class NumberOfIntInArray
    {
        static Node push(Node head, int new_data)
        {
            // allocate node 
            Node new_node = new Node(new_data);

            // link the old list off the new node 
            new_node.next = head;

            // move the head to point to the new node 
            head = new_node;

            return head;
        }

        public static int Count(Node head, int value)
        {
            if (head == null) return 0;

            if(head.data==value)
            {
                return 1 + Count(head.next, value);
            }
            else
            {
                return Count(head.next, value);
            }

            throw new Exception();
        }

        public static void Do()
        {
            // Start with the empty list 
            Node head = null;

            /* Use push() to construct below list  
            1->2->1->3->1 */
            head = push(head, 1);
            head = push(head, 3);
            head = push(head, 1);
            head = push(head, 2);
            head = push(head, 1);

            var r=Count(head, 1);
        }
    }
}
