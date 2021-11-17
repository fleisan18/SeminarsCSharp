// 27. Определить количество цифр в числе
Console.WriteLine("Введите число");
string N = Console.ReadLine();
int Number(string n)
{
    int length = n.Length;
    return length;
}

Console.WriteLine($"В {N} {Number(N)} цифр");
