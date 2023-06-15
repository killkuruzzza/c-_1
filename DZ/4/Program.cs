/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Немного отклонился от условия, сделал программу которая на вход принимает три числа,
а выдает и максимальное и минимальное из них. Думаю это не проблема,? :)

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.WriteLine ("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите число b");
int b = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите число c");
int c = int.Parse(Console.ReadLine());
int max = a;
int min = a;
if (a>b) {
    max = a;
    min = b;
}
else {
    max = b;
    min = a;
}
if (c>max) {
    max = c;
}
if (c<min) {
    min = c;
}
Console.WriteLine ($"Максимально значение {max}");
Console.WriteLine ($"Минимальное значение {min}");