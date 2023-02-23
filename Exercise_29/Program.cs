// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int Insert(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void NewArray(int qua, int min, int max)
{
    int[] array=new int[qua];
    for(int i=0; i<qua; i++)
    {
        array[i]=new Random().Next(min, max+1);
    }
    Console.Write($"array = [" + string.Join(", ", array) + "]");
}

int qua = Insert($"Please, insert the quantity of array's member: ");
int min = Insert($"Please, insert min number: ");
int max = Insert($"Please, insert max number: ");
NewArray(qua, min, max);