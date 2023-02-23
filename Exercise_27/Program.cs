// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Insert(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int SumAll(int num)
{
    int dig=0; 
    int sum=0;
    while(num>0)
    {
        dig=num%10;
        sum=sum+dig;
        num=num/10;
    }
    return sum;
}

int num = Insert($"Please, insert any positive number: ");
Console.Write($"The sum of all digits is: {SumAll(num)}");