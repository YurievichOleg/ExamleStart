﻿
int Max(int arg1, int arg2, int arg3 )
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
} 


int[] array = {1,13,16,45,33,54,687,34,2357}; 

//int max1 = Max(a1,b1,c1);
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
//int max = Max(max1, max2, max3);

int max = Max(Max(array[0],array[1], array[2]), 
Max(array[3],array[4], array[5]), 
Max(array[6],array[7], array[8]) );

//int max = a1;
//if (b1 > max) max = b1;
//if (c1 > max) max = c1;


//if (a2 > max) max = c2;
//if (b2 > max) max = b2;
//if (c2 > max) max = c2;

//if (a3 > max) max = c3;
//if (b3 > max) max = b3;
//if (c3 > max) max = c3;

Console.WriteLine($"max = {max}");
