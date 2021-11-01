
void NewMas(int[] collection)
{
    int minValue = -99;
    int maxValue = 99;
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(minValue,maxValue +1);
        Console.Write($"{collection[index]} ");
        index ++;
    }
    Console.WriteLine();
    Console.WriteLine();
}


void Vozrastanie(int [] chisla)
{
    int count = chisla.Length;
    int position = 1;
    int max = chisla[0];
    Console.WriteLine(max);
    while (position < count)
    {
        if(chisla[position] > max )
        {
            Console.WriteLine(chisla[position]);
            max = chisla[position];

           
            
        }
        position++;
    }
Console.WriteLine();
}




void Bolshe(int[] nomer)
{
    int razmer = nomer.Length;
    int raspol = 0;
    int a = 8;
    while(raspol<razmer)
    {
        if(nomer[raspol] < a)
        {
        Console.WriteLine($"{nomer[raspol]}, ");
        
        }
        raspol++;
    }
    Console.WriteLine();
}


void plusminus(int[] znachenie)
{
    int kolvo = znachenie.Length;
    int mesto = 1;
    Console.WriteLine(znachenie[0]);
    while(mesto < kolvo)
    {
        if(znachenie[mesto] < 0)
        {
            if(znachenie[mesto-1]>0)
            Console.WriteLine(znachenie[mesto]);
            //znak = b;

        }
        else
       {
           if(znachenie[mesto-1]<0)
         
           Console.WriteLine(znachenie[mesto]);
           // znak = a;
        }
        mesto++;
    }
}

int[]  array = new int [15];
NewMas(array);
Vozrastanie(array);
Bolshe(array);
plusminus(array);
