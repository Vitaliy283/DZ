// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
Console.WriteLine("Введите диапазон заполнения массива");
Console.Write("Введите начало диапазона: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("[ ");
for (int i = 0; i < size; i++)
{
   array[i] = new Random().Next(a, b);
   Console.Write(array[i] + " ");
}
Console.WriteLine("]");
int max = a;
int min = b;
int c = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
c = max - min;
Console.WriteLine("Максимальный элемент равен: {0}", max);
Console.WriteLine("Минимальный элемент равен: {0}", min);
Console.WriteLine("Разницу между максимальным и минимальным элементов равна: {0}", c);