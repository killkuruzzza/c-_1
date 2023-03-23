// 1.Напишите программу, которая на вход принимает два числа и проверяет,
//  является ли первое число квадратом второго.
// a = 5; b = 25->да
// a = 2 b = 10->нет
Console.Clear();
Console.Write("Введите число а:");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b:");
int b = int.Parse(Console.ReadLine());
if (a == b * b){
    Console.WriteLine("Да");
}else{
    Console.WriteLine("Нет");
}
