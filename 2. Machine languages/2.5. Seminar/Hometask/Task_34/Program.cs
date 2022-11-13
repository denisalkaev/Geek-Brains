// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int[] GetArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    Console.WriteLine(string.Join(" ", array));
    return array;
}

void CountNumbers(int[] array)
{
    int counts = 0;
    foreach (int el in array)
    {
        if (el % 2 == 0)
        {
            counts++;
        }
    }
    Console.WriteLine($"Количество четных чисел: {counts}");
}

int[] array = GetArray(3);
CountNumbers(array);