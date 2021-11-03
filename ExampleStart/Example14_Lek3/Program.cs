

// 1 Группа методов(ничего не принимают, ничего не вщзвращают)
void Method1()
{
    Console.WriteLine("Автор ...");
}

//Method1();

//2 Группа методов(могут принимать- ничего не возвращают)
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения" );

void Method2_1(string msg, int count)
{
   int i = 0;
   while (i < count)
   {
       Console.WriteLine(msg);
       i++;
   } 
}
//Method2_1(msg:"Свободу попугаям", count: 3);


//3 Группа методов (что то возвращают - ничего не принимают)
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);


// 4 Группа методов (что то принимают - что то возвращают)

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;

}
//string res = Method4(4,"Hello");
//Console.WriteLine(res);


//Пересобрали 4 метод с помощью цикла for
string Method4_1(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;

}
string res = Method4(4,"Hello");
//Console.WriteLine(res);

//Задача с выводом таблицы умножения на экран

// for (int i = 2; i <= 10; i++)
// {
//     for (int j=2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i}*{j} = {i*j}");
//     }
//     Console.WriteLine();
// }



// Задача по замене знаков в тексте
// дан текст :
// пробелы надо заменить черточками;
// знак "С" заменить на "с".
//– Я думаю, – сказал князь, улыбаясь,  – что,
//  ежели бы вас послали вместо нашего милого Винценгероде,
// вы бы взяли приступом согласие прусского короля. 
// Вы так красноречивы. Вы дадите мне чаю?

string text = "– Я думаю, – сказал князь, улыбаясь, – что,"
            + "ежели бы вас послали вместо нашего милого"
            + " Винценгероде, вы бы взяли приступом согласие"
            + " прусского короля. Вы так красноречивы."
            + " Вы дадите мне чаю?";

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;

    for (int i = 0; i < length; i ++)
    {
        if(text[i]== oldValue) 
        result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
// string newText = Replase(text, ' ', '_');
// string newText1 = Replase(newText, 'с', 'С');
// Console.WriteLine(newText1);


// Алгоритм сортировки методом выбора

int[] arr = {5, 2, 3, 1, 8, 9, 1, 1, 7, 8, 3, 5, 4, 6};
void PrintArray(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    int count = array.Length;
    for(int i = 0; i < count-1; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < count; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array [minPosition];
        array[minPosition]= temporary;

    }

}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);