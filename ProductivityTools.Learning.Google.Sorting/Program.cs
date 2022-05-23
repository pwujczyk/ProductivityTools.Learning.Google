// See https://aka.ms/new-console-template for more information
using ProductivityTools.Learning.Google.Sorting;

Console.WriteLine("Hello, World!");

Action<int[]> printArray = (a) =>
{
    foreach (var item in a)
    {
        Console.Write(item);
    }
    Console.WriteLine();
};


int[][] testArrays = new int[2][];
testArrays[0] = new int[5];
testArrays[0] = new int[5] { 0, 1, 2, 3, 4 };
testArrays[1] = new int[5];
testArrays[1] = new int[5] { 4, 3, 2, 1, 0 };

Action<int[]> performTest = (array) =>
{
    printArray(array);
    new QuickSort().Sort(array);
    printArray(array);

};

Action performTests = () =>
{
    foreach (var item in testArrays)
    {
        performTest(item);
    }
};

performTests();