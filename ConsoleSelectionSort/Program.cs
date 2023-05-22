void PrintArray(int[] array, int len)
{
    for (int i = 0; i < len; ++i)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FillArray(int[] array, int len)
{
    for (int i = 0; i < len; ++i)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

void SelectiveSort(int[] array, int len)
{
    for (int startIndex = 0; startIndex < len - 1; ++startIndex)
    {
        int min_index = startIndex;
        for (int j = startIndex + 1; j < len; ++j)
        {
            if (array[min_index] > array[j])
                min_index = j;
        }
        int tmp = array[min_index];
        array[min_index] = array[startIndex];
        array[startIndex] = tmp;
    }
}

int[] array = new int[20];
int length = array.Length;

FillArray(array, length);
PrintArray(array, length);
SelectiveSort(array, length);
PrintArray(array, length);

