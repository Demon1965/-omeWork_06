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

string Reverse(int num)
{
    int nom=num; 
    int dig=0;
    string res="";
    for(int z=0; z<=4; z++)
        {
            dig=dig*10+nom%10;
            nom=nom/10;
            if(dig==num)
            {
                res="The number you've inserted is PALINDROME!"; 
            }
            else
            {
                res="The number you've inserted is USUAL number!";
            }
        }
    return res;
}



int num=Promt("Please, insert any five-digit number:  ");
if (10000<=num && num<=99999)
    {
        string res=Reverse(num);
        Console.Write(res);
    }
else
    {
        Console.Write("You're wrong! Try again...");
    }