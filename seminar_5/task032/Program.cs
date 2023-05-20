/* Задача 32: Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] */

void FillArray(int[] nums)
{
    /* Random rnd = new Random();
    System.Console.WriteLine("array is: ");
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = rnd.Next(-9, 10);
    } */
    for (int i = 0; i < nums.Length; i++)
    {
        System.Console.WriteLine($"write {i + 1} element: ");
        nums[i] = Convert.ToInt32(Console.ReadLine());
    }
    System.Console.WriteLine();
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write($"{nums[i]} ");
    }
    System.Console.WriteLine();

}

void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        System.Console.WriteLine($"element {i+1}: {numbers[i]}");
    }
    System.Console.WriteLine();
}

void ChangeSign(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] *= -1;
    }
}

void Task1()
{
    int size = 3;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    ChangeSign(numbers);
    PrintArray(numbers);
}

Task1();