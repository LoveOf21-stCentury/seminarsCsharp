int digit = GetDigitFromNumber(ReadInt(), ReadInt());

if (digit != -1)
{
Console.WriteLine(digit);
}
else
{
Console.WriteLine("OOps");
}


int GetDigitFromNumber(int number, int digitPosition)
{
number = Math.Abs(number);

if (number < Math.Pow(10, digitPosition - 1)) // 100
{
return -1; // -1 - эТо ошибка.
}

while (number > Math.Pow(10, digitPosition))
{
number /= 10;
}

return number % 10;
}

int ReadInt()
{
Console.WriteLine("Input number");
return int.Parse(Console.ReadLine());
}