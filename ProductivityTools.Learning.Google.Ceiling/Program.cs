using System;
using System.Collections;

namespace ProductivityTools.Learning.Google.Ceiling
{
    class node
    {
        int value;
        public node left;
        public node right;
        public node(int value)
        {
            this.value = value;
        }

        public int FindFloor(int value)
        {
            if (this.value == value) { return value; }
            if (value < this.value)
            {
                if (left == null) return this.value;
                return this.left.FindFloor(value);
            }
            if (this.value < value)
            {
                if (this.right == null) return this.value;
                return this.right.FindFloor(value);
            }
            throw new Exception("Something went wrong");
        }

        public void TreeTraverse(Queue q)
        {
            if (this.left!=null)
            {
                this.left.TreeTraverse(q);
            }
            q.Enqueue(this.value);
            if(this.right!=null)
            {
                this.right.TreeTraverse(q);
            }
        }

        public Queue TreeTraverse()
        {
            Queue queue = new Queue();
            TreeTraverse(queue);
            return queue;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            node root = new node(100);
            root.left = new node(50);
            root.right = new node(200);
            node current = root.left;
            current.left = new node(3);
            current.right = new node(70);


            var r=root.FindFloor(60);
            var traverse = root.TreeTraverse();
            Console.WriteLine("Hello World!");
        }
    }
}
