/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N включительно.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write("Введите число ");
int N = int.Parse(Console.ReadLine());
int count = 0;
while (count <= N) {
    int namber = (count % 2);
    if (namber == 0) {
        Console.Write ($"{count}"); // нужно как-то записывать значения
    }
    count++;
}