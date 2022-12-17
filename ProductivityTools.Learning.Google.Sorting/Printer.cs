using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityTools.Learning.Google.Sorting
{
    public static class Printer
    {
        public static void Print(int[] a)
        {
            foreach (var item in a)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
