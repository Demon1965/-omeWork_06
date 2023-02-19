// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int Promt(string message)
{
    Console.Write(message);
    string str = Console.ReadLine();
    int num = Convert.ToInt32(str);
    return num;
}

int num=Promt("Please, insert the five-digit number: ");
    if (10000<=num && num<=99999)
    {   
        int res=0;
        int res1=num;
        while(res1>=1)
        {
            res=res*10+res1%10;
            res1=res1/10;
        }
            if (num==res)
            {
                Console.WriteLine("The number you've inserted is PALINDROME!");
            }
                else
            {
                Console.WriteLine("The number you've inserted is USUAL number!");
            }
    }
    else
    {
        Console.WriteLine("You're wrong! Try again");
    }
