using System;

namespace ProductivityTools.Learning.Google.PriorityQuene
{
    class Program
    {
        static void Main(string[] args)
        {
            var x=new PriorityQuene(10);

            for (int i = 0; i < 10000; i++)
            {
                int z = new Random().Next(10);
                x.AddMax(z);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
