// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты X первой точки");
Console.Write("X1: ");
int x1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y первой точки");
Console.Write("Y1: ");
int y1Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты X второй точки");
Console.Write("X2: ");
int x2Coordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y второй точки");
Console.Write("Y2: ");
int y2Coordinate = Convert.ToInt32(Console.ReadLine());


double distance = Distance(x1Coordinate, y1Coordinate, x2Coordinate, y2Coordinate);
double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
Console.WriteLine($"Длина отрезка -> {distanceRound}");



double Distance (int x1, int y1, int x2, int y2)
{
    return Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
}


// Console.WriteLine("Введите координаты точки A");
// Console.Write("X: ");
// int xACoordinate = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int yACoordinate = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты точки B");
// Console.Write("X: ");
// int xBCoordinate = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int yBCoordinate = Convert.ToInt32(Console.ReadLine());

// double distance = Distance(xACoordinate,yACoordinate,xBCoordinate,yBCoordinate);
// double distanceRound = Math.Round(distance, 2, MidpointRounding.ToZero);
// Console.WriteLine(distanceRound);

// double Distance(int xA,int yA,int xB,int yB)
// {
//    return Math.Sqrt((xB - xA)*(xB - xA) + (yB - yA)*(yB - yA));
// }