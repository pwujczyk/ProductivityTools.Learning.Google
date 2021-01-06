using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.CodingTasks
{
    static class ReplaceNumbers
    {
        public static void Do()
        {
            int a = 3, b = 5;
            b = a + b;
            a = b - a;
            b = b - a;

            a = 3;b = 5;
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
        }
    }
}
