int SumNum(int num) 
{
    int res = 0;
    for (int i = 1; i <= num; i++)
    {
        res += i;
    }
    return res;
}
System.Console.WriteLine("write your num: ");
int num = int.Parse(Console.ReadLine());
System.Console.WriteLine("Result of Sum " + SumNum(num)); 