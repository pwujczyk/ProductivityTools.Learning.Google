using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ProductivityTools.Learning.Google.BinaryTree
{
    class BinaryTree
    {
        int[] Tree;
        int Size = 8;

        public BinaryTree()
        {
            this.Tree = new int[Size];
            int n = 1;
            this.Tree[n] = 8; int a = 2 * n; int b = 2 * n + 1;

            this.Tree[a] = 5; int c = 2 * a; int d = 2 * a + 1;
            this.Tree[b] = 6; int e = 2 * b; int f = 2 * b + 1;

            this.Tree[c] = 2;
            this.Tree[d] = 4;

            this.Tree[e] = 5;
            this.Tree[f] = 1;

            //ChangeNode(f, 10);
            SinkNode(1, 3);
        }

        private void Swap(int a, int b)
        {
            int temp = this.Tree[a];
            this.Tree[a] = this.Tree[b];
            this.Tree[b] = temp;
        }

        private void Swim(int node)
        {
            while (node > 1 && this.Tree[node / 2] < this.Tree[node])
            {
                Swap(node / 2, node);
                node = node / 2;
            }
        }

        private void Sink(int node)
        {
            while (2 * node <= Size)
            {
                int left = node * 2;
                int right = node * 2 + 1;
                if (this.Tree[left]<this.Tree[right])
                {
                    if (this.Tree[node] < this.Tree[right])
                    {
                        Swap(node, right);
                        node = right;
                    }
                    else
                    {
                        break;
                    }
                }
                else 
                {
                    if (this.Tree[node] < this.Tree[left])
                    {
                        Swap(left, node);
                        node = left;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public void SwimNode(int node, int value)
        {
            this.Tree[node] = value;
            Swim(node);
        }

        public void SinkNode(int node, int value)
        {
            this.Tree[node] = value;
            Sink(node);
        }
    }
}
