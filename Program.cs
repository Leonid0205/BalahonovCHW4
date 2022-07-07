//Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

int SumOfDigits(int num)
{
    int sum = 0;
    for (int i = 0; num != 0; i++)
    {
        sum = sum + num%10;
        num = num/10;
    }
    return sum;
}
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of digits is: {SumOfDigits(num)}");
Console.WriteLine();

//Напишите программу, которая задаёт массив из 8 элементов
//и выводит их на экран.

int[] CreateArray(int n)
{
    int[] array = new int[n];
    for(int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Console.Write("Input size of an array: ");
int n = Convert.ToInt32(Console.ReadLine());
CreateArray(n);
PrintArray(CreateArray(n));