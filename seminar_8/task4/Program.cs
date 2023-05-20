/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
 */

int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
    int[,] arr = new int[firstLength, secondLength];

    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = new Random().Next(0, 10);

    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]} ");
        Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[] FindMin(int[,] arr)
{
    int[] min = new int[2];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] < arr[min[0], min[1]])
            {
                min[0] = i;
                min[1] = j;
            }
        }
    }
    System.Console.WriteLine(min[0]);
    System.Console.WriteLine(min[1]);
    System.Console.WriteLine();
    return min;
}

int[,] CreateArray(int[,] arr, int[] min)
{
    int[,] array2 = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
    int xShift = 0;
    int yShift = 0;

    for (int i = 0; i < array2.GetLength(0); i++)
    {
        if (i == min[0]) xShift = 1;
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            if (j == min[1]) yShift = 1;
            array2[i,j] = arr[i + xShift, j + yShift];
        }
        yShift = 0;
    }
return array2;
}

int[,] array = CreateTwoDimensionArray(4, 5);
PrintArray(array);
int[,] array2 = CreateArray(array, FindMin(array));
PrintArray(array2);
