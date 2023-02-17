// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//  которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Массив AxAxA Введите A: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,,] arr = new int[m, m, m];

CreateArr(arr);
PrintArr(arr);

void CreateArr(int[,,] arr)
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] = count;
                count += 1;
            }
        }
    }
}

void PrintArr(int[,,] arry)
{
    for (int i = 0; i < m; i++)
 {
    for (int j = 0; j < m; j++)
    {
        Console.WriteLine();
      for (int z = 0; z < m; z++)
      {
        Console.Write("{0} ({1}, {2}, {3})", arry[i, j, z], i, j, z);
      }
    }
    Console.WriteLine();
 }
}