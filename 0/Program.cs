Console.Clear();
Console.Write("Введите число: ");
int number=int.Parse(Console.ReadLine());
//Решение математическим путем
double sqr=3.3*3.3;
Console.WriteLine($"Квадрат числа {number} равен = {sqr}");
//Решение с использованием библиотеки
int sqr1=Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine($"Квадрат числа {number} равен = {sqr1}");
double number2 = 3.3;
double sqr2=(Math.Pow(number2, 2));
Console.WriteLine($"Квадрат числа {number2} равен = {sqr2}");
