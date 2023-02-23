// Требуется перевод положительного целого числа в массив его знаков.


int Insert(string message)
{
    Console.Write("Please, insert any positive number:  ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void CreateArray(int num)
{
    int num2=num;
    string str=num2.ToString();
    int z=str.Length;
    int[] array=new int[z];
    for(int i=0; i<z; i++)
    {
        if(num>0)
        {
            array[z-1-i]=num%10; 
            num=num/10; 
        }
        else
        {
           break; 
        }
    }
    Console.Write($"array = [" + string.Join(", ", array) + "]"); 
}

int num=Insert("Please, insert any positive number:  ");
CreateArray(num);