// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Enter x first's point -> ");
double xx = double.Parse(Console.ReadLine());
Console.Write("Enter y first's point -> ");
double xy = double.Parse(Console.ReadLine());
Console.Write("Enter z first's point -> ");
double xz = double.Parse(Console.ReadLine());
Console.Write("Enter x second's point -> ");
double yx = double.Parse(Console.ReadLine());
Console.Write("Enter y second's point -> ");
double yy = double.Parse(Console.ReadLine());
Console.Write("Enter z second's point -> ");
double yz = double.Parse(Console.ReadLine());

// sqrt((x_2 - x_1)^2 + (y_2 - y_1)^2 + (z_2 - z_1)^2)

double res = Math.Sqrt(Math.Pow(yx - xx, 2) + Math.Pow(yy - xy, 2) + Math.Pow(yz - xz, 2));
Console.Write($"Distance between points -> {res}");
