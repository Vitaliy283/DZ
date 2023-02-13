// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
// 1 1 -> 9

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int z = 0; z < arr.GetLength(1); z++)
    {
       arr[i, z] = new Random().Next(-10, 11);
    }
}
PrintArr(arr);

Console.WriteLine("Введите позицию эллемента");
Console.Write("Введите строку от 0 до {0}: ",m - 1);
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец от 0 до {0}: ",n - 1);
int b = Convert.ToInt32(Console.ReadLine());

if (a < arr.GetLength(0) && b < arr.GetLength(1)) 
{
Console.WriteLine("Эллемент в позиции {0}, {1} это {2}", a, b, arr[a, b]);
}
else Console.WriteLine("Такого элемента нет");

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
