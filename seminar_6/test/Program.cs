//cartejj
(int, string) Test()
{
    int x = 6;
    string y = "hi";
    return (x, y);
}
System.Console.WriteLine(Test());
int num1;
string num2;
(num1, num2) = Test();
System.Console.WriteLine(num1);
System.Console.WriteLine(num2);

