// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Write("Введите количество строк и столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] arr1 = new int[m, m];
int[,] arr2 = new int[m, m];
int[,] arr3 = new int[m, m];
ArrRandom(arr1);
ArrRandom(arr2);
PrintArr(arr1);
Console.WriteLine("-----------------------");
PrintArr(arr2);
ProdArr(arr1, arr2, arr3);
Console.WriteLine("Произведение двух матриц");
PrintArr(arr3);

void ProdArr(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void PrintArr(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
 {
    for (int z = 0; z < arry.GetLength(1); z++)
    {
      Console.Write($"{arry[i, z]}\t");
    }
    Console.WriteLine();
 }
}

void ArrRandom(int[,] arry)
{
for (int i = 0; i < arry.GetLength(0); i++)
{
    for (int z = 0; z < arry.GetLength(1); z++)
    {
       arry[i, z] = new Random().Next(0, 6);
    }
}
}