using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductivityTools.Learning.Google.A1.Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] table = new int[10];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new Random().Next(10);
            }
            Print(table);
            var r=new Bubble().Sort(table);
            Console.WriteLine($"Amount{r}");
            Print(table);
        }

        static void Print(int[] table)
        {
            Console.WriteLine("===");
            foreach (var item in table)
            {
                Console.WriteLine(item);
            }
        }
    }
}
