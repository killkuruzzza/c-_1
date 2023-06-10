//Задача2
Console.WriteLine("Введите первое число: ");
            int num_A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            int num_B = Convert.ToInt32(Console.ReadLine());

            if (num_A > num_B)
            {
                Console.WriteLine("Первое число " + num_A + " больше чем второе " + num_B);
            }
            else
            {
                Console.WriteLine("Второе число " + num_B + " больше чем первое " + num_A);
            }
// Задача4
Console.WriteLine("Введите 3 числа:");
            int num_1 = Convert.ToInt32(Console.ReadLine());
            int num_2 = Convert.ToInt32(Console.ReadLine());
            int num_3 = Convert.ToInt32(Console.ReadLine());

            int max = num_1;

            if (num_2 > max)
            {
                max = num_2;
            }

            if (num_3 > max)
            {
                max = num_3;
            }

            Console.WriteLine("Наибольшее из введённых чисел -> " + max);


//Задача6
Console.WriteLine("Введите число:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 1)
            {
                Console.WriteLine("Число " + num + " является: НЕЧЁТНЫМ");
            }
            else
            {
                Console.WriteLine("Число " + num + "является: ЧЁТНЫМ");
            }

//Задача8

int N= int.Parse(Console.ReadLine());
int B=-N;
while (B<=N)
{
    Console.Write($"{B} ");
    B++;

}

//Доп.ЗАдача
Console.Clear();
Console.Write("Введите трехзначное число: ");
int num=int.Parse(Console.ReadLine());
int y=num%10;

Console.WriteLine($"{y}");
