// Дополнительные задачи.
// Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. Определить размер депозита через n месяцев.

Console.Write("Введите количество месяцев: ");
int period = Convert.ToInt32(Console.ReadLine());

int depo = 1000;
double rate = 0.015;

//double final = Math.Round((depo * Math.Pow((1 + rate), period)),2); для округления до сотых
double final = (depo * Math.Pow((1 + rate), period));
Console.WriteLine($"Сумма депозита через {period} месяцев составит {final}");