// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Input {i + 1} number: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine($"Your array: {string.Join(", ", array)}");
}

void CountNumbers(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counter += 1;
    }
    Console.WriteLine($"Amount of numbers > 0: {counter}");
}

int[] array = new int[5];
FillArray(array);
CountNumbers(array);