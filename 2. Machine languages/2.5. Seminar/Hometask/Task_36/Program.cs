// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

void SumArray(int[] array)
{
    int sumVal = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumVal += array[i];
    }
    Console.WriteLine($"Сумма нечетных элементов массива: {sumVal}");
}

int[] array = GetArray(5, -100, 100);
SumArray(array);