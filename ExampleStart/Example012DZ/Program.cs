//Массив

int[]array = new int[10];
int n = array.Length;
int index = 0;
while(index<n)
{
    array[index]= new Random().Next(10,100);
    Console.Write($"{array[index]} ," );
    index++;
    
}

Console.WriteLine();
Console.Write($"{array[0]}, ");
//Элементы удовоетворяющие условию возрастания
index = 0;
while(array[index]<array[index+1])
{
    if(index<n)
    {
        
        Console.Write($"{array[index+1]}, ");
        
        
    }
    index++;
}
Console.WriteLine();
//Исключаем те эдементы значения которых больше среднего арефметического
int sum = 0;
index = 0;
while(index<n)
{
    sum = sum + array[index];
    index++;
    
}
double sasum = sum/n;
Console.WriteLine($"Среднее арифметическое = {sasum}");
index = 0;
while(index<n)
{
    if(array[index]<sasum)
    {
        
        Console.Write($"{array[index]}, ");
        
        
    }
    index++;
}
Console.WriteLine();

//Исключаем четные из ряда
index = 0;
while(index<n)
{
    if(array[index]%2==1)
    {
        
        Console.Write($"{array[index]}, ");
        
        
    }
    index++;
}

