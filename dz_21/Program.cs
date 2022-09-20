// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance (double x1, double y1,double z1, double x2, double y2, double z2)
{
    double distance = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2) +Math.Pow(z2 - z1,2));
    return distance;
}

Console.WriteLine("Введите первое значение по оси х:");
double x1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите первое значение по оси y:");
double y1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите первое значение по оси z:");
double z1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе значение по оси x:");
double x2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе значение по оси y:");
double y2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе значение по оси z:");
double z2 = double.Parse(Console.ReadLine()!);

double dist = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine(dist);