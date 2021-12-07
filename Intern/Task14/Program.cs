// 14. Найти третью цифру числа или сообщить, что её нет

string FindThirdNumber(int N) //ищем третью цифру справа налево
{
    string NumStr = Convert.ToString(Math.Abs(N));
    string result;
    if (NumStr.Length < 3) result = $"У числа {N} нет третьей цифры";
    else result = $"{NumStr[NumStr.Length - 3]}";
    return result;
}

int Number14 = new Random().Next(-10000, 10000);
Console.WriteLine($"Третья цифра для числа {Number14} = {FindThirdNumber(Number14)}");
