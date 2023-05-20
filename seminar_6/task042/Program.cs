/* Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. */

string Input(string text)
{
    Console.Write($"{text} ");
    return Console.ReadLine();
}

void Task3()
{
    int num = Convert.ToInt32(Input("Input number: "));
    int x = num;
    int resultInt = 0;
    int shift = 1;
    string resultStr = "";
    while (x > 0)
    {
        resultStr = x % 2 + resultStr;
        resultInt += x % 2 * shift;
        shift *= 10;
        x /= 2;
    }
    System.Console.WriteLine($"chislo v dvoichnom predstavlenii: {resultStr}");
    System.Console.WriteLine($"chislo v dvoichnom predstavlenii: {resultInt}");

}

Task3();