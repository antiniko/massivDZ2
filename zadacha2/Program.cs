// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double GetDistance(double x1, double y1, double z1, double x2,double y2, double z2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double zDistance = z2 - z1;

    return Math.Sqrt(Math.Pow(xDistance,2) + Math.Pow(yDistance,2) + Math.Pow(yDistance,2));
}

double xA, yA, zA, xB, yB, zB;

Console.Write("input x for point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("input y for point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("input z for point A: ");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("input x for point B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("input y for point B: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("input z for point B: ");
zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(GetDistance(xA, yA, zA, xB, yB, zB));