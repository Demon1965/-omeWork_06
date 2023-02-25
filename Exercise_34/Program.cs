// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
        arr[i]=rnd.Next(100, 1000);
    }  
    return arr;
}

int length=Insert("Please, insert the quantity of array elements: ");
int[] arr=CreateArray(length);
Console.WriteLine($"array = [{string.Join(", ", arr)}]");
int counter=0;
for(int i=0; i<length; i++)
{
    if(arr[i]%2==0)
    {
        counter++;
    }
}
Console.WriteLine($"There are {counter} even elements in this array.");