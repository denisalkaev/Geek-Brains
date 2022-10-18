Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int i = number % 2;
string answer;

if (i == 0)
{
    answer = "Четное число";
}
else
{
    answer = "Нечетное число";
}

Console.WriteLine(answer);