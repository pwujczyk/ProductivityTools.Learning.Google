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


int[][] testArrays = new int[6][];
testArrays[0] = new int[5];
testArrays[0] = new int[5] { 0, 1, 2, 3, 4 };
testArrays[1] = new int[5];
testArrays[1] = new int[5] { 4, 3, 2, 1, 0 };
testArrays[2] = new int[5];
testArrays[2] = new int[5] { 2, 3, 3, 0, 0 };
testArrays[3] = new int[10];
testArrays[3] = new int[10] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

testArrays[4] = new int[6];
testArrays[4] = new int[6] { 3, 2, 4, 1, 5, 0 };

testArrays[5] = new int[5];
testArrays[5] = new int[5] { 10, 3, 2, 1, 8 };

Action<int[]> performTest = (array) =>
{
    printArray(array);
   // new QuickSort().Sort(array);
    new QuickSort2().Sort(array);
    printArray(array);

};

Action performTests = () =>
{
    foreach (var item in testArrays)
    {
        Console.WriteLine("-----------");
        performTest(item);
    }
};

performTests();
//performTest(testArrays[5]);