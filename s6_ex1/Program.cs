Console.Write($"Введите количество элементов массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

void FillArray(int[] array)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int NewArray(int[] array)
{ 
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (array[i] > 0) count = count + 1;
        if (array[i] < 0) count = 0;
    }
    return count;
}

FillArray(array);
Console.WriteLine();
int col = NewArray(array);
Console.WriteLine($"Положительных чисел в данном массиве: {col} ");


