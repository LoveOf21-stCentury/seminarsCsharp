/* using System;

namespace Project
{
    class Program
    {
     static void Main(string[] args)
        { */
/* Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. */

void FillArray(int[] nums)
{
    Random rnd = new Random();
    System.Console.WriteLine("array is: ");
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.Next(-9, 10);
    }
}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.WriteLine($"array: {numbers[i]}");
    }
    System.Console.WriteLine();
}

void FindEl(int[] numbers, int a)
{
    bool flag = false;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (a == numbers[i])
        {
            flag = true;
        }
    }
    if (flag) System.Console.WriteLine("num is found");
    else System.Console.WriteLine("num is not");
}

void Task2()
{
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    System.Console.WriteLine("write num what you want find");
    int aSymbol = Convert.ToInt32(Console.ReadLine());
    FindEl(numbers, aSymbol);
}

Task2();
/*         }
    }
} */

