using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

            void FillArray(int[] nums)
            {
                Random rnd = new Random();
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = rnd.Next(-9, 10);
                }
            }

            void PrintArray(int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }
                Console.WriteLine();
            }

            int GetPositiveSum(int[] numbers)
            {
                int sum = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > 0) sum += numbers[i];
                }
                return sum;
            }

            int GetNegativeSum(int[] numbers)
            {
                int sum = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < 0) sum += numbers[i];
                }
                return sum;
            }

            /* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива. */
            void Task0()
            {
                int size = 10;
                int[] numbers = new int[size];
                FillArray(numbers);
                PrintArray(numbers);
                
                int sum = GetPositiveSum(numbers);
                System.Console.WriteLine($"sum of positive elements {sum}");
                System.Console.WriteLine($"sum of negative elements {GetNegativeSum(numbers)}");

            }

            //                                                           методы 
            // процедуры(не возвращает значение например - выкинуть мусор)   функции(возвращает значение например - мясорубка(пожарить мясо или приготовить суп после полученного результата))
            Task0();
        }
    }
}