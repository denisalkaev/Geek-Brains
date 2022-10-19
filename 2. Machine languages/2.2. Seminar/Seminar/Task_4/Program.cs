// Является ли одно число квадратом другого
Console.Clear();
Console.Write("Введите 1-е число: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите 2-е число ");
int num2 = int.Parse(Console.ReadLine()!);

string answer;
if (num1 * num1 == num2 || num2 * num2 == num1)
{
    answer = "Числа являются квадратами друг друга";
}
else
{
    answer = "Числа НЕ являются квадратами друг друга";
}
Console.WriteLine(answer);