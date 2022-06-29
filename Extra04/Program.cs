// Дополнительные задачи.
// Задача 4. Дано натуральное число, в котором все цифры различны. Определить, какая цифра расположена в нем левее: максимальная или минимальная.

long a = 1076543289;
string b = Convert.ToString(a);
char[] array = b.ToCharArray();
int index = 0;
int length = array.Length;
int max = array[0];
int min = array[0];
int imax = 0;
int imin = 0;

while (index < length)
{
    if (array[index]>max)
    {
        max = array[index];
        imax = index;        
    }
    else if (array[index]<min)
    {
        min = array[index];
        imin = index;
    }
    index++;
}
if (imax > imin)
{
    Console.WriteLine("Левее находится минимальная цифра.");
}
else
{
    Console.WriteLine("Левее находится максимальная цифра.");
}