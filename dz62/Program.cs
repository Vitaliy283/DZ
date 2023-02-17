// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите количество строк и столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, m];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= arr.GetLength(0) * arr.GetLength(1))
{
  arr[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < arr.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= arr.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > arr.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArr(arr);

void WriteArr(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}