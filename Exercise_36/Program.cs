// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Insert(string message)
{
    Console.Write(message);
    int length=Convert.ToInt32(Console.ReadLine());
    return length;
}

int[] CreateArray(int length)
{
    int[] arr=new int[length];
    Random rnd=new Random();
    for(int i=0; i<length; i++)
    {
        arr[i]=rnd.Next(-50, 51);
    }  
    return arr;
}

int Summ(int[] arr, int length)
{
    int sum=0;
    for(int i=1; i<length; i+=2)
    {
        sum+=arr[i];
    }
    return sum;
}
int length=Insert("Please, insert the quantity of array elements: ");
int[] arr=CreateArray(length);
Console.WriteLine($"array = [{string.Join(", ", arr)}]");
Console.WriteLine($"Amount of all elements with negative index is: {Summ(arr, length)}");