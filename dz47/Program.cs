// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] arr = new double[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int z = 0; z < arr.GetLength(1); z++)
    {
       arr[i, z] = Convert.ToDouble(new Random().Next(-1000, 1001)) / 100;
    }
}
PrintArr(arr);

void PrintArr(double[,] arry)
{
    for (int i = 0; i < arr.GetLength(0); i++)
 {
    for (int z = 0; z < arr.GetLength(1); z++)
    {
      Console.Write($"{arry[i, z]}\t");
    }
    Console.WriteLine();
 }
}
