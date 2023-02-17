// Задача 64: Задайте значение N. Напишите программу,
// Которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
NToLow(n, count);
void NToLow(int number, int count)
{
    if (n > 0)
    {
    if (count > n)
    {
        return;
    }
    else
    {
        NToLow(n, count + 1);
        Console.Write(count + " ");
    }
    }
    else Console.WriteLine("{0} - не натуральное число", n);
}