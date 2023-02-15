// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк и столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, m];
ArrRandom(arr);
PrintArr(arr);
MinSumString(arr);

void MinSumString(int[,] arry)
{
    int MinSum = 1000;
    int Str = 0;
for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    int MinString = 10;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum += arr[i,j];
    }
    if (sum < MinString) MinString = sum;
    if (MinSum > sum) 
    {
        MinSum = sum;
        Str = i+1;
    }

}
Console.WriteLine("Минимальная сумма эллементов в строке {0}, равна {1}", Str, MinSum);
}

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