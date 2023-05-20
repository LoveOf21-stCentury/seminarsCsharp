/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.*/

string Input (string text) 
{
    Console.Write($"{text} ");
    return Console.ReadLine();
}

bool Check(int a, int b, int c)
{
    return a + b > c && a + c > b && c + b > a;
}

void Task2()
{
    int sideA = Convert.ToInt32(Input("Input A side: "));
    int sideB = Convert.ToInt32(Input("Input B side: "));
    int sideC = Convert.ToInt32(Input("Input C side: "));

    if (Check(sideA, sideB, sideC))
        System.Console.WriteLine("it's possible");
    else
        System.Console.WriteLine("it's impossible");

}

Task2();