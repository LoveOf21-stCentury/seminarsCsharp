System.Console.WriteLine("Write your number x: ");
double x = double.Parse(Console.ReadLine());
System.Console.WriteLine("Write your number y: ");
double y = double.Parse(Console.ReadLine());

System.Console.WriteLine(CheckXY(x, y));

string CheckXY(double x, double y)
{
    if (x > 0 && y > 0)
    {
        return "1 chetvert'";
    }
    else if (x < 0 && y > 0)
    {
        return "no it's not";
    }
    else if (x < 0 && y < 0)
    {
        return "no it's not";
    }
    else if (x > 0 && y < 0)
    {
        return "no it's not";
    }
    else
    {
        return "nothing is works";
    }
}

