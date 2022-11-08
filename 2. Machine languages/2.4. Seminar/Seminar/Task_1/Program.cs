// Найти произведение чисел от 1 до N

// Console.Clear();
// int GetMult(int value)
// {
//     int mult = 1;
//     for (int i = 1; i <= value; i++)
//     {
//         mult *= i;
//     }
//     return mult;
// }

// Console.Write("Input value: ");
// int N = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Произведение числе равно {GetMult(N)}");

// Написать программу по выводу случайнного массива из 8 элементов

Console.Clear();
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

// void PrintArray(int[] array)
// {
//     for (int i=0; i < array.Length; i++)
//     {
//         Console.Write(array[i]);
//     }
// }

int[] array = new int[8];
FillArray(array);
// PrintArray(array);
Console.WriteLine(string.Join(",", array));