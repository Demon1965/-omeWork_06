// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write($"Please, insert any positive number:  ");
int num=Convert.ToInt32(Console.ReadLine());
for (int z=1; z<=num; z++)
{
    Console.Write($"{Math.Pow(z, 3)}  ");
}
    


