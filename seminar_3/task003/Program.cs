Console.WriteLine("your num");
int n = int.Parse(Console.ReadLine());
void SquareUp(int n)
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write(" " + Math.Pow(i, 2));
    }
}
SquareUp(n);

/* Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());
void SquareUpToN(int n)
{
for (int i = 1; i <= n; i++)
{
System.Console.Write(" "+Math.Pow(i, 2));
}
}
SquareUpToN(n); */