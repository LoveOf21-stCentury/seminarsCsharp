/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */
string Input(string text)
{
    Console.Write($"{text} ");
    return Console.ReadLine();
}

void Task4()
{
    int numF = 0;
    int numS = 1;
    int count = Convert.ToInt32(Input("Count elements posledovatel'nosti: "));
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{numF} ");
        (numF, numS) = (numS, numF + numS);
        /* int temp = numF;
        numF = numS;
        numS = temp + numS; */
    }
}

Task4();