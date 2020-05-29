using System;
using System.Collections.Generic;
using System.Text;

namespace ProductivityTools.Learning.Google.SumOfArrayElements
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello");
            Tests t = new Tests();
            t.ForeachElementTest();
            t.BinarySearchTest();
            Console.ReadLine();
        }
    }
}
