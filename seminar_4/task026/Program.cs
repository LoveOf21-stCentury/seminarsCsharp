/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */



// 1-st method
/* System.Console.WriteLine("Write your number:");
string a = Console.ReadLine();

char[] arr = a.ToString().ToCharArray();N
System.Console.WriteLine($"sum of num: {arr.Length}"); */



//2-nd method by method
/* int ByMethod()
{
    System.Console.WriteLine("your num");
    string a = Console.ReadLine();
    return a.Length;
}
int str = ByMethod();
Console.WriteLine("Sum of number " + str);
 */



//3-rd method by Math;
/* int Get(int num)
{
    int count = 1;
    while (num > 9)
    {
        num /= 10;
        count++;
    }
    return count;
}
int a = int.Parse(Console.ReadLine());
System.Console.WriteLine("sum of chisel " + Get(a)); */