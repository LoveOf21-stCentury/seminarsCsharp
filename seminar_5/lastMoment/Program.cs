using System;
void Test(int num)
{
    num++;
}

void Test2(int[] numbers)
{
    numbers[0]++;
}

int[] x = new int[1];
x[0] = 10;
Test2(x);
System.Console.WriteLine(x[0]);

