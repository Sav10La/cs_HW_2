// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int i = Convert.ToInt32(Console.ReadLine());

ThirdDigit(i);

void ThirdDigit(int a) //f(x)
{
    if (a > 100)
    {
        string b = Convert.ToString(a);
        Console.WriteLine(b[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }

}
Console.WriteLine();