// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
   Console.Write("Введите элемент: ");
   array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("] ");
    int count = 0;
for (int i = 0; i < n; i++)
{
    if (array[i] > 0) count++;
}
Console.WriteLine("Чисел больше нуля {0}", count);