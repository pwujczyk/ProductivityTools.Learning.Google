using System;

namespace ProductivityTools.Learning.Google.A1.QuickFind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QF qf = new QF(4);
            qf.PrintTable();
            Console.WriteLine(qf.Connected(1, 2));

            Console.WriteLine();
            qf.Union(1, 2);
            qf.PrintTable();
            Console.WriteLine(qf.Connected(1, 2));


            Console.WriteLine();
            qf.Union(0, 2);
            qf.PrintTable();
            Console.WriteLine(qf.Connected(0, 1));

            Console.Read();
        }
    }
}
