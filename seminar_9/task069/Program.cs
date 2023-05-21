/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */
int Pow(int num1, int num2)
{
    if (num2 > 1)
    {
        return num1 * Pow(num1, num2 - 1);
    }
    return num1;
}
System.Console.WriteLine(Pow(3, 5));