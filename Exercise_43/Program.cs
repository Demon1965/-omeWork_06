// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Insert(string message)
{
   Console.Write(message);
   double num=Convert.ToDouble(Console.ReadLine());
   return num;
}

void CrossPodouble(double k1, double b1, double k2, double b2)
{
    double x=0;
    double y=0;
    x=(b2-b1)/(k1-k2);
    y=k1*x+b1;
    Console.WriteLine($"These lines are crossing in the point with coordinate {x}, {y}.");
}

double k1=Insert("Please, insert k1: ");
double b1=Insert("Please, insert b1: ");
double k2=Insert("Please, insert k2: ");
double b2=Insert("Please, insert b2: ");
if(k1==k2)
{ 
    if(b1==b2)
    {
        Console.WriteLine($"These lines match.");
    }
    else
    {
        Console.WriteLine($"These lines are parallel.");
    }
}
else
{
    CrossPodouble(k1, b1, k2, b2);
}
