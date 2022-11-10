// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

void GetArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input {i + 1} value for array: ");
        int N = int.Parse(Console.ReadLine()!);
        array[i] = N;
    }
}

int[] newArray = new int[8];
GetArray(newArray);
Console.WriteLine($"Your array is {string.Join(",", newArray)}");