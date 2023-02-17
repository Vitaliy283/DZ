// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
SumElement(m, n);
Console.WriteLine("Сумма чисел равна {0}", sum);

void SumElement( int m, int n)
{
    if (n > m)
    {
        for (int i = m; i <= n; i++)
        {
            sum += i;
        }
    }
    else
    {
        for (int i = n; i <= m; i++)
        {
            sum += i;
        }
    }
}