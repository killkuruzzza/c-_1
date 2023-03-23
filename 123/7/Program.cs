string[] array = new string[6] { "123", "qwerty", "job", "0705", "God", "Russia" };
string[] arrayResult = new string[3];

void FillArray(string[] array, string[] arrayResult)
{
    for (int i = 0; i < array.Length; i++)
        if (i < 3) arrayResult[i] = array[i];
}

void PrintArray(string[] arrayResult)
{
    for (int i = 0; i < 3; i++)
        Console.Write($"{arrayResult[i]}, ");
}

FillArray(array, arrayResult);
PrintArray(arrayResult);