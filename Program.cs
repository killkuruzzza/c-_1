Console.Clear();
int num = int.Parse(Console.ReadLine());
int N = (int)Math.Log10(num) - 2;
Console.WriteLine(N < 0 ? "Третьей цифры нет" : (num % (int)Math.Pow(10, N + 1) / (int)Math.Pow(10, N)).ToString());