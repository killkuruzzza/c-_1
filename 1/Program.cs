// See https://aka.ms/new-console-template for more information
Console.Write("a:");
int a = int.Parse(Console.ReadLine());
Console.Write("b:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{Math.Pow(b,2) == a}");
if(Math.Pow(b,2) == a)
{
    Console.WriteLine("а квадрат b");
}else
{
    Console.WriteLine("а не квадрат b");
}
