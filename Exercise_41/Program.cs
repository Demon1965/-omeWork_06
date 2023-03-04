// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int InsertCheck(int set)
{
    int count=0;
    for(int i=0; i<set; i++)
    {
        Console.Write("Please, insert any number: ");
        int num=Convert.ToInt32(Console.ReadLine());
        if (num>0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Please, insert the quantity of numbers: ");
int set=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"We've searched {InsertCheck(set)} positive numbers.");