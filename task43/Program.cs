/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

Console.Clear();
Console.Write("Ведите количество число b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.Write("Ведите количество число k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Ведите количество число b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.Write("Ведите количество число k2: ");
double k2 = double.Parse(Console.ReadLine()!);
double x = 0;
double y = 0;
FindCross(b1, b2, k1, k2, out x, out y);
Console.WriteLine($"Координаты пересечения двух прямых: ({x}; {y})");

void FindCross(double b1, double b2, double k1, double k2, out double x, out double y)
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
}

