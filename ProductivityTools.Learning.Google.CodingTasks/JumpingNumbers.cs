using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.CodingTasks
{
    class JumpingNumbers
    {
        public void bfs(int maxNumber, int iterator)
        {
            // Create a queue and enqueue 'i' to it 
            Queue<int> q = new Queue<int>();
            q.Enqueue(iterator);

            // Do BFS starting from i 
            while (q.Count != 0)
            {
                iterator = q.Peek();
                q.Dequeue();
                if (iterator <= maxNumber)
                {
                    Console.Write(iterator + " ");
                    int last_digit = iterator % 10;

                    // If last digit is 0, append next digit only 
                    if (last_digit == 0)
                    {
                        q.Enqueue((iterator * 10) + (last_digit + 1));
                    }

                    // If last digit is 9, append previous digit only 
                    else if (last_digit == 9)
                    {
                        q.Enqueue((iterator * 10) + (last_digit - 1));
                    }

                    // If last digit is neighter 0 nor 9, append both 
                    // previous and next digits 
                    else
                    {
                        q.Enqueue((iterator * 10) + (last_digit - 1));
                        q.Enqueue((iterator * 10) + (last_digit + 1));
                    }
                }
            }
        }

        // Prints all jumping numbers smaller than or equal to 
        // a positive number x 
        public void printJumping(int x)
        {
            Console.Write("0 ");

            for (int i = 1; i <= 9 && i <= x; i++)
            {
                this.bfs(x, i);
            }
        }

        // Driver code 
        public static void Do()
        {
            int x = 40;
            JumpingNumbers obj = new JumpingNumbers();
            obj.printJumping(x);
        }
    }
}
