// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

string weekDay;
if (number > 0 && number < 8)
{
    if (number > 5) weekDay = "Выходной";
    else weekDay = "Рабочий";
    Console.WriteLine(weekDay);
}
else
{
    Console.WriteLine("Число введено некорректно");
}