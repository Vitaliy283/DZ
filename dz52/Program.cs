// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int z = 0; z < arr.GetLength(1); z++)
    {
       arr[i, z] = new Random().Next(0, 11);
    }
}
PrintArr(arr);

void PrintArr(int[,] arry)
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

for (int k = 0; k < arr.GetLength(1) ; k++)
{
    double prod = 0;
    for (int q = 0; q < arr.GetLength(0); q++)
    {
        prod += arr[q, k];
    } 
    Console.WriteLine("Среднее арифметическое {0} столбца = {1}", k + 1, prod / arr.GetLength(0));
}