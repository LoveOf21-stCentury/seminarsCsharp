/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

int SumNum(int num)
{
    if (num > 0)
    {
        return num % 10 + SumNum(num / 10);
    }
    return num % 10;
}

Console.WriteLine(SumNum(532));
