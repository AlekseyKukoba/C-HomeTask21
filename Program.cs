// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53


int Coordinate(string pointName)
{
    Console.Write($"Введите координаты {pointName}: ");
    return int.Parse(Console.ReadLine()!);
}

int x1 = Coordinate("x точки A");
int y1 = Coordinate("y точки A");
int z1 = Coordinate("z точки A");
int x2 = Coordinate("x точки B");
int y2 = Coordinate("y точки B");
int z2 = Coordinate("z точки B");

double Distance(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2) +
                     Math.Pow((z2 - z1), 2));
}

double Length = Math.Round(Distance(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"Расстояние между точками:  {Length}");

