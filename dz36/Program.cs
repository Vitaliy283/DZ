// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Console.Write("[ ");
for (int i = 0; i < size; i++)
{
   array[i] = new Random().Next(0, 10);
   Console.Write(array[i] + " ");
}
Console.WriteLine("]");
int sum = 0;
for (int i = 0; i < array.Length; i = i + 2)
{
    sum = sum + array[i];
}
Console.WriteLine("Сумма эллементов, стоящих на нечётных позициях: {0}", sum);