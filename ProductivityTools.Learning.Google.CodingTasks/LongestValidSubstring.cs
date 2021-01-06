using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.CodingTasks
{
    class LongestValidSubstring
    {
        public static void Do()
        {
            string s = "(())";
            int result = 0;
            Stack<int> stack = new Stack<int>();
            stack.Push(-1);

            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();

                    }

                    if (stack.Count > 0)
                    {
                        result = Math.Max(result, i - stack.Peek());
                    }
                    else
                    {
                        stack.Push(i);
                    }

                }
            }
        }
    }
}
