// Дополнительные задачи.
//Задача 1. Написать программу, которая определяет, является ли треугольник со сторонами a, b, c равнобедренным.

Console.WriteLine("Введите длину стороны a:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину стороны b:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину стороны c:");
int c = Convert.ToInt32(Console.ReadLine());

Triangle(a, b, c);

void Triangle(int a, int b, int c)
{
    if (a + b > c & b + c > a & c + b > a)
    {
        if (a == b | b == c | a == c)
        {
            Console.WriteLine("Треугольник со сторонами a, b, c является равнобедренным.");
        }
        else
        {
            Console.WriteLine("Треугольник со сторонами a, b, c не является равнобедренным.");
        }
    }
    else
    {
        Console.WriteLine("Длина любой стороны треугольника должна быть меньше суммы длин двух его других сторон.");
    }
}
Console.WriteLine();