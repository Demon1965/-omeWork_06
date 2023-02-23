// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Insert(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int Exponent(int num1, int num2)
{
    int res = 1;
    for(int i = 1; i <= num2; i++)
    {
        res = res * num1;
    }
    return res;
}

int num1 = Insert($"Please, insert the first number: ");
int num2 = Insert($"Please, insert the second number: ");
Console.Write($"Calculation result: {Exponent(num1, num2)}");