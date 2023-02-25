// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

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
        arr[i]=rnd.Next(0, 100);
    }  
    return arr;
}

int DiffMinMax(int[] arr, int length)
{
    int min=arr[0];
    int max=arr[1];
    int diff=0;
    for(int i=0; i<length-1; i++)
    {
        if(arr[i]<=min)
        {
            min=arr[i];
        }
        if(arr[i]>=max)
        {
            max=arr[i];
        }
    }
    diff=max-min;
    return diff;
}

int length=Insert("Please, insert the quantity of array elements: ");
int[] arr=CreateArray(length);
Console.WriteLine($"array = [{string.Join(", ", arr)}]");
Console.WriteLine($"Difference of max/min numbers is: {DiffMinMax(arr, length)}");