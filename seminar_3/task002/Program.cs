
int CoordinateWords(int x, int y)
{
    if (x > 0 && y > 0)
    {
        return 1;
    }
    else if (x < 0 && y > 0)
    {
        return 2;
    }
    else if (x < 0 && y < 0)
    {
        return 3;
    }
    else if (x > 0 && y < 0)
    {
        return 4;
    }
    else
    {
        return -1;
    }
}

void RangeWords(int RangeW)
{
    if (RangeW == 1)
    {
        System.Console.WriteLine("[x:1, y:Infinity]");
    }
    else if (RangeW == 2)
    {
        System.Console.WriteLine("[x:Infinity, y:Infinity]");

    }
    else if (RangeW == 3)
    {
        System.Console.WriteLine("[x:Infinity, y:Infinity]");

    }
    else if (RangeW == 4)
    {
        System.Console.WriteLine("[x:infinity, y:Infinity]");
    }
    else
    {
        System.Console.WriteLine("it's not a quarter");
    }
}

int x = int.Parse(Console.ReadLine());
/* int y = int.Parse(Console.ReadLine()); */


RangeWords(x);