﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Dynamic;

namespace ProductivityTools.Learning.Google.A1.Sort
{
    class Program
    {

        static dynamic pawel()
        {
            return new { a=new int[0], b=new int[5] };
        }
        static void Main(string[] args)
        {
            dynamic x = pawel();
            int tablesize = 10;
            Console.WriteLine("Hello World!");
            int[] table = new int[tablesize];
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = new Random().Next(tablesize);
            }
            bool printTable = true;
            if (printTable) { Print(table); }

            //SortAndPrint(GetTableCopy(table), new BubbleSort(), nameof(BubbleSort), printTable); ;
            //SortAndPrint(GetTableCopy(table), new SelectionSort(), nameof(SelectionSort), printTable);
            //SortAndPrint(GetTableCopy(table), new InsertionSort(), nameof(InsertionSort), printTable);
            //SortAndPrint(GetTableCopy(table), new ShellSort(), nameof(ShellSort),printTable);
            //SortAndPrint(GetTableCopy(table), new MergeSort(), nameof(MergeSort), printTable);
            SortAndPrint(GetTableCopy(table), new QuickSort(), nameof(QuickSort), printTable);
            Console.Read();
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

        static void SortAndPrint(int[] table, ISort sorter, string name, bool print)
        {

            Console.WriteLine("===");
            Console.WriteLine($"Before and after sort:{name}");
            if (print) { Print(table); }
            var x = Stopwatch.StartNew();
            sorter.Sort(table);
            x.Stop();
            if (print) { Print(table); }
            Console.WriteLine($"Amount, time {x.Elapsed}");
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
