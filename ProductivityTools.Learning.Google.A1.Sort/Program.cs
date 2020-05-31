using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Dynamic;

namespace ProductivityTools.Learning.Google.A1.Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] table = new int[100000];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new Random().Next(10);
            }
            Print(table);

           SortAndPrint(GetTableCopy(table), new Bubble());
           SortAndPrint(GetTableCopy(table), new SelectionSort());
        }

        static int[] GetTableCopy(int[] table)
        {
            int[] result = new int[table.Length];
            for (int i = 0; i < table.Length; i++)
            {
                result[i] = table[i];
            }
            return result;
        }

        static void SortAndPrint(int[]table, ISort sorter)
        {

            Console.WriteLine("===");
            Console.WriteLine("Before and after sort:");
            // Print(table);
            var x = Stopwatch.StartNew();
            var r = sorter.Sort(table);
            x.Stop();
            Console.WriteLine(x.Elapsed);
           // Print(table);
            Console.WriteLine($"Amount{r}");
        }

        static void Print(int[] table)
        {
            
            foreach (var item in table)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
