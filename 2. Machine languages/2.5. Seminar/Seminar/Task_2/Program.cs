// Замена знака элементов массива

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    Console.WriteLine(string.Join(" ", array));
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(string.Join(" ", array));
ChangeArray(array);