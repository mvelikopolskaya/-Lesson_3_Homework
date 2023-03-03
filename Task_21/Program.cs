// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве


Console.WriteLine("Введите координаты первой точки: ");
Console.Write("X1 = ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 = ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1 = ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки: ");
Console.Write("X2 = ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 = ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2 = ");
int Z2 = Convert.ToInt32(Console.ReadLine());

double range = Range(X1, Y1, Z1, X2, Y2, Z2);
Console.WriteLine($"Расстояние между точками в 3D пространстве равно: {Math.Round(range, 2, MidpointRounding.ToZero)}");


double Range(int numX1, int numY1, int numZ1, int numX2, int numY2, int numZ2)
{
    double result = Math.Sqrt(Math.Pow(numX1 - numX2, 2) + Math.Pow(numY1 - numY2, 2) + Math.Pow(numZ1 - numZ2, 2));
    return result;
} 