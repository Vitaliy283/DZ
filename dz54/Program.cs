// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];

ArrRandom(arr);
PrintArr(arr);
Console.WriteLine();
ModArr(arr);
PrintArr(arr);

void ArrRandom(int[,] arry)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int z = 0; z < arr.GetLength(1); z++)
    {
       arr[i, z] = new Random().Next(0, 11);
    }
}
}

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

void ModArr(int[,] arry)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}