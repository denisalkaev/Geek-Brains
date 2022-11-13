// Есть ли число в массиве или нет

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

void FindNumber(int value, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == value)
        {
            Console.WriteLine("Yes");
            return;
        }
    }
    Console.WriteLine("No");
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(string.Join(" ", array));
Console.Write("Input value: ");
int N = int.Parse(Console.ReadLine()!);
FindNumber(5, array);