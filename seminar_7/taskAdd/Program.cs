int[,] CreateTwoArray(int Heigth, int Lenght)
{
    int[,] array = new int[Heigth, Lenght];
    int q = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = q * q;
            q++;
        }
    return array;
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        System.Console.WriteLine();
    }
}
Print(CreateTwoArray(3, 4));
