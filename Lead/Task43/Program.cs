// 43. Написать программу преобразования десятичного числа в двоичное
//string BinaryCode = Convert.ToString(123, 2);

Console.WriteLine(Convert.ToString(123, 2));

int n43 = 999;
Console.WriteLine($"Задача 43 {OverStr(IntToBin(n43))}");

string IntToBin(int num)
{
  string res = string.Empty;
  while (num >= 1)
  {
    res = res + $"{num % 2}";
    num /= 2;
  }
  return res;
}

string OverStr(string stringover)
{
  string res = string.Empty;
  for (int i = 0; i < stringover.Length; i++)
  {
    res = res + stringover[stringover.Length - i - 1];
  }
  return res;
}

