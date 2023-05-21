/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8" */

void Print(int number1, int number2)
{
    System.Console.Write($"{number1} ");

    if (number1 != number2)
    {
        Print(number1 + 1, number2);
    }
};
Print(4, 8);



//дополнительная задача
/* void Print(int number1, int number2)
{
    System.Console.WriteLine($"{number1} ");

    if (number1 < number2)
    {
        Print(number1 + 1, number2 - 1);
        Console.WriteLine(number2);
    }


};
Print(1, 5); */



