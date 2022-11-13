// Задача "со звездочкой": Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    Console.WriteLine(string.Join(" ", array));
    return array;
}

void SortedArrayDown(int[] array)
{
    int counts = array.Length;
    while (counts != 0)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int x = 0;
            int y = 0;
            if (array[i] >= array[i - 1])
            {
                x = array[i];
                y = array[i - 1];
                array[i - 1] = x;
                array[i] = y;
            }
        }
        counts += 1;
    }
    Console.WriteLine(string.Join(" ", array));
}

int[] array = GetArray(10, -10, 10);
SortedArrayDown(array);