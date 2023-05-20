/* Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива. */

int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
    int[,] array = new int[firstLength, secondLength];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);

    return array;
}

void ChengRows(int[,] array)
{

    for (int i = 0; i < array.GetLength(1); i++)
        {
            int temp = array[0, i];
            array[0, i] = array[array.GetLength(0) - 1, i];
            array[array.GetLength(0) - 1, i] = temp;
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}
int[,] array = CreateTwoDimensionArray(4, 4);
PrintArray(array);
ChengRows(array);
Console.WriteLine("");
PrintArray(array);