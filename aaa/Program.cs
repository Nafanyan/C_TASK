﻿/* int Fill_Array (int [] array_fill, int min) 
{
    int length = array_fill.Length;
    for(int i=0; i < length; i++)
    {
        array_fill[i] = min + 1;
    }
    return array_fill;
}

void Print_Array(int [] array_print)
{
    int length_print = array_print.Length;
    for(int i = 0; i < length_print; i++)
    {
        Console.Write($"{array_print[i]}");
    }
}
int[] arrayA = new int [30];
int min1 = 2;
arrayA = Fill_Array(arrayA, min1);
Print_Array(arrayA);
System.Console.WriteLine();
 */

 int Fill_Array (int [] array_fill, int min) 
{
    int length = array_fill.Length;
    for(int i=0; i < length; i++)
    {
        array_fill[i] = min + 1;
    }
    return array_fill;
}
void Print_Array(int [] array_print)
{
    int length_print = array_print.Length;
    for(int j = 0; j < length_print; j++)
    {
        Console.Write($"{array_print[j]}");
    }
}
Console.Clear();
int[] number = new int [90];
Fill_Array(number, 2);
int b = 0;
while ( (number[b] * number[b]) < number.Length)
{
    for (int c = 0; c <= number.Length; c++)
    {
        if (number[b] == 2 || number[b] == 3 || number[b] == 5 || number[b] == 7)
        {
        System.Console.WriteLine($"Это простое число{number[b]}");
        }
    }
    b++;
    
}
Print_Array(number);