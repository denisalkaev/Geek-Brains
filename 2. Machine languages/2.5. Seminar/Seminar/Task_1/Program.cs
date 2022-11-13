// Создать массив из N элементов и вычисоить сумму отрицательных и положительных чисел

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

void CountNumbers(int[] array)
{
    int sumPos = 0;
    int sumNeg = 0;

    foreach (int el in array)
    {
        sumPos += el > 0 ? el : 0; // если el > 0, то суммируем el или 0 (тернарный оператор)
        sumNeg += el < 0 ? el : 0; // если el < 0, то суммируем el или 0
    }
    Console.WriteLine($"Сумма положительных элементов равна {sumPos}");
    Console.WriteLine($"Сумма отрицательных элементов равна {sumNeg}");
}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(string.Join(" ", array));
CountNumbers(array);