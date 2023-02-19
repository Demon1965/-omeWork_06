// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance3D(double ax, double ay, double az, double bx, double by, double bz)
{
double distance = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
return Math.Round(distance, 2);
}

Console.Write("Please, insert coordinate Х of point А: ");
double Ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, insert coordinyte Y of point А: ");
double Ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, insert coordinate Z of point А: ");
double Az = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, insert coordinate Х of point B: ");
double Bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, insert coordinate Y of point B: ");
double By = Convert.ToDouble(Console.ReadLine());
Console.Write("Please, insert coordinate Z of point B: ");
double Bz = Convert.ToDouble(Console.ReadLine());

double result = Distance3D(Ax, Ay, Az, Bx, By, Bz);
System.Console.WriteLine($"The distance between these points in 3D will be:  {result}");
