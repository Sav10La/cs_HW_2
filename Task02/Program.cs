﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 6 || day == 7)
{
    Console.WriteLine("Нет");
}
else if (day > 8 || day == 0)
{
    Console.WriteLine("Нужно ввести число от 1 до 7");
}
else
{
    Console.WriteLine("Да");
}