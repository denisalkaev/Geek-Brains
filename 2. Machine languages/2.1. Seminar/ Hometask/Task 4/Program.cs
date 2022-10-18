// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.Clear();

int numbers = 3;
List<int> numbersList = new List<int>();

for (int i = 0; i < numbers; i++)
{
    Console.Write($"Введите {i} число: ");
    int number = int.Parse(Console.ReadLine()!);
    numbersList.Add(number);
}
int min_num = numbersList[0];
int max_num = min_num;

for (int i = 1; i < numbers; i++)
{
    if (numbersList[i] > min_num)
    {
        max_num = numbersList[i];
    }
    else
    {
        min_num = numbersList[i];
    }
}

Console.WriteLine($"Максимально число {max_num}, Минимальноче число {min_num}");