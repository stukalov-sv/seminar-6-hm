/*
Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
*/

(double, double) FunctionIntersection(int k1, int b1, int k2, int b2)
{
    double temp1 = b2 - b1;
    double temp2 = k1 - k2;
    double x = temp1 / temp2;
    double y = k1 * temp1 / temp2 + b1;
  
    return (x, y);
}

Console.WriteLine("For y = k1 * x + b1:");
Console.Write("Enter b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Enter k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("For y = k2 * x + b2:");
Console.Write("Enter b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.Write("Enter k2: ");
int k2 = int.Parse(Console.ReadLine());

(double x, double y) = FunctionIntersection(k1, b1, k2, b2);
Console.WriteLine();
Console.WriteLine($"Point of intersection: ({x},{y})");