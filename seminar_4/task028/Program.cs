/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. */

System.Console.WriteLine("Write your number, so that we could find factorial of your number, please: ");
int a = int.Parse(Console.ReadLine());
int Factorial(int num)
{
    int res = 1;
    for (int i = 1; i <= num; i++)
    {
        res *= i;
    }
    return res;
}
Console.WriteLine(Factorial(a));


