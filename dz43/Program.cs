// Задача 43: Напишите программу, которая0 найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine("Прямые пересекутся в точке с координатами X: {0}, Y: {1}", x, y);