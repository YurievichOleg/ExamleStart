int[] array = {1,12,35,88,45,56,33,88,123,555,888};

int n = array.Length;

int find = 88;

int index = 0; 

while(index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}