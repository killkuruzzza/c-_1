//Напишите программу, 
//которая будет выдавать название дня недели по заданному номеру.

Console.Clear();
Console.Write("Введите номер дня недели: ");
int numberDayOfWeek=int.Parse(Console.ReadLine());
//       
while(numberDayOfWeek < 1 || numberDayOfWeek > 7)// &&  ==   !  '5' < '17'
{
    Console.WriteLine("Введен неправильный номер");
    Console.Write("Введите номер дня недели: ");
    numberDayOfWeek = int.Parse(Console.ReadLine());
}

if(numberDayOfWeek==1){
    Console.WriteLine("Понедельник");
}if(numberDayOfWeek==2){
    Console.WriteLine("Вторник");
}if(numberDayOfWeek==3){
    Console.WriteLine("Среда");
}if(numberDayOfWeek==4){
    Console.WriteLine("Четверг");
}if(numberDayOfWeek==5){
    Console.WriteLine("Пятница");
}if(numberDayOfWeek==6){
    Console.WriteLine("Суббота");
}if (numberDayOfWeek == 7)
{
    Console.WriteLine("Воскресенье");
}
/*
7. Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает **последнюю** цифру этого числа.
    
    456 -> 6
    
    782 -> 2
    
    918 -> 8
**Задание 1:** Напишите программу, которая на вход принимает два числа и выдаёт,
 какое число большее, а какое меньшее.

a = 5; b = 7 ->  max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

**Задание 2:** Напишите программу, которая принимает на вход
 три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

**Задание 3:** Напишите программу, которая на вход принимает число и выдаёт,
 является ли число чётным (делится ли оно на два без остатка).
int a = 5;
int ost = 5 % 2
int ost1 = 4 % 2
4 -> да
-3 -> нет
7 -> нет

**Задание 4:** Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.

5  -> 2, 4
8  -> 2, 4, 6, 8
*/