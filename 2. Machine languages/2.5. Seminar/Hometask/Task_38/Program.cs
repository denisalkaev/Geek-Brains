// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    Console.WriteLine(string.Join(" ", array));
    return array;
}

double MinVal(double[] array)
{
    double minValue = array[0];
    foreach (double el in array)
    {
        minValue = el < minValue ? el : minValue;
    }
    return minValue;
}

double MaxVal(double[] array)
{
    double maxValue = array[0];
    foreach (double el in array)
    {
        maxValue = el > maxValue ? el : maxValue;
    }
    return maxValue;
}

double[] array = GetArray(5, -10, 10);
Console.WriteLine($"Минимальное значение: {MinVal(array):f1}");
Console.WriteLine($"Максимальное значение: {MaxVal(array):f1}");
Console.WriteLine($"Разница между Max & Min: {MaxVal(array) - MinVal(array):f1}");