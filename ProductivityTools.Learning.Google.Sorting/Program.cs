// See https://aka.ms/new-console-template for more information
using ProductivityTools.Learning.Google.Sorting;

Console.WriteLine("Hello, World!");
int[] array = new int[10];

Action printArray = () =>
{
    foreach (var item in array)
    {
        Console.Write(item);
    }
};


for (int i = 0; i < 10; i++)
{
    array[i] = new Random().Next(10);
}
printArray();

new QuickSort().Sort(array);
printArray();