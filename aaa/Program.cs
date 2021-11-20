 int Fill_Array (int[] array_fill, int min) 
{
    for ( int i = min; y < array_fill.Length; i++)
    {
        array_fill[i] = i;
    } 
    return array_fill[i];
}
void Print_Array(int[] array_print)
{
    for(int j = 0; j < array_print.Length; j++)
    {
        Console.Write($"{array_print[j]}");
    }
}
Console.Clear();
int[] number = new int [1000];
int min_Value = 6;
number = Fill_Array(number, min_Value);
    for (int i = 0; i <= number.Length; i++)
    {
        if (number[i] == 2 || number[i] == 3 || number[i] == 5 || number[i] == 7)
        {
        Console.WriteLine($"Это простое число: {number[i]}");
        } 
        if (number[i] %2 != 0 || number[i] %3 !=0 || number[i] %5 !=0 || number[i] %7 !=0)
        {
        Console.WriteLine($"Это простое число: {number[i]}");
        }
Print_Array(number);
