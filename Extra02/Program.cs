// Дополнительные задачи.
// Задача 2. На вход подаются год, номер месяца и день рождения человека, Определить возраст человека на момент 1 июля 2022 года.

Console.Write("Введите год рождения (например, 1990): ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите месяц рождения (для июля, например, 7): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите день рождения (например, 5): ");
int d = Convert.ToInt32(Console.ReadLine());

DateTime birthDate = new DateTime(y,m,d);
//DateTime birthDate = new DateTime(1990,7,2); для проверки калькуляции
DateTime endDate = new DateTime(2022,7,1);

Age(birthDate, endDate);

void Age(DateTime birthDate, DateTime endDate)
{
    int diff = endDate.Year - birthDate.Year;
    if (diff > 0)
    {
        if (birthDate.AddYears(diff) > endDate)
        {
            diff = diff - 1;
            Console.WriteLine(diff);
        }
        else
        {
            Console.WriteLine(diff);
        }
    }
    else
    {
        Console.WriteLine("Дата должна быть ранее 1 июля 2022 года.");
    }
}