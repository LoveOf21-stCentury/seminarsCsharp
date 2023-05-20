double Dist()
{
    Console.Write("Ввдите координату по оси первой точки X:\t");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Ввдите координату по оси первой точки Y:\t");
    double b = double.Parse(Console.ReadLine());
    Console.Write("Ввдите координату по оси первой точки X:\t");
    double c = double.Parse(Console.ReadLine());
    Console.Write("Ввдите координату по оси первой точки Y:\t");
    double d = double.Parse(Console.ReadLine());
    double r = Math.Sqrt(Math.Pow((c - a), 2) + Math.Pow((b - d), 2));
    return r;
}
Console.Write($"Расстрояение {Dist()}");