// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

void numberSquare(int number)
{
    int index = 1;
    while (index <= number)
    {
        Console.Write($"{index * index}, ");
        index++;
    }
}

int num = int.Parse(Console.ReadLine()!);
numberSquare(num);