/* Задача 35: Задайте одномерный массив из 10 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. */

void FillArray(int[] nums, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.Next(minValue, maxValue);
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

int CountEl(int[] numbers)
{
    int count = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] >= 10 && numbers[i] <= 99)
        {
            count++;
        }
    }

    return count;
}

void Test3()
{
    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, -10, 99);
    PrintArray(numbers);
    int count = CountEl(numbers);
    System.Console.WriteLine($"count from line [10, 99] is {count}");
}

Test3();