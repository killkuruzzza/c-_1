//Напишите программу, 
//которая будет выдавать название дня недели по заданному номеру.

Console.Clear();
Console.Write("Введите номер дня недели: ");
int numberDayOfWeek = int.Parse(Console.ReadLine());
if (numberDayOfWeek < 1 || numberDayOfWeek > 7)
{
    Console.WriteLine("Введен неправильный номер");
    return;
}

if (numberDayOfWeek == 1)
{
    Console.WriteLine("Понедельник");
}
if (numberDayOfWeek == 2)
{
    Console.WriteLine("Вторник");
}
if (numberDayOfWeek == 3)
{
    Console.WriteLine("Среда");
}
if (numberDayOfWeek == 4)
{
    Console.WriteLine("Четверг");
}
if (numberDayOfWeek == 5)
{
    Console.WriteLine("Пятница");
}
if (numberDayOfWeek == 6)
{
    Console.WriteLine("Суббота");
}
if (numberDayOfWeek == 7)
{
    Console.WriteLine("Воскресенье");
}



// 5.Напишите программу, которая на вход принимает одно число (N),
//  а на выходе показывает все целые числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
// 4 * (-1) = -4