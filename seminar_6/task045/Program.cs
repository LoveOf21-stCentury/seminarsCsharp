void Fill(int[] arr, int minValue = -9, int maxValue = 9)
{
    maxValue++;
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue);
    }
}

void Print(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}


void Task5()
{
    int size = 4;
    int[] arr = new int[size];
    Fill(arr);
    Console.WriteLine("First array: ");
    Print(arr);

    int[] arr_copy = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr_copy[i] = arr[i];
    }
    arr[0] = 10100;

    Console.WriteLine("copy array: ");
    Print(arr_copy);

}

Task5();