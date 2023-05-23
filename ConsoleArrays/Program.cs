void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; ++i)
    {
        array[i] = new Random().Next(0, 11);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; ++i)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] arr = new int[10];
PrintArray(arr);
FillArray(arr);
PrintArray(arr);
