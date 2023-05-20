/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */
System.Console.WriteLine("your: ");
int num = int.Parse(Console.ReadLine());
int[] Random(int num) 
{
    int[] res = new int[num];
    for (int i = 0; i < num; i++)
    {
        res[i] = (new Random().Next(0, 2));
    }
    return res;
}
System.Console.WriteLine(String.Join(", ", Random(num)));

/* + " it's random" */