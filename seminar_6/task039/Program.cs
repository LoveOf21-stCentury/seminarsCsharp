using System.Globalization;
using System;
/* Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.). Решите задачу без создания второго массива. */

void Fill(int[] nums, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.Next(minValue, maxValue);
    }
}

void Print(int[] nums)
{
    Random rnd = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        System.Console.Write($"{nums[i]} ");
    }
    System.Console.WriteLine();
}

void Revese(int[] nums)
{
    int half = nums.Length / 2;
    int last = nums.Length - 1;
    for (int i = 0; i < half; i++)
    {
        (nums[i], nums[last - i]) = (nums[last - i], nums[i]);
        /* int temp = nums[0];
        nums[i] = nums[last - i];
        nums[last - i] = temp; */
    }

}

void Task1()
{
    int size = 4;
    int[] nums = new int[size];
    Fill(nums);
    System.Console.WriteLine("Beginning array: ");
    Print(nums);
    Revese(nums);
    System.Console.WriteLine("Reverse array: ");
    Print(nums);
}

Task1();