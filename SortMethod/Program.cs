void FillArray(int[] array, int len)
{
    for (int i = 0; i < len; ++i)
    {
        array[i] = new Random().Next(1, 50);
    }
}

void SortArrayAscending(int[] array)
{
    Array.Sort(array);
}

void ReverseArray(int[] array)
{
    Array.Reverse(array);
}

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

int[] arr = new int[15];
int length = 15;
FillArray(arr, length);

Console.Write("Original array: ");
PrintArray(arr);

SortArrayAscending(arr);
Console.Write("Array sorted in ascend order: ");
PrintArray(arr);

ReverseArray(arr); // only reverses the existing array. Doesn't sort it.
Console.Write("Array sorted in descend order: ");
PrintArray(arr);





