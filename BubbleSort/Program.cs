void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine();
}

void FillArray(int length, int[] array)
{
    for (int i = 0; i < length; ++i)
    {
        array[i] = new Random().Next(1, 10);
    }
}

void BubbleSort(int length, int[] array)
{
    for (int iteration = 0; iteration < length - 1; ++iteration)
    {
        bool swapped = false;
        for (int i = 0; i < length - iteration - 1; ++i)
        {
            if (array[i] > array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
                swapped = true;
            }
        }
        if (!swapped)
        {
            Console.WriteLine($"The algo stopped at iteration {iteration + 1} of {length}");
            return;
        }
    }
    Console.WriteLine("The algo didn't finish before the last iteration");
}

int[] array = new int[20];
int length = array.Length;
FillArray(length, array);
PrintArray(array);

BubbleSort(length, array);
PrintArray(array);

