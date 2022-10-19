Console.Clear();

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int posittion = 0;
    while (posittion < count)
    {
        Console.WriteLine(col[posittion]);
        posittion++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создаем массив из 10 пустых элементов

FillArray(array);
array[4] = 4;
array[7] = 4;
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 34345);
Console.WriteLine(pos);